using DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData
{
    public class UserItemInventoryData : IReadable<UserItemInventoryData>
    {
        public ItemInventory2BagList ItemInventory2BagList { get; set; }
        public ItemInventory2CofferList ItemInventory2CofferList { get; set; }
        public ItemInventory2ShopList ItemInventory2ShopList { get; set; }

        public UserItemInventoryData Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ItemInventory2BagList = pointerFactory.Create<ItemInventory2BagList>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            ItemInventory2CofferList = pointerFactory.Create<ItemInventory2CofferList>(address + 0x000C, relative).Unbox(pointerFactory, reader);
            ItemInventory2ShopList = pointerFactory.Create<ItemInventory2ShopList>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            // TODO: +0014->+0008->+0000 = torch time
            return this;
        }
    }
}
