using DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData
{
    public class UserItemInventoryData : IReadable<UserItemInventoryData>
    {
        public ItemInventory2BagList ItemInventory2BagList { get; set; }
        public ItemInventory2CofferList ItemInventory2CofferList { get; set; }
        public ItemInventory2ShopList ItemInventory2ShopList { get; set; }

        public UserItemInventoryData Read(IReader reader, int address, bool relative = false)
        {
            ItemInventory2BagList = Pointer<ItemInventory2BagList>.CreateAndUnbox(reader, address + 0x0008, relative);
            ItemInventory2CofferList = Pointer<ItemInventory2CofferList>.CreateAndUnbox(reader, address + 0x000C,
                relative);
            ItemInventory2ShopList = Pointer<ItemInventory2ShopList>.CreateAndUnbox(reader, address + 0x0010, relative);
            // TODO: +0014->+0008->+0000 = torch time
            return this;
        }
    }
}
