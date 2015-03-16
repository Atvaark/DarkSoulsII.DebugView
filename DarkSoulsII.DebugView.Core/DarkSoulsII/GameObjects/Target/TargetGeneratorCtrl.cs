using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.Target
{
    public class TargetGeneratorCtrl : TargetCtrl, IReadable<TargetGeneratorCtrl>
    {
        public EnemyGeneratorCtrl EnemyGeneratorCtrl { get; set; }

        public new TargetGeneratorCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            EnemyGeneratorCtrl = pointerFactory.Create<EnemyGeneratorCtrl>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}