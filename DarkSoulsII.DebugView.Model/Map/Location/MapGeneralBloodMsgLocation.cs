using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Map.Location
{
    public class MapGeneralBloodMsgLocation : MapGeneralLocation, IReadable<MapGeneralBloodMsgLocation>
    {
        public new MapGeneralBloodMsgLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}