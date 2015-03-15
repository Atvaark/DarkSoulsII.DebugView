using DarkSoulsII.DebugView.Core.DarkSoulsII.Character;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities
{
    public class PlayerCtrl : CharacterCtrl, IReadable<PlayerCtrl>
    {
        public PlayerData Data { get; set; }

        public new PlayerCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            // ActionCtrl 0x0370
            // 0x0374
            Data = pointerFactory.Create<PlayerData>(address + 0x0378, relative).Unbox(pointerFactory, reader);
            // 0x037C
            return this;
        }
    }
}
