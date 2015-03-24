using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Map.Wind
{
    public class MapModelWindReactor : IReadable<MapModelWindReactor>
    {
        public MapModelWindReactor Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
