using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Input
{
    public class RumbleManager : IReadable<RumbleManager>
    {
        public RumbleManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Add RumbleParamContainer 001C
            return this;
        }
    }
}
