using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Sign
{
    public class SignPreviewCtrl : IReadable<SignPreviewCtrl>
    {
        public SignPreviewCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
