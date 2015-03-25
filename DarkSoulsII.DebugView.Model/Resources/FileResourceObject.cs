﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources
{
    public class FileResourceObject : ResourceObject, IReadable<FileResourceObject>
    {
        public string Name { get; set; }

        public new FileResourceObject Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            Name = GenericPointer.Create(reader, address + 0x005C, relative).Unbox(reader,
                (r, a) => r.ReadNullTerminatedUnicodeStringChunked(16, a, false));
            return this;
        }
    }
}