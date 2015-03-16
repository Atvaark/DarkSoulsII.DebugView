namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location.Phantom
{
    public class MapGeneralSlideLocation : MapGeneralPhantomLocation, IReadable<MapGeneralSlideLocation>
    {
        public new MapGeneralSlideLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}