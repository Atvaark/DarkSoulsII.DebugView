namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location.Phantom
{
    public class MapGeneralPhantomLocation : MapGeneralLocation, IReadable<MapGeneralPhantomLocation>
    {
        public new MapGeneralPhantomLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}