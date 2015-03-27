using System;

namespace DarkSoulsII.DebugView.Core.Implementation
{
    public class ReadBufferedMemoryProvider : IReadMemoryProvider
    {
        private readonly byte[] _buffer;
        private readonly int _baseAddress;

        public ReadBufferedMemoryProvider(byte[] buffer, int baseAddress)
        {
            _buffer = buffer;
            _baseAddress = baseAddress;
        }

        public void Dispose()
        {

        }

        private int GetAbsoluteAddress(int address, bool relative)
        {
            return relative ? _baseAddress + address : address;
        }

        public byte[] Read(int size, int address, bool relative)
        {
            byte[] result = new byte[size];
            Buffer.BlockCopy(_buffer, GetAbsoluteAddress(address, relative), result, 0, size);
            return result;
        }
    }
}