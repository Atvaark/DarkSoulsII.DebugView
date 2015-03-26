using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Standard
{
    public class LinkedListNode<T> : IReadable<LinkedListNode<T>> where T : class, IReadable<T>, new()
    {
        public LinkedListNode<T> Next { get; set; }
        public T Item { get; set; }

        public LinkedListNode<T> Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            //Previous = pointerFactory.Create<LinkedListEntry<T>>(address + 0x0000, relative).Unbox(pointerFactory, reader);
            Next = pointerFactory.Create<LinkedListNode<T>>(address + 0x0004, relative).Unbox(pointerFactory, reader);
            Item = pointerFactory.Create<T>(address + 0x0008, relative, true).Unbox(pointerFactory, reader);
            return this;
        }

    }
}