using System.Collections.Generic;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Item
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
            // TODO: Is this an StdVector or a Std(Linked-)List?
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
