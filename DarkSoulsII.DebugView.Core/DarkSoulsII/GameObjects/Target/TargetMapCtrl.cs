using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.Target
{
    public class TargetMapCtrl : TargetCtrl, IReadable<TargetMapCtrl>
    {
        public MapEntity MapEntity { get; set; }

        public new TargetMapCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            MapEntity = pointerFactory.Create<MapEntity>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}