namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items
{
    public class ItemInventory2CofferList : ItemInventory2ListBase, IReadable<ItemInventory2CofferList>
    {
        public ItemInventory2CofferList Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
