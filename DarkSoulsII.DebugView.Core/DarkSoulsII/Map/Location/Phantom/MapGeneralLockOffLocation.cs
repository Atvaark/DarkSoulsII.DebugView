namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location.Phantom
{
    public class MapGeneralLockOffLocation : MapGeneralPhantomLocation, IReadable<MapGeneralLockOffLocation>
    {
        public new MapGeneralLockOffLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}