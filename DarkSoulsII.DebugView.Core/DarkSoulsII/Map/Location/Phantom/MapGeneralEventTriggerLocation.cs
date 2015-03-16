namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location.Phantom
{
    public class MapGeneralEventTriggerLocation : MapGeneralPhantomLocation, IReadable<MapGeneralEventTriggerLocation>
    {
        public new MapGeneralEventTriggerLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}