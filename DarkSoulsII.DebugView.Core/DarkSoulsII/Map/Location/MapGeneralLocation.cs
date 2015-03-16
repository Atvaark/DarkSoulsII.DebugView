using DarkSoulsII.DebugView.Core.Standard;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location
{
    public class MapGeneralLocation : IReadable<MapGeneralLocation>
    {
        public Matrix4 Matrix { get; set; }

        public MapGeneralLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Matrix = pointerFactory.Create<Matrix4>(address + 0x0010, relative, true).Unbox(pointerFactory, reader);
            int unknown = reader.ReadInt32(address + 0x0050, relative);
            // 0058  TargetMapGeneralLocationCtrl
            return this;
        }

    }
}