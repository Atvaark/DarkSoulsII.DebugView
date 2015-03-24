using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class EnemyAttackMoveParam : IReadable<EnemyAttackMoveParam>
    {
        public EnemyAttackMoveParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
