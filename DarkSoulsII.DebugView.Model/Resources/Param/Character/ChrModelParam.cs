using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class ChrModelParam : IReadable<ChrModelParam>
    {
        public ChrModelParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
