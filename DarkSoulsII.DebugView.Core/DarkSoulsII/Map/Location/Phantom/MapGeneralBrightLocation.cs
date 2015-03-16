namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location.Phantom
{
    public class MapGeneralBrightLocation : MapGeneralPhantomLocation, IReadable<MapGeneralBrightLocation>
    {
        public new MapGeneralBrightLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}