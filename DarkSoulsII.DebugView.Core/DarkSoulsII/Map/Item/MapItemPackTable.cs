using System.Collections.Generic;
using System.Linq;

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
            Table = pointerFactory
                .CreateArray<MapItemPack>(address, relative, 4)
                .Select((p, i) => new
                {
                    Type = (MapItemListType) i,
                    List = p.Unbox(pointerFactory, reader)
                })
                .ToDictionary(pair => pair.Type, pair => pair.List);
            return this;
        }
    }
}
