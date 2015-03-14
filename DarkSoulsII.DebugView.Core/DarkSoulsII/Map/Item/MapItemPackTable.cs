using System.Collections.Generic;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Item
{
    public class MapItemPackTable : IReadable<MapItemPackTable>
    {
        public MapItemPackTable()
        {
            Table = new Dictionary<MapItemListType, MapItemPack>();
        }

        public Dictionary<MapItemListType, MapItemPack> Table { get; set; }

        public MapItemPackTable Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int mapItemListAddress = address;
            for (int i = 0; i < 4; i++, mapItemListAddress += Pointer<MapItemPack>.Size)
            {
                var mapItemList = pointerFactory.Create<MapItemPack>(mapItemListAddress, relative).Unbox(pointerFactory, reader);

                Table.Add((MapItemListType) i, mapItemList);
            }

            return this;
        }
    }
}
