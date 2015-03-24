using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Sign
{
    public class SignEventAreaManager : IReadable<SignEventAreaManager>
    {
        public SignEventAreaManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
