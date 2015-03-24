using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Model
{
    public class MdlBone : IReadable<MdlBone>, IFixedSize
    {
        public string Name { get; set; }

        public int Size
        {
            get { return 12; }
        }

        public MdlBone Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            short unknown1 = reader.ReadInt16(address + 0x0000, relative);
            short unknown2 = reader.ReadInt16(address + 0x0002, relative);
            short unknown3 = reader.ReadInt16(address + 0x0004, relative);
            short unknown4 = reader.ReadInt16(address + 0x0006, relative);
            int nameAddress = reader.ReadInt32(address + 0x0008, relative);
            Name = reader.ReadNullTerminatedUnicodeStringChunked(16, nameAddress, false);

            return this;
        }

    }
}