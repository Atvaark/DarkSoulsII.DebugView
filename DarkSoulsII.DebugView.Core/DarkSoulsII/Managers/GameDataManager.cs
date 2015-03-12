using DarkSoulsII.DebugView.Core.DarkSoulsII.GameData;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers
{
    public class GameDataManager : IReadable<GameDataManager>
    {
        public ItemInventoryData ItemInventoryData { get; set; }
        public CharacterSlotData CharacterSlotData { get; set; }
        public UserData000 UserData000 { get; set; }
        public SaveSlotData SaveSlotData { get; set; }

        public GameDataManager Read(IReader reader, int address, bool relative = false)
        {
            ItemInventoryData = Pointer<ItemInventoryData>.CreateAndUnbox(reader, address + 0x0008, relative);
            CharacterSlotData =
                Pointer<CharacterSlotData>.Create().Read(reader, address + 0x0060, relative).Unbox(reader);
            UserData000 = Pointer<UserData000>.CreateAndUnbox(reader, address + 0x0064, relative);
            SaveSlotData = Pointer<SaveSlotData>.CreateAndUnbox(reader, address + 0x006C, relative);
            return this;
        }
    }
}
