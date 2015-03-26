using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items.Lists
{
    public class ItemInventory2NormalList : ItemInventory2EachList<Normal>, IReadable<ItemInventory2NormalList>
    {
        public new ItemInventory2NormalList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}