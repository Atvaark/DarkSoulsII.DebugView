using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class WeaponActionCategoryParam : IReadable<WeaponActionCategoryParam>
    {
        public WeaponActionCategoryParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
