using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items.Lists
{
    /// <summary>
    /// Also known as the ItemBox.
    /// </summary>
    public class ItemInventory2RepositoryList : ItemInventory2EachList<Repository>, IReadable<ItemInventory2RepositoryList>
    {
        public new ItemInventory2RepositoryList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}