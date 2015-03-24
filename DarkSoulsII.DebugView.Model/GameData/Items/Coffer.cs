using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items
{
    public class Coffer : IReadable<Coffer>, IFixedSize
    {

        public int ItemId { get; set; }

        public int IconId { get; set; }

        public byte Index { get; set; }

        public CofferType CofferType { get; set; }

        public int Size
        {
            get { return 32; }
        }

        public Coffer Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            //int previousCofferAddress = reader.ReadInt32(address + 0x0000, relative);
            //int nextCofferAddress = reader.ReadInt32(address + 0x0004, relative);
            //int unknown0 = reader.ReadInt32(address + 0x0008, relative); // Constant 0
            ItemId = reader.ReadInt32(address + 0x000C, relative);
            IconId = reader.ReadInt32(address + 0x0010, relative);
            Index = reader.ReadByte(address + 0x00014, relative);
            //byte unknown1 = reader.ReadByte(address + 0x00015, relative); // Constant 15
            CofferType = (CofferType)reader.ReadByte(address + 0x00016, relative);
            //byte unknown3 = reader.ReadByte(address + 0x00017, relative); // 2 when set else 0
            //short unknown5 = reader.ReadInt16(address + 0x0018, relative); // 1 when set else 0
            //short unknown6 = reader.ReadInt16(address + 0x001A, relative); // 3 when set else 0
            //int unknown7 = reader.ReadInt32(address + 0x001C, relative); // Constant 0

            return this;
        }

    }
}
