using DarkSoulsII.DebugView.Core.Standard;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Sign
{
    public class BloodstainParam : IReadable<BloodstainParam>, IFixedSize
    {
        public Vector3 Position { get; set; }
        public byte AreaOwnerIndex { get; set; }
        public int Size
        {
            get { return 32; }
        }

        public BloodstainParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int flags1 = reader.ReadInt32(address + 0x0000, relative);
            Position = pointerFactory.Create<Vector3>(address + 0x0004, relative, true).Unbox(pointerFactory, reader);
            int unknown1 = reader.ReadInt32(address + 0x0010, relative);
            byte unknown2 = reader.ReadByte(address + 0x0014, relative);
            AreaOwnerIndex = reader.ReadByte(address + 0x0015, relative);
            byte unknown3 = reader.ReadByte(address + 0x0016, relative);
            byte unknown4 = reader.ReadByte(address + 0x0017, relative);
            int flags2 = reader.ReadInt32(address + 0x0018, relative);
            int unknown5 = reader.ReadInt32(address + 0x001C, relative);
            return this;
        }


    }
}