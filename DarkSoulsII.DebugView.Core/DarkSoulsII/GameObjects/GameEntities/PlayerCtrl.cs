using DarkSoulsII.DebugView.Core.DarkSoulsII.Character;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities
{
    public class PlayerCtrl : CharacterCtrl, IReadable<PlayerCtrl>
    {
        public PlayerData Data { get; set; }

        public new PlayerCtrl Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            // ActionCtrl 0x0370
            // 0x0374
            Data = Pointer<PlayerData>.CreateAndUnbox(reader, address + 0x0378, relative);
            // 0x037C

            return this;
        }
    }
}
