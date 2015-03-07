namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Wind
{
    public class MapTargetDirectionalWind : MapWind, IReadable<MapTargetDirectionalWind>
    {
        public new MapTargetDirectionalWind Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
