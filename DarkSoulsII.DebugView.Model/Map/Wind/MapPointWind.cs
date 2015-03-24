using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Standard;

namespace DarkSoulsII.DebugView.Model.Map.Wind
{
    public class MapPointWind : MapWind, IReadable<MapPointWind>
    {
        public Vector3 Position { get; set; }
        public float AliveTime { get; set; }

        public new MapPointWind Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            Position = pointerFactory.Create<Vector3>(address + 0x0020, relative, true).Unbox(pointerFactory, reader);
            AliveTime = reader.ReadSingle(address + 0x0034, relative);
            return this;
        }
    }
}
