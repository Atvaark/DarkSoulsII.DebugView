namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location.Phantom
{
    public class MapGeneralLogicNoEntryLocation : MapGeneralPhantomLocation, IReadable<MapGeneralLogicNoEntryLocation>
    {
        public new MapGeneralLogicNoEntryLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}