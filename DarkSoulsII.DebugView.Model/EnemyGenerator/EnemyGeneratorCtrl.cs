using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Standard;

namespace DarkSoulsII.DebugView.Model.EnemyGenerator
{
    public class EnemyGeneratorCtrl : IReadable<EnemyGeneratorCtrl>
    {
        public Vector3 Position { get; set; }

        public EnemyGeneratorCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Position = pointerFactory.Create<Vector3>(address + 0x0010, relative, true).Unbox(pointerFactory, reader);

            // 0048 TargetGeneratorCtrl
            return this;
        }

    }
}