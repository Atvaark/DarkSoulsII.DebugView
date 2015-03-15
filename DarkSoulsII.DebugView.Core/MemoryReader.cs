using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DarkSoulsII.DebugView.Core.Exceptions;

namespace DarkSoulsII.DebugView.Core
{
    public class MemoryReader : IReader, IDisposable
    {
        private readonly IntPtr _baseAddress;
        private readonly IntPtr _processHandle;

        private MemoryReader(IntPtr processHandle, IntPtr baseAddress)
        {
            _processHandle = processHandle;
            _baseAddress = baseAddress;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                NativeMethods.CloseHandle(_processHandle);
            }
        }

        public byte[] Read(int size, int address, bool relative = false)
        {
            byte[] buffer = new byte[size];
            IntPtr bytesRead;
            IntPtr absoluteAddress = GetAbsoluteAddress(address, relative);
            bool success = NativeMethods.ReadProcessMemory(_processHandle, absoluteAddress, buffer, size,
                out bytesRead);
            if (success == false)
                throw new MemoryInaccessibleException();
            return buffer;
        }

        public bool ReadBoolean(int address, bool relative = false)
        {
            byte[] data = Read(1, address, relative);
            return data[0] != 0;
        }

        public byte ReadByte(int address, bool relative = false)
        {
            byte[] data = Read(1, address, relative);
            return data[0];
        }

        public SByte ReadSByte(int address, bool relative = false)
        {
            byte[] data = Read(1, address, relative);
            return (SByte) (data[0]);
        }

        public short ReadInt16(int address, bool relative = false)
        {
            byte[] data = Read(2, address, relative);
            return (short) (data[0] | data[1] << 8);
        }

        public ushort ReadUInt16(int address, bool relative = false)
        {
            byte[] data = Read(2, address, relative);
            return (ushort) (data[0] | data[1] << 8);
        }

        public int ReadInt32(int address, bool relative = false)
        {
            byte[] data = Read(4, address, relative);
            return data[0] | data[1] << 8 | data[2] << 16 | data[3] << 24;
        }

        public int[] ReadInt32(int count, int address, bool relative = false)
        {
            byte[] data = Read(4*count, address, relative);
            int[] result = new int[count];
            int offset = 0;
            for (int i = 0; i < count; i++, offset += 4)
            {
                result[i] = data[offset] | data[offset + 1] << 8 | data[offset + 2] << 16 | data[offset + 3] << 24;
            }
            return result;
        }

        public uint ReadUInt32(int address, bool relative = false)
        {
            byte[] data = Read(4, address, relative);

            return (uint) (data[0] | data[1] << 8 | data[2] << 16 | data[3] << 24);
        }

        public long ReadInt64(int address, bool relative = false)
        {
            byte[] data = Read(8, address, relative);
            uint lowValue = (uint) (data[0] | data[1] << 8 | data[2] << 16 | data[3] << 24);
            uint highValue = (uint) (data[4] | data[5] << 8 | data[6] << 16 | data[7] << 24);
            return (long) highValue << 32 | lowValue;
        }

        public ulong ReadUInt64(int address, bool relative = false)
        {
            byte[] data = Read(8, address, relative);
            uint lowValue = (uint) (data[0] | data[1] << 8 | data[2] << 16 | data[3] << 24);
            uint highValue = (uint) (data[4] | data[5] << 8 | data[6] << 16 | data[7] << 24);
            return (ulong) highValue << 32 | lowValue;
        }

        public float ReadSingle(int address, bool relative = false)
        {
            byte[] data = Read(4, address, relative);
            return BitConverter.ToSingle(data, 0);
        }

        public float[] ReadSingle(int count, int address, bool relative = false)
        {
            byte[] data = Read(4*count, address, relative);
            float[] result = new float[count];
            int index = 0;
            for (int i = 0; i < count; i++, index += 4)
            {
                result[i] = BitConverter.ToSingle(data, index);
            }
            return result;
        }

        public double ReadDouble(int address, bool relative = false)
        {
            byte[] data = Read(8, address, relative);
            return BitConverter.ToDouble(data, 0);
        }

