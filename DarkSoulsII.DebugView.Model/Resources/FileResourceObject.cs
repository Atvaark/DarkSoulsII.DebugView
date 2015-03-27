using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources
{
    public class FileResourceObject : ResourceObject, IReadable<FileResourceObject>
    {
        public string Name { get; set; }

        public new FileResourceObject Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            int nameAddress = reader.ReadInt32(address + 0x005C, relative);
            Name = reader.ReadNullTerminatedUnicodeStringChunked(16, nameAddress, false); // TODO: Test
            return this;
        }
    }
}
