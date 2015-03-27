using System;

namespace DarkSoulsII.DebugView.Core
{
    public interface IReadMemoryProvider : IDisposable
    {
        byte[] Read(int size, int address, bool relative);
    }
}