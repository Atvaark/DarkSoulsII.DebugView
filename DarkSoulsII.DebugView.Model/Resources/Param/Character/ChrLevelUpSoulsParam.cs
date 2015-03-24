using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class ChrLevelUpSoulsParam : IReadable<ChrLevelUpSoulsParam>
    {
        public ChrLevelUpSoulsParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
