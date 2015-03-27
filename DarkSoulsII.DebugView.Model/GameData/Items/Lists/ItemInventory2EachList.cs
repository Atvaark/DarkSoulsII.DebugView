using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Standard;

namespace DarkSoulsII.DebugView.Model.GameData.Items.Lists
{
    public class ItemInventory2EachList<T> : IReadable<ItemInventory2EachList<T>> where T : class, IReadable<T>, new()
    {
        public StdLinkedList<T> List { get; set; }
        public short MaxCount { get; set; }
        public short Count { get; set; }

        public ItemInventory2EachList<T> Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            List = pointerFactory.Create<StdLinkedList<T>>(address + 0x0008, relative, true).Unbox(pointerFactory, reader);
            MaxCount = reader.ReadInt16(address + 0x0018, relative);
            Count = reader.ReadInt16(address + 0x001A, relative);
            return this;
        }

    }
}