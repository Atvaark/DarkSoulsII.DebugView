using System.Collections.Generic;
using System.Linq;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Area
{
    public class MapChameleonArea : IReadable<MapChameleonArea>
    {
        public MapChameleonArea()
        {
            ChameleonAreaDataList = new List<MapChameleonAreaData>();
        }

        public List<MapChameleonAreaData> ChameleonAreaDataList { get; set; }

        public MapChameleonArea Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Validate if there are areas with a count other than 3
            int chameleonDataCount = reader.ReadInt32(address + 0x0064, relative);
            // 000C AreaParamEntry
            ChameleonAreaDataList = pointerFactory
                .CreateArrayDereferenced<MapChameleonAreaData>(address + 0x0010, relative, chameleonDataCount)
                .Select(p => p.Unbox(pointerFactory, reader)).ToList();
            return this;
        }
    }
}
