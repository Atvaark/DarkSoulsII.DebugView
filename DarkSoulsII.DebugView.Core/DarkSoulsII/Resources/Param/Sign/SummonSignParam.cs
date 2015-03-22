using DarkSoulsII.DebugView.Core.Standard;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Sign
{
    public class SummonSignParam : IReadable<SummonSignParam>, IFixedSize
    {
        public Vector3 Position { get; set; }
        public byte GeneratorAreaIndex { get; set; }
        public int GeneratorId { get; set; }
        public int Size
        {
            get { return 120; }
        }
        public SummonSignParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int flags1 = reader.ReadInt32(address + 0000, relative);
            Position = pointerFactory.Create<Vector3>(address + 0x0004, relative, true).Unbox(pointerFactory, reader);
            int unknown1 = reader.ReadInt32(address + 0x0010, relative);
            byte unknown2 = reader.ReadByte(address + 0x0014, relative);
            byte areaIndex1 = reader.ReadByte(address + 0x0015, relative);
            byte unknown3 = reader.ReadByte(address + 0x0016, relative);
            byte unknown4 = reader.ReadByte(address + 0x0017, relative);
            int flags2 = reader.ReadInt32(address + 00018, relative);
            byte unknown5 = reader.ReadByte(address + 0x001C, relative);
            GeneratorAreaIndex = reader.ReadByte(address + 0x001D, relative);
            byte unknown6 = reader.ReadByte(address + 0x001E, relative);
            byte unknown7 = reader.ReadByte(address + 0x001F, relative);
            GeneratorId = reader.ReadInt32(address + 00020, relative);
            return this;
        }



    }
}