using DarkSoulsII.DebugView.Core.DarkSoulsII.Character;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities
{
    public class CharacterCtrlBase : GameEntity, IReadable<CharacterCtrlBase>
    {
        public int Id1 { get; set; }
        public int Id2 { get; set; }
        public CharacterType Type { get; set; }
        public string Name { get; set; }

        public new CharacterCtrlBase Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            Id1 = reader.ReadInt32(address + 0x0014);
            Id2 = reader.ReadInt32(address + 0x0018);
            Type = (CharacterType) reader.ReadInt32(address + 0x001C);
            // CharacterFlags 0x002C
            return this;
        }
    }
}
