using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class WeaponStaminaCostParam : IReadable<WeaponStaminaCostParam>
    {
        public WeaponStaminaCostParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
