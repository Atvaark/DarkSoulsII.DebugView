using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class ComboBehaviorParam : IReadable<ComboBehaviorParam>
    {
        public ComboBehaviorParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
