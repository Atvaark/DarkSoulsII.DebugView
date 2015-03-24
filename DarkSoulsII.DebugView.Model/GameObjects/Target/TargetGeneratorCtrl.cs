using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.GameObjects.GameEntities;

namespace DarkSoulsII.DebugView.Model.GameObjects.Target
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