using DarkSoulsII.DebugView.Core.Standard.Templates;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities
{
    public class DemoCharacterCtrl : CharacterCtrlBase, IReadable<DemoCharacterCtrl>
    {
        public new DemoCharacterCtrl Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            Name = Pointer<StdString>.Create(address + 0x00B0).Unbox(reader).Value;
            return this;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
