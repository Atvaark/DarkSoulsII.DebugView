using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Standard;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Sign
{
    public class BloodMessageParam : IReadable<BloodMessageParam>, IFixedSize
    {
        public Vector3 Position { get; set; }
        public int Size
        {
            get { return 48; }
        }

        public BloodMessageParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int flags1 = reader.ReadInt32(address + 0x0000, relative);
            Position = pointerFactory.Create<Vector3>(address + 0x0004, relative, true).Unbox(pointerFactory, reader);
            int unknown1 = reader.ReadInt32(address + 0x0010, relative);
            int unknown2 = reader.ReadInt32(address + 0x0014, relative);
            int flags2 = reader.ReadInt32(address + 0x0018, relative);
            int unknown3 = reader.ReadInt32(address + 0x001C, relative);
            return this;
        }



    }
}