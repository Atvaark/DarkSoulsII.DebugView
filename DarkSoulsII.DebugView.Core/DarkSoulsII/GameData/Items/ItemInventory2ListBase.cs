namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items
{
    public class ItemInventory2ListBase : IReadable<ItemInventory2ListBase>
    {
        public ItemInventory2ListBase Read(IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
