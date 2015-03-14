namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData
{
    public class SaveSlotData : IReadable<SaveSlotData>
    {
        public byte SaveSlotId { get; set; }

        public SaveSlotData Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SaveSlotId = reader.ReadByte(address + 0x1368, relative);
            return this;
        }
    }
}
