namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame
{
    public class SaveLoadSystem : IReadable<SaveLoadSystem>
    {
        public float TimeUntilNextSaveOpportunity { get; set; }
        public float TimeSinceLastSave { get; set; }
        public SaveReason SaveReasonType { get; set; }

        public SaveLoadSystem Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            TimeUntilNextSaveOpportunity = reader.ReadSingle(address + 0x0034, relative);
            TimeSinceLastSave = reader.ReadSingle(address + 0x0038, relative);
            SaveReasonType = (SaveReason) reader.ReadInt32(address + 0x003C, relative);
            return this;
        }
    }
}
