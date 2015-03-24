using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Savegame.SaveData;

namespace DarkSoulsII.DebugView.Model.Savegame
{
    public class SaveData2 : IReadable<SaveData2>
    {
        public SaveDataPlayer SaveDataPlayer { get; set; }
        public SaveDataGame SaveDataGame { get; set; }
        public SaveDataShopLineup SaveDataShopLineup { get; set; }
        public SaveDataNetwork SaveDataNetwork { get; set; }
        public SaveDataItemInventory SaveDataItemInventory { get; set; }
        public SaveDataItemPack SaveDataItemPack { get; set; }
        public SaveDataGetObjItem SaveDataGetObjItem { get; set; }
        public SaveDataEnd SaveDataEnd { get; set; }

        public SaveData2 Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SaveDataPlayer = pointerFactory.Create<SaveDataPlayer>(address + 0x0000, relative).Unbox(pointerFactory, reader);
            SaveDataGame = pointerFactory.Create<SaveDataGame>(address + 0x0004, relative).Unbox(pointerFactory, reader);
            SaveDataShopLineup = pointerFactory.Create<SaveDataShopLineup>(address + 0x0014, relative).Unbox(pointerFactory, reader);
            SaveDataNetwork = pointerFactory.Create<SaveDataNetwork>(address + 0x0018, relative).Unbox(pointerFactory, reader);
            SaveDataItemInventory = pointerFactory.Create<SaveDataItemInventory>(address + 0x0028, relative).Unbox(pointerFactory, reader);
            SaveDataItemPack = pointerFactory.Create<SaveDataItemPack>(address + 0x0030, relative).Unbox(pointerFactory, reader);
            SaveDataGetObjItem = pointerFactory.Create<SaveDataGetObjItem>(address + 0x0034, relative).Unbox(pointerFactory, reader);
            SaveDataEnd = pointerFactory.Create<SaveDataEnd>(address + 0x0038, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}