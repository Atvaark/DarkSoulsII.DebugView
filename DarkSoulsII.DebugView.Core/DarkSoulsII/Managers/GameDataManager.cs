using DarkSoulsII.DebugView.Core.DarkSoulsII.GameData;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers
{
    public class GameDataManager : IReadable<GameDataManager>
    {
        public ItemInventoryData ItemInventoryData { get; set; }
        public CharacterSlotData CharacterSlotData { get; set; }
        public UserData000 UserData000 { get; set; }
        public SaveSlotData SaveSlotData { get; set; }

        public GameDataManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ItemInventoryData = pointerFactory.Create<ItemInventoryData>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            CharacterSlotData = pointerFactory.Create<CharacterSlotData>(address + 0x0060, relative).Unbox(pointerFactory, reader);
            UserData000 = pointerFactory.Create<UserData000>(address + 0x0064, relative).Unbox(pointerFactory, reader);
            SaveSlotData = pointerFactory.Create<SaveSlotData>(address + 0x006C, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
