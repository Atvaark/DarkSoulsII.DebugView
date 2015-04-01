using System;
using System.IO;
using System.Text;

namespace DarkSoulsII.DebugView.Core.Implementation
{
    public class MemoryReaderStream : Stream, IReader, IDisposable
    {
        private readonly long _endPosition;
        private readonly BinaryReader _reader;
        private readonly IReadMemoryProvider _readMemoryProvider;
        private readonly long _startPosition;
        private readonly BinaryReader _unicodeReader;

        public MemoryReaderStream(IReadMemoryProvider readMemoryProvider, long startPosition, long endPosition)
        {
            _readMemoryProvider = readMemoryProvider;
            _startPosition = startPosition;
            _endPosition = endPosition;
            _reader = new BinaryReader(this, Encoding.ASCII, true);
            _unicodeReader = new BinaryReader(this, Encoding.Unicode, true);
        }

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanSeek
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override long Length
        {
            get { return _endPosition - _startPosition; }
        }

        public override long Position { get; set; }

        public new void Dispose()
        {
            _readMemoryProvider.Dispose();
            base.Dispose();
        }

        public byte[] Read(int size, int address, bool relative = false)
        {
            byte[] buffer = new byte[size];
            SetPosition(address, relative);
            _reader.Read(buffer, 0, size);
            return buffer;
        }

        public bool ReadBoolean(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadBoolean();
        }

        public byte ReadByte(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadByte();
        }

        public sbyte ReadSByte(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadSByte();
        }

        public short ReadInt16(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadInt16();
        }

        public ushort ReadUInt16(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadUInt16();
        }

        public int ReadInt32(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadInt32();
        }

        public int[] ReadInt32(int count, int address, bool relative = false)
        {
            SetPosition(address, relative);
            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = _reader.ReadInt32();
            }
            return result;
        }

        public uint ReadUInt32(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadUInt32();
        }

        public long ReadInt64(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadInt64();
        }

        public ulong ReadUInt64(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadUInt64();
        }

        public float ReadSingle(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadSingle();
        }

        public float[] ReadSingle(int count, int address, bool relative = false)
        {
            SetPosition(address, relative);
            float[] result = new float[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = _reader.ReadSingle();
            }
            return result;
        }

        public double ReadDouble(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadDouble();
        }

        public decimal ReadDecimal(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadDecimal();
        }

        public char ReadAnsiChar(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _reader.ReadChar();
        }

        public char ReadUnicodeChar(int address, bool relative = false)
        {
            SetPosition(address, relative);
            return _unicodeReader.ReadChar();
        }

        public string ReadAnsiString(int length, int address, bool relative = false)
        {
            throw new NotImplementedException();
        }

        public string ReadUnicodeString(int length, int address, bool relative = false)
        {
            throw new NotImplementedException();
        }

        public string ReadNullTerminatedAnsiString(int address, bool relative)
        {
            throw new NotImplementedException();
        }

        public string ReadNullTerminatedUnicodeString(int address, bool relative)
        {
            throw new NotImplementedException();
        }

        public string ReadNullTerminatedAnsiStringChunked(int lookaheadCharCount, int address, bool relative)
        {
            throw new NotImplementedException();
        }

        public string ReadNullTerminatedUnicodeStringChunked(int lookaheadCharCount, int address, bool relative)
        {
            throw new NotImplementedException();
        }

        public override void Flush()
        {
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            // TODO: Set start and end position
            switch (origin)
            {
                case SeekOrigin.Begin:
                    Position = _startPosition + offset;
                    break;
                case SeekOrigin.Current:
                    Position += offset;
                    break;
                case SeekOrigin.End:
                    Position = _endPosition + offset;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("origin");
            }
            return Position;
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            byte[] readBuffer = _readMemoryProvider.Read(count, (int) Position, false);
            Buffer.BlockCopy(readBuffer, 0, buffer, offset, count);
            return count;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }

        private void SetPosition(int address, bool relative)
        {
            Position = relative ? _startPosition + address : address;
        }
    }
}
