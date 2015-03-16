namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location
{
    public class MapGeneralIntrudeLocation : MapGeneralLocation, IReadable<MapGeneralIntrudeLocation>
    {
        public new MapGeneralIntrudeLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}