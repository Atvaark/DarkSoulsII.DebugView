using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class WeaponAttackMotionParam : IReadable<WeaponAttackMotionParam>
    {
        public WeaponAttackMotionParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
