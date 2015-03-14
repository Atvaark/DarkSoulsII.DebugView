using DarkSoulsII.DebugView.Core.Standard.Templates;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities
{
    public class DemoCharacterCtrl : CharacterCtrlBase, IReadable<DemoCharacterCtrl>
    {
        public new DemoCharacterCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            Name = pointerFactory.Create<StdString>(address + 0x00B0, relative, true).Unbox(pointerFactory, reader).Value;
            return this;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
