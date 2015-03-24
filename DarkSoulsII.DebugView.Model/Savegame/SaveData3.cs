using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Savegame.SaveData;

namespace DarkSoulsII.DebugView.Model.Savegame
{
    public class SaveData3 : IReadable<SaveData3>
    {
        public SaveDataGenerator SaveDataGenerator { get; set; }
        public SaveDataEnemy SaveDataEnemy { get; set; }
        public SaveDataEvent SaveDataEvent { get; set; }
        public SaveDataObj SaveDataObj { get; set; }
        public SaveDataEnd SaveDataEnd { get; set; }

        public SaveData3 Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SaveDataGenerator = pointerFactory.Create<SaveDataGenerator>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            SaveDataEnemy = pointerFactory.Create<SaveDataEnemy>(address + 0x001C, relative).Unbox(pointerFactory, reader);
            SaveDataEvent = pointerFactory.Create<SaveDataEvent>(address + 0x0020, relative).Unbox(pointerFactory, reader);
            SaveDataObj = pointerFactory.Create<SaveDataObj>(address + 0x0024, relative).Unbox(pointerFactory, reader);
            SaveDataEnd = pointerFactory.Create<SaveDataEnd>(address + 0x0038, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}