using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class RelatePhysStatToLevelStat : IReadable<RelatePhysStatToLevelStat>
    {
        public RelatePhysStatToLevelStat Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
