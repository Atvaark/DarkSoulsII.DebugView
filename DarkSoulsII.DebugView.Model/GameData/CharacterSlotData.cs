using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData
{
    public class CharacterSlotData : IReadable<CharacterSlotData>
    {
        public string Name { get; set; }
        public PlayerClass Class { get; set; }
        public byte NewGameLevel { get; set; }

        public CharacterSlotData Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Name = reader.ReadAnsiString(32, address + 0x0024, relative).Replace("\0", "");
            Class = (PlayerClass) reader.ReadByte(address + 0x0064);
            NewGameLevel = reader.ReadByte(address + 0x0068);
            return this;
        }
    }
}
