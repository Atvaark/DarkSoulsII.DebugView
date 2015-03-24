using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class ChrNetworkPhantomParam : IReadable<ChrNetworkPhantomParam>
    {
        public ChrNetworkPhantomParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
