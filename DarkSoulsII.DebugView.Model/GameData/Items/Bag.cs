using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items
{
    public class Bag : IReadable<Bag>, IFixedSize
    {
        public int ItemId { get; set; }
        public int IconId { get; set; }
        public short Index { get; set; }
        public ItemType ItemType { get; set; }
        public BagFlags ItemFlags { get; set; }

        public float Durability { get; set; }
        public byte DurabilityPercentage { get; set; }

        public short Amount { get; set; }
        public ItemDisplayFlags DisplayFlags { get; set; }

        public byte ReinforceCount { get; set; }
        public Infusion Infusion { get; set; }

        public int Size
        {
            get { return 32; }
        }

        public Bag Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Create a Vector class
            //int previousBagAddress = reader.ReadInt32(address + 0x0000, relative);
            //int nextBagAddress = reader.ReadInt32(address + 0x0004, relative);

            //int unknown0 = reader.ReadInt32(address + 0x0008, relative); // 0 or 1
            ItemId = reader.ReadInt32(address + 0x000C, relative);
            IconId = reader.ReadInt32(address + 0x0010, relative);
            Index = reader.ReadInt16(address + 0x0014, relative);
            ItemType = (ItemType)reader.ReadByte(address + 0x0016, relative);
            ItemFlags = (BagFlags)reader.ReadByte(address + 0x0017, relative);

            switch (ItemType)
            {
                case ItemType.Weapon:
                case ItemType.Shield:
                case ItemType.Head:
                case ItemType.Body:
                case ItemType.Hand:
                case ItemType.Legs:
                case ItemType.Ring:
                    Durability = reader.ReadSingle(address + 0x0018, relative);
                    DurabilityPercentage = reader.ReadByte(address + 0x001C, relative);
                    ReinforceCount = reader.ReadByte(address + 0x001D, relative);
                    Infusion = (Infusion)reader.ReadByte(address + 0x001E, relative);
                    byte unknown1 = reader.ReadByte(address + 0x001E, relative);
                    byte unknown2 = reader.ReadByte(address + 0x001F, relative);
                    break;
                case ItemType.Ammo:
                case ItemType.Consumable:
                case ItemType.Spell:
                    Amount = reader.ReadInt16(address + 0x0018, relative);
                    DisplayFlags = (ItemDisplayFlags)reader.ReadByte(address + 0x001A, relative);
                    byte unknown3 = reader.ReadByte(address + 0x001E, relative);
                    byte unknown4 = reader.ReadByte(address + 0x001F, relative);
                    break;
            }


            return this;
        }

    }
}
