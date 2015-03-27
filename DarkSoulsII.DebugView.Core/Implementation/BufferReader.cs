using System;
using System.Text;

namespace DarkSoulsII.DebugView.Core.Implementation
{
    public class BufferReader : IReader
    {
        private readonly int _baseAddress;
        private readonly byte[] _buffer;

        public BufferReader(byte[] buffer, int baseAddress)
        {
            if (buffer == null) throw new ArgumentNullException("buffer");
            _baseAddress = baseAddress;
            _buffer = buffer;
        }

        private int GetAbsoluteAddress(int address, bool relative)
        {
            return relative ? _baseAddress + address : address;
        }

        public byte[] Read(int size, int address, bool relative = false)
        {
            byte[] result = new byte[size];
            Buffer.BlockCopy(_buffer, GetAbsoluteAddress(address, relative), result, 0, size);
            return result;
        }

        public bool ReadBoolean(int address, bool relative = false)
        {
            return BitConverter.ToBoolean(_buffer, address);
        }

        public byte ReadByte(int address, bool relative = false)
        {
            return _buffer[address];
        }

        public sbyte ReadSByte(int address, bool relative = false)
        {
            return (sbyte) _buffer[address];
        }

        public short ReadInt16(int address, bool relative = false)
        {
            return BitConverter.ToInt16(_buffer, address);
        }

        public ushort ReadUInt16(int address, bool relative = false)
        {
            return BitConverter.ToUInt16(_buffer, address);
        }

        public int ReadInt32(int address, bool relative = false)
        {
            return BitConverter.ToInt32(_buffer, address);
        }

        public int[] ReadInt32(int count, int address, bool relative = false)
        {
            int[] result = new int[count];
            int offset = 0;
            for (int i = 0; i < count; i++, offset+=sizeof(int))
            {
                result[i] = BitConverter.ToInt32(_buffer, address + offset);
            }
            return result;
        }

        public uint ReadUInt32(int address, bool relative = false)
        {
            return BitConverter.ToUInt32(_buffer, address);
        }

        public long ReadInt64(int address, bool relative = false)
        {
            return BitConverter.ToInt64(_buffer, address);
        }

        public ulong ReadUInt64(int address, bool relative = false)
        {
            return BitConverter.ToUInt64(_buffer, address);
        }

        public float ReadSingle(int address, bool relative = false)
        {
            return BitConverter.ToSingle(_buffer, address);
        }

        public float[] ReadSingle(int count, int address, bool relative = false)
        {
            float[] result = new float[count];
            int offset = 0;
            for (int i = 0; i < count; i++, offset += sizeof(float))
            {
                result[i] = BitConverter.ToSingle(_buffer, address + offset);
            }
            return result;
        }

        public double ReadDouble(int address, bool relative = false)
        {
            return BitConverter.ToDouble(_buffer, address);
        }

        public decimal ReadDecimal(int address, bool relative = false)
        {
            int bits1 = BitConverter.ToInt32(_buffer, address);
            int bits2 = BitConverter.ToInt32(_buffer, address + 4);
            int bits3 = BitConverter.ToInt32(_buffer, address + 8);
            int bits4 = BitConverter.ToInt32(_buffer, address + 12);
            return new decimal(new[] { bits1, bits2, bits3, bits4 });
        }

        public char ReadAnsiChar(int address, bool relative = false)
        {
            return (char) _buffer[address];
        }

        public char ReadUnicodeChar(int address, bool relative = false)
        {
            return Encoding.Unicode.GetChars(_buffer, address, 2)[0];
        }

        public string ReadAnsiString(int length, int address, bool relative = false)
        {
            return Encoding.ASCII.GetString(_buffer, address, length);
        }

        public string ReadUnicodeString(int length, int address, bool relative = false)
        {
            return Encoding.Unicode.GetString(_buffer, address, length*2);
        }

        public string ReadNullTerminatedAnsiString(int address, bool relative)
        {
            int index = Array.FindIndex(_buffer, address, b => b == 0);

            if (index == -1)
                index = _buffer.Length - address;
            return Encoding.ASCII.GetString(_buffer, address, index - address);
        }

        public string ReadNullTerminatedUnicodeString(int address, bool relative)
        {
            int startIndex = Array.FindIndex(_buffer, address, b => b == 0);
            while (startIndex >= 0)
            {
                int nextIndex = Array.FindIndex(_buffer, startIndex + 1, b => b == 0);
                if (nextIndex == -1)
                {
                    break;
                }
                if (startIndex % 2 == 0 && startIndex + 1 == nextIndex)
                {
                    if (startIndex == address)
                        return "";
                    return Encoding.Unicode.GetString(_buffer, address, startIndex - address); // -1?
                }
                startIndex = nextIndex;
            }
            startIndex = _buffer.Length - address;
            return Encoding.Unicode.GetString(_buffer, address, startIndex);

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