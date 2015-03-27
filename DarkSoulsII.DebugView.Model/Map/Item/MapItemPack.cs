using System.Collections.Generic;
using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Core.Implementation;

namespace DarkSoulsII.DebugView.Model.Map.Item
{
    public class MapItemPack : IReadable<MapItemPack>
    {
        public MapItemPack()
        {
            Items = new List<MapItem>();
        }

        public List<MapItem> Items { get; set; }

        public MapItemPack Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {

            // BUG: Stackoverflow because the final node references the first node
            //int linkedListAddress = reader.ReadInt32(address + 0x000C, relative);
            //Items = pointerFactory
            //    .Create<StdLinkedList<MapItem>>(linkedListAddress + 0x0000, false, true)
            //    .Unbox(pointerFactory, reader)
            //    .Items;




            // TODO: Move this code to StdLinked list to avoid stackoverflows.
            Items = GenericPointer.Create(reader, address + 0x000C, relative)
                .Unbox(reader, (rootNodeReader, rootNodeAddress) =>
                {
                    List<MapItem> items = new List<MapItem>();

                    int nextNodePointer = rootNodeAddress + 0x0000;
                    int finalNodePointer = reader.ReadInt32(rootNodeAddress + 0x0004);
                    while (nextNodePointer != finalNodePointer)
                    {
                        nextNodePointer = GenericPointer.Create(rootNodeReader, nextNodePointer, false)
                            .Unbox(rootNodeReader, (nodeReader, nodeAddress) =>
                            {
                                items.Add(pointerFactory.Create<MapItem>(nodeAddress + 0x0008)
                                    .Unbox(pointerFactory, reader));
                                return nodeAddress;
                            });
                    }
                    return items;
                });
            int count = reader.ReadInt32(address + 0x0010, relative);
            return this;
        }

    }
}
