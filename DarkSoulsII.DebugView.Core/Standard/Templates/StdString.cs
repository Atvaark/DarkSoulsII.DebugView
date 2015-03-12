﻿using System.Text;

namespace DarkSoulsII.DebugView.Core.Standard.Templates
{
    public class StdString : IReadable<StdString>
    {
        public string Value { get; set; }

        public StdString Read(IReader reader, int address, bool relative = false)
        {
            int length = reader.ReadInt32(address + 0x0010);
            int stringAddress = length >= 8 ? reader.ReadInt32(address) : address;
            Value = reader.ReadString(length, 2, Encoding.Unicode, stringAddress);
            return this;
        }
    }
}