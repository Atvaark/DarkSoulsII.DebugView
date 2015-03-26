using System.Collections.Generic;
using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Standard
{
    public class LinkedList<T> : IReadable<LinkedList<T>> where T : class, IReadable<T>, new()
    {
        public LinkedList()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }
        
        public LinkedList<T> Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Stackoverflow possible?
            LinkedListNode<T> startNode = pointerFactory.Create<LinkedListNode<T>>(address + 0x0000, relative).Unbox(pointerFactory, reader);
            //var endNode = pointerFactory.Create<LinkedListNode<T>>(address + 0x0004, relative).Unbox(pointerFactory, reader);

            LinkedListNode<T> currentNode = startNode;
            while (currentNode != null)
            {
                Items.Add(currentNode.Item);
                currentNode = currentNode.Next;
            }
            return this;
        }
    }
}