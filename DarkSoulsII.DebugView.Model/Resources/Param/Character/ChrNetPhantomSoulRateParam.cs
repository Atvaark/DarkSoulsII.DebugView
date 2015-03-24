using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class ChrNetPhantomSoulRateParam : IReadable<ChrNetPhantomSoulRateParam>
    {
        public ChrNetPhantomSoulRateParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
