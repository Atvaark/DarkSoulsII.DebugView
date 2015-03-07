using DarkSoulsII.DebugView.Core.DarkSoulsII.GameData;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers
{
    public class GameDataManager : IReadable<GameDataManager>
    {
        public CharacterSlotData CharacterSlotData { get; set; }
        public UserData000 UserData000 { get; set; }
        public SaveSlotData SaveSlotData { get; set; }

        public GameDataManager Read(IReader reader, int address, bool relative = false)
        {
            CharacterSlotData =
                Pointer<CharacterSlotData>.Create().Read(reader, address + 0x0060, relative).Unbox(reader);
            UserData000 = Pointer<UserData000>.CreateAndUnbox(reader, address + 0x0064, relative);
            SaveSlotData = Pointer<SaveSlotData>.CreateAndUnbox(reader, address + 0x006C, relative);
            // TODO: Add ItemInventoryWrapperWrapper
            return this;
        }
    }
}
