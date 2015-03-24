using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class WeaponStatsAffectParam : IReadable<WeaponStatsAffectParam>
    {
        public WeaponStatsAffectParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
