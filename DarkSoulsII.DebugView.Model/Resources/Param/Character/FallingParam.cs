using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class FallingParam : IReadable<FallingParam>
    {
        public FallingParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