        public decimal ReadDecimal(int address, bool relative = false)
        {
            byte[] data = Read(16, address, relative);
            int[] bits = new int[4];
            bits[0] = data[0] | (data[1] << 8) | (data[2] << 16) | (data[3] << 24);
            bits[1] = data[4] | (data[5] << 8) | (data[6] << 16) | (data[7] << 24);
            bits[2] = data[8] | (data[9] << 8) | (data[10] << 16) | (data[11] << 24);
            bits[3] = data[12] | (data[13] << 8) | (data[14] << 16) | (data[15] << 24);
            return new decimal(bits);
        }

        public char ReadChar(int address, bool relative = false)
        {
            return ReadChar(1, Encoding.ASCII, address, relative);
        }

        public char ReadChar(int charSize, Encoding encoding, int address, bool relative = false)
        {
            byte[] data = Read(charSize, address, relative);
            return encoding.GetChars(data)[0];
        }

        public string ReadString(int length, int address, bool relative = false)
        {
            return ReadString(length, 1, Encoding.ASCII, address, relative);
        }

        public string ReadString(int length, int charSize, Encoding encoding, int address, bool relative = false)
        {
            byte[] data = Read(length*charSize, address, relative);
            return encoding.GetString(data);
        }

        public string ReadNullTerminatedString(int address, bool relative)
        {
            return ReadNullTerminatedString(Encoding.ASCII, 1, address, relative);
        }

        public string ReadNullTerminatedString(Encoding encoding, int charSize, int address, bool relative)
        {
            StringBuilder builder = new StringBuilder();
            char nextChar;
            while ((nextChar = ReadChar(charSize, encoding, address, relative)) != '\0')
            {
                builder.Append(nextChar);
                address += charSize;
            }
            return builder.ToString();
        }

        public string ReadNullTerminatedStringChunked(int address, bool relative)
        {
            return ReadNullTerminatedStringChunked(Encoding.ASCII, 1, 16, address, relative);
        }

        public string ReadNullTerminatedStringChunked(int lookaheadCharCount, int address, bool relative)
        {
            return ReadNullTerminatedStringChunked(Encoding.ASCII, 1, lookaheadCharCount, address, relative);
        }

        public string ReadNullTerminatedStringChunked(Encoding encoding, int charSize, int lookaheadCharCount,
            int address, bool relative)
        {
            if (lookaheadCharCount == 0)
                return ReadNullTerminatedString(encoding, charSize, address, relative);

            StringBuilder builder = new StringBuilder();

            int offset = 0;
            var chunkSize = lookaheadCharCount*lookaheadCharCount;
            while (true)
            {
                byte[] chunk = Read(chunkSize, address + offset, relative);
                string chunkString = (encoding ?? Encoding.ASCII).GetString(chunk);
                int terminatorIndex = chunkString.IndexOf('\0');
                if (terminatorIndex != -1)
                {
                    builder.Append(chunkString.Substring(0, terminatorIndex));
                    return builder.ToString();
                }
                builder.Append(chunkString);
                offset += chunkSize;
            }
        }

        public static MemoryReader Create(string processName)
        {
            var process = Process.GetProcessesByName(processName).FirstOrDefault();
            if (process == null)
                throw new ProcessNotFoundException();
            return Create(process);
        }

        public static MemoryReader Create(Process process)
        {
            IntPtr processHandle = NativeMethods.OpenProcess(NativeMethods.ProcessAccessFlags.VirtualMemoryRead, false,
                process.Id);
            if (processHandle == IntPtr.Zero)
                throw new ProcessAccessDeniedException();
            return new MemoryReader(processHandle, process.MainModule.BaseAddress);
        }
        
        private IntPtr GetAbsoluteAddress(int address, bool relative)
        {
            return relative ? IntPtr.Add(_baseAddress, address) : new IntPtr(address);
        }

        public T ReadStructure<T>(int address, bool relative = false) where T : struct
        {
            byte[] data = Read(Marshal.SizeOf(typeof (T)), address, relative);
            GCHandle dataHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
            T structure = (T) Marshal.PtrToStructure(dataHandle.AddrOfPinnedObject(), typeof (T));
            dataHandle.Free();
            return structure;
        }
    }
}
