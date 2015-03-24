using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Character;

namespace DarkSoulsII.DebugView.Model.GameObjects.GameEntities
{
    public class CharacterCtrlBase : GameEntity, IReadable<CharacterCtrlBase>
    {
        public int Id1 { get; set; }
        public int Id2 { get; set; }
        public CharacterType Type { get; set; }
        public string Name { get; set; }

        public new CharacterCtrlBase Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            Id1 = reader.ReadInt32(address + 0x0014);
            Id2 = reader.ReadInt32(address + 0x0018);
            Type = (CharacterType) reader.ReadInt32(address + 0x001C);
            // CharacterFlags 0x002C
            return this;
        }
    }
}
