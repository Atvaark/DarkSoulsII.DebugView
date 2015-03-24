using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Savegame.SaveData;

namespace DarkSoulsII.DebugView.Model.Savegame
{
    public class SaveLoadSystem : IReadable<SaveLoadSystem>
    {
        public SaveDataList SaveDataList { get; set; }
        public ContentFormat ContentFormat { get; set; }
        public SaveContent SaveContent { get; set; }
        public LoadContent LoadContent { get; set; }
        public float TimeUntilNextSaveOpportunity { get; set; }
        public float TimeSinceLastSave { get; set; }
        public SaveReason SaveReasonType { get; set; }

        public SaveLoadSystem Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SaveDataList = pointerFactory.Create<SaveDataList>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            ContentFormat = pointerFactory.Create<ContentFormat>(address + 0x0014, relative).Unbox(pointerFactory, reader);
            SaveContent = pointerFactory.Create<SaveContent>(address + 0x0018, relative).Unbox(pointerFactory, reader);
            LoadContent = pointerFactory.Create<LoadContent>(address + 0x001C, relative).Unbox(pointerFactory, reader);
            TimeUntilNextSaveOpportunity = reader.ReadSingle(address + 0x0034, relative);
            TimeSinceLastSave = reader.ReadSingle(address + 0x0038, relative);
            SaveReasonType = (SaveReason) reader.ReadInt32(address + 0x003C, relative);
            return this;
        }
    }
}
