using DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Wind;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapWindManager : IReadable<MapWindManager>
    {
        public MapPointWind PointWind { get; set; }
        public MapTargetDirectionalWind TargetDirectionalWind { get; set; }
        public MapModelWindReactor ModelWindReactor { get; set; }

        public MapWindManager Read(IReader reader, int address, bool relative = false)
        {
            PointWind = Pointer<MapPointWind>.CreateAndUnbox(reader, address + 0x0008, relative);
            TargetDirectionalWind = Pointer<MapTargetDirectionalWind>.CreateAndUnbox(reader, address + 0x000C, relative);
            ModelWindReactor = Pointer<MapModelWindReactor>.CreateAndUnbox(reader, address + 0x000C, relative);
            return this;
        }
    }
}
