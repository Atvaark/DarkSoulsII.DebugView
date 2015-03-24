using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Event
{
    public class EventManager : IReadable<EventManager>
    {
        public float CurrentTime { get; set; }
        public EventFlagManager FlagManager { get; set; }
        public EventBonfireManager BonfireManager { get; set; }

        public EventManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            FlagManager = pointerFactory.Create<EventFlagManager>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            BonfireManager = pointerFactory.Create<EventBonfireManager>(address + 0x002C, relative).Unbox(pointerFactory, reader);
            // TODO: Add EventParamContainer
            CurrentTime = reader.ReadSingle(address + 0x00B0, relative);
            return this;
        }
    }
}
