namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame.SaveData
{
    public class SaveDataList : IReadable<SaveDataList>
    {
        public SaveData1 SaveData1 { get; set; }
        public SaveData2 SaveData2 { get; set; }
        public SaveData3 SaveData3 { get; set; }
        public SaveData4 SaveData4 { get; set; }

        public SaveDataList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SaveData1 = pointerFactory.Create<SaveData1>(address + 0x0000, relative).Unbox(pointerFactory, reader);
            SaveData2 = pointerFactory.Create<SaveData2>(address + 0x000C, relative).Unbox(pointerFactory, reader);
            SaveData3 = pointerFactory.Create<SaveData3>(address + 0x0018, relative).Unbox(pointerFactory, reader);
            SaveData4 = pointerFactory.Create<SaveData4>(address + 0x0024, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}