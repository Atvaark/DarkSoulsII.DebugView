namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items
{
    public class ItemInventory2ShopList : ItemInventory2ListBase, IReadable<ItemInventory2ShopList>
    {
        public ItemInventory2ShopList Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
