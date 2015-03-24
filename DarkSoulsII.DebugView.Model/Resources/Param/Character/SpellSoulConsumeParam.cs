using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class SpellSoulConsumeParam : IReadable<SpellSoulConsumeParam>
    {
        public SpellSoulConsumeParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
