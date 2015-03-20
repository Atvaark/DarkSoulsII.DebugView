using System;
using System.Text;

namespace DarkSoulsII.DebugView.Core
{
    public class MemoryReader : IReader
    {
        // TODO: Handle baseAddress and relative parameters
        private readonly int _baseAddress;
        private readonly byte[] _data;

        public MemoryReader(byte[] data, int baseAddress)
        {
            _baseAddress = baseAddress;
            _data = data;
        }

        public byte[] Read(int size, int address, bool relative = false)
        {
            byte[] result = new byte[size];
            Buffer.BlockCopy(_data, address, result, 0, size);
            return result;
        }

        public bool ReadBoolean(int address, bool relative = false)
        {
            return BitConverter.ToBoolean(_data, address);
        }

        public byte ReadByte(int address, bool relative = false)
        {
            return _data[address];
        }

        public sbyte ReadSByte(int address, bool relative = false)
        {
            return (sbyte) _data[address];
        }

        public short ReadInt16(int address, bool relative = false)
        {
            return BitConverter.ToInt16(_data, address);
        }

        public ushort ReadUInt16(int address, bool relative = false)
        {
            return BitConverter.ToUInt16(_data, address);
        }

        public int ReadInt32(int address, bool relative = false)
        {
            return BitConverter.ToInt32(_data, address);
        }

        public int[] ReadInt32(int count, int address, bool relative = false)
        {
            int[] result = new int[count];
            int offset = 0;
            for (int i = 0; i < count; i++, offset+=sizeof(int))
            {
                result[i] = BitConverter.ToInt32(_data, address + offset);
            }
            return result;
        }

        public uint ReadUInt32(int address, bool relative = false)
        {
            return BitConverter.ToUInt32(_data, address);
        }

        public long ReadInt64(int address, bool relative = false)
        {
            return BitConverter.ToInt64(_data, address);
        }

        public ulong ReadUInt64(int address, bool relative = false)
        {
            return BitConverter.ToUInt64(_data, address);
        }

        public float ReadSingle(int address, bool relative = false)
        {
            return BitConverter.ToSingle(_data, address);
        }

        public float[] ReadSingle(int count, int address, bool relative = false)
        {
            float[] result = new float[count];
            int offset = 0;
            for (int i = 0; i < count; i++, offset += sizeof(float))
            {
                result[i] = BitConverter.ToSingle(_data, address + offset);
            }
            return result;
        }

        public double ReadDouble(int address, bool relative = false)
        {
            return BitConverter.ToDouble(_data, address);
        }

        public decimal ReadDecimal(int address, bool relative = false)
        {
            int bits1 = BitConverter.ToInt32(_data, address);
            int bits2 = BitConverter.ToInt32(_data, address + 4);
            int bits3 = BitConverter.ToInt32(_data, address + 8);
            int bits4 = BitConverter.ToInt32(_data, address + 12);
            return new decimal(new[] { bits1, bits2, bits3, bits4 });
        }

        public char ReadAnsiChar(int address, bool relative = false)
        {
            return (char) _data[address];
        }

        public char ReadUnicodeChar(int address, bool relative = false)
        {
            return Encoding.Unicode.GetChars(_data, address, 1)[0];
        }

        public string ReadAnsiString(int length, int address, bool relative = false)
        {
            return Encoding.ASCII.GetString(_data, address, length);
        }

        public string ReadUnicodeString(int length, int address, bool relative = false)
        {
            return Encoding.Unicode.GetString(_data, address, length);
        }

        public string ReadNullTerminatedAnsiString(int address, bool relative)
        {
            int index = Array.FindIndex(_data, address, b => b == 0);
            if (index == -1)
                index = _data.Length - address;
            return Encoding.ASCII.GetString(_data, address, index);
        }

        public string ReadNullTerminatedUnicodeString(int address, bool relative)
        {
            int startIndex = Array.FindIndex(_data, address, b => b == 0);
            while (startIndex >= 0)
            {
                int nextIndex = Array.FindIndex(_data, startIndex + 1, b => b == 0);
                if (nextIndex == -1)
                {
                    break;
                }
                if (startIndex + 1 == nextIndex)
                {
                    if (startIndex == address)
                        return "";
                    return Encoding.Unicode.GetString(_data, address, startIndex - address - 1);
                }
                startIndex = nextIndex;
            }
            startIndex = _data.Length - address;
            return Encoding.Unicode.GetString(_data, address, startIndex);

        }

        public string ReadNullTerminatedAnsiStringChunked(int lookaheadCharCount, int address, bool relative)
        {
            if (lookaheadCharCount == 0)
                return ReadNullTerminatedAnsiString(address, relative);

            StringBuilder builder = new StringBuilder();
            int offset = 0;
            int chunkSize = lookaheadCharCount;
            while (true)
            {
                byte[] chunk = Read(chunkSize, address + offset, relative);
                string chunkString = Encoding.ASCII.GetString(chunk);
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

        public string ReadNullTerminatedUnicodeStringChunked(int lookaheadCharCount, int address, bool relative)
        {
            if (lookaheadCharCount == 0)
                return ReadNullTerminatedUnicodeString(address, relative);

            StringBuilder builder = new StringBuilder();
            int offset = 0;
            int chunkSize = lookaheadCharCount * 2;
            while (true)
            {
                byte[] chunk = Read(chunkSize, address + offset, relative);
                string chunkString = Encoding.Unicode.GetString(chunk);
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
    }
}