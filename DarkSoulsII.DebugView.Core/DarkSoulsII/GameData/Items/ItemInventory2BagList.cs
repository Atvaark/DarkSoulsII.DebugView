namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items
{
    public class ItemInventory2BagList : ItemInventory2ListBase, IReadable<ItemInventory2BagList>
    {
        public new ItemInventory2BagList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
