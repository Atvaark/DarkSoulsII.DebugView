namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location
{
    public class MapGeneralBloodMsgDisableLocation : MapGeneralLocation, IReadable<MapGeneralBloodMsgDisableLocation>
    {
        public new MapGeneralBloodMsgDisableLocation Read(IPointerFactory pointerFactory, IReader reader, int address,
            bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}