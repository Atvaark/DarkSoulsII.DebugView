using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Event
{
    public class EventFlagManager : IReadable<EventFlagManager>
    {
        public EventFlagManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Add EventFlagParamContainer
            return this;
        }
    }
}
