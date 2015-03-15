namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items
{
    public class Shop : IReadable<Shop>, IFixedSize
    {
        public int ShopLineupId { get; set; }
        public int ItemId { get; set; }
        public int IconId { get; set; }
        public int SoulCost { get; set; }
        public byte Index { get; set; }
        public ItemType ItemType { get; set; }
        /// <summary>
        /// -1 hides the stack count
        /// </summary>
        public byte StackSize { get; set; }
        public int Size
        {
            get { return 28; }
        }

        public Shop Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ShopLineupId = reader.ReadInt32(address + 0x0008, relative);
            ItemId = reader.ReadInt32(address + 0x000C, relative);
            IconId = reader.ReadInt32(address + 0x0010, relative);
            SoulCost = reader.ReadInt32(address + 0x0014, relative);
            Index = reader.ReadByte(address + 0x0018, relative);
            //byte unknown0 = reader.ReadByte(address + 0x0019, relative); // Constant 16
            ItemType = (ItemType)reader.ReadByte(address + 0x001A, relative);
            StackSize = reader.ReadByte(address + 0x001B, relative);
            return this;
        }

    }
}