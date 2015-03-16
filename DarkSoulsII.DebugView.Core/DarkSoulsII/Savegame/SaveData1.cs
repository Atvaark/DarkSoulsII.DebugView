using DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame.SaveData;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame
{
    public class SaveData1 : IReadable<SaveData1>
    {
        public SaveDataOption SaveDataOption { get; set; }
        public SaveDataLoadInfo SaveDataLoadInfo { get; set; }
        public SaveDataEnd SaveDataEnd { get; set; }

        public SaveData1 Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SaveDataOption = pointerFactory.Create<SaveDataOption>(address + 0x000C, relative).Unbox(pointerFactory, reader);
            SaveDataLoadInfo = pointerFactory.Create<SaveDataLoadInfo>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            SaveDataEnd = pointerFactory.Create<SaveDataEnd>(address + 0x0038, relative).Unbox(pointerFactory, reader);

            return this;
        }
    }
}