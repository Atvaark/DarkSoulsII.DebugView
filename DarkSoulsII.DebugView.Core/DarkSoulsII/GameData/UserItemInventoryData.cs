using DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items.Lists;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData
{
    public class UserItemInventoryData : IReadable<UserItemInventoryData>
    {
        public ItemInventory2BagList ItemInventory2BagList { get; set; }
        public ItemInventory2CofferList ItemInventory2CofferList { get; set; }
        public ItemInventory2ShopList ItemInventory2ShopList { get; set; }
        public ItemInventory2MiscellaneousList ItemInventory2MiscellaneousList { get; set; }

        public UserItemInventoryData Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ItemInventory2BagList = pointerFactory.Create<ItemInventory2BagList>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            ItemInventory2CofferList = pointerFactory.Create<ItemInventory2CofferList>(address + 0x000C, relative).Unbox(pointerFactory, reader);
            ItemInventory2ShopList = pointerFactory.Create<ItemInventory2ShopList>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            ItemInventory2MiscellaneousList = pointerFactory.Create<ItemInventory2MiscellaneousList>(address + 0x0014, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
