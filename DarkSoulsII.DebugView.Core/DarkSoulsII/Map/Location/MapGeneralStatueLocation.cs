namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location
{
    public class MapGeneralStatueLocation : MapGeneralLocation, IReadable<MapGeneralStatueLocation>
    {
        public new MapGeneralStatueLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}