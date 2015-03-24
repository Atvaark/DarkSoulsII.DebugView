using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Map
{
    public class MapWorldList : IReadable<MapWorldList>
    {
        public List<int> WorldIdList { get; set; }

        public MapWorldList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int worldCount = reader.ReadInt32(address + 0x000C, relative);
            int worldAddess = reader.ReadInt32(address + 0x0010, relative);
            WorldIdList = reader.ReadInt32(worldCount, worldAddess).ToList();
            return this;
        }

    }
}
