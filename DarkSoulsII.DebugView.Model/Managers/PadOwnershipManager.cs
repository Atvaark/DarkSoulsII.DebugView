using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers
{
    public class PadOwnershipManager : IReadable<PadOwnershipManager>
    {
        public PadOwnershipManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {

            return this;
        }
    }
}