namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Event
{
    public class EventManager : IReadable<EventManager>
    {
        public float CurrentTime { get; set; }
        public EventFlagManager FlagManager { get; set; }
        public EventBonfireManager BonfireManager { get; set; }

        public EventManager Read(IReader reader, int address, bool relative = false)
        {
            FlagManager = Pointer<EventFlagManager>.CreateAndUnbox(reader, address + 0x0010, relative);
            BonfireManager = Pointer<EventBonfireManager>.CreateAndUnbox(reader, address + 0x002C, relative);
            // TODO: Add EventParamContainer
            CurrentTime = reader.ReadSingle(address + 0x00B0, relative);
            return this;
        }
    }
}
