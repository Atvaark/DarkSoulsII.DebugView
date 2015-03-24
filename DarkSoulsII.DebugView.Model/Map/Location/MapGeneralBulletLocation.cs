using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Map.Location
{
    public class MapGeneralBulletLocation : MapGeneralLocation, IReadable<MapGeneralBulletLocation>
    {
        public new MapGeneralBulletLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}