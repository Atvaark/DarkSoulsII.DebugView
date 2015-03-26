using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items.Lists
{
    public class ItemInventory2SpellList : ItemInventory2EachList<Spell>, IReadable<ItemInventory2SpellList>
    {
        public new ItemInventory2SpellList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}