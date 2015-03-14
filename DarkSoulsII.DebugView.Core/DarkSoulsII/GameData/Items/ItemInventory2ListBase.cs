namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items
{
    public class ItemInventory2ListBase : IReadable<ItemInventory2ListBase>
    {
        public ItemInventory2ListBase Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
