using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Map.Wind
{
    public class MapWind : IReadable<MapWind>
    {
        public MapWind Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
