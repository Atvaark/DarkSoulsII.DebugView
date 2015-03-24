using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Map.Wind;

namespace DarkSoulsII.DebugView.Model.Managers.Map
{
    public class MapWindManager : IReadable<MapWindManager>
    {
        public MapPointWind PointWind { get; set; }
        public MapTargetDirectionalWind TargetDirectionalWind { get; set; }
        public MapModelWindReactor ModelWindReactor { get; set; }

        public MapWindManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            PointWind = pointerFactory.Create<MapPointWind>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            TargetDirectionalWind = pointerFactory.Create<MapTargetDirectionalWind>(address + 0x000C, relative).Unbox(pointerFactory, reader);
            ModelWindReactor = pointerFactory.Create<MapModelWindReactor>(address + 0x000C, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
