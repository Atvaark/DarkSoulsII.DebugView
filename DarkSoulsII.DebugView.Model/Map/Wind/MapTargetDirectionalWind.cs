using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Map.Wind
{
    public class MapTargetDirectionalWind : MapWind, IReadable<MapTargetDirectionalWind>
    {
        public new MapTargetDirectionalWind Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
