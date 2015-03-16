namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location
{
    public class MapGeneralNavimeshLocation : MapGeneralLocation, IReadable<MapGeneralNavimeshLocation>
    {
        public new MapGeneralNavimeshLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}