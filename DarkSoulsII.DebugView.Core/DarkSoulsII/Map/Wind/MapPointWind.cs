using DarkSoulsII.DebugView.Core.Standard;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Wind
{
    public class MapPointWind : MapWind, IReadable<MapPointWind>
    {
        public Vector3 Position { get; set; }
        public float AliveTime { get; set; }

        public new MapPointWind Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            Position = Pointer<Vector3>.Create(address + 0x0020, relative).Unbox(reader);
            AliveTime = reader.ReadSingle(address + 0x0034, relative);
            return this;
        }
    }
}
