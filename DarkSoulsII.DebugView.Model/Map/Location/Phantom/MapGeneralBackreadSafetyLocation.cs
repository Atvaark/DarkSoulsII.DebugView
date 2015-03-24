using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Map.Location.Phantom
{
    public class MapGeneralBackreadSafetyLocation : MapGeneralPhantomLocation, IReadable<MapGeneralBackreadSafetyLocation>
    {
        public new MapGeneralBackreadSafetyLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}