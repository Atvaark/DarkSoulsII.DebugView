using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Savegame.SaveData;

namespace DarkSoulsII.DebugView.Model.Savegame
{
    public class SaveData4 : IReadable<SaveData4>
    {
        public SaveDataLoadInfo2 SaveDataLoadInfo2 { get; set; }
        public SaveDataEnd SaveDataEnd { get; set; }

        public SaveData4 Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SaveDataLoadInfo2 = pointerFactory.Create<SaveDataLoadInfo2>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            SaveDataEnd = pointerFactory.Create<SaveDataEnd>(address + 0x0038, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}