using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class ChrEditParamBodyPreset : IReadable<ChrEditParamBodyPreset>
    {
        public ChrEditParamBodyPreset Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
