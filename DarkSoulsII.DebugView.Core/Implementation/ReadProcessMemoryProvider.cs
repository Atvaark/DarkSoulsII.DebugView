using System;
using System.Diagnostics;
using DarkSoulsII.DebugView.Core.Exceptions;

namespace DarkSoulsII.DebugView.Core.Implementation
{
    public class ReadProcessMemoryProvider : IReadMemoryProvider
    {
        private readonly IntPtr _processHandle;
        private readonly IntPtr _baseAddress;

        public ReadProcessMemoryProvider(Process process)
        {
            _baseAddress = process.MainModule.BaseAddress;
            _processHandle = NativeMethods.OpenProcess(NativeMethods.ProcessAccessFlags.VirtualMemoryRead, false, process.Id);
            if (_processHandle == IntPtr.Zero)
                throw new ProcessAccessDeniedException();
        }

        private IntPtr GetAbsoluteAddress(int address, bool relative)
        {
            return relative ? IntPtr.Add(_baseAddress, address) : new IntPtr(address);
        }

        public byte[] Read(int size, int address, bool relative)
        {

            byte[] buffer = new byte[size];
            IntPtr bytesRead;
            IntPtr absoluteAddress = GetAbsoluteAddress(address, relative);
            bool success = NativeMethods.ReadProcessMemory(_processHandle, absoluteAddress, buffer, size, out bytesRead);
            if (success == false)
                throw new MemoryInaccessibleException();
            return buffer;
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
    }
}