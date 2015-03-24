using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.GameObjects.GameEntities;

namespace DarkSoulsII.DebugView.Model.Rtti
{
    public class CharacterCtrlBaseResolver : AbstractRttiResolver<CharacterCtrlBase>
    {
        protected override IPointer<CharacterCtrlBase> ResolvePointerTransitive(IPointerFactory pointerFactory, int address, bool relative, int vtable)
        {
            IPointer<CharacterCtrlBase> pointer;
            switch (vtable)
            {
                case 0x012D2054:
                    pointer = pointerFactory.Create<PlayerCtrl>(address, relative, true);
                    break;
                case 0x012CE454:
                    pointer = pointerFactory.Create<CharacterCtrl>(address, relative, true);
                    break;
                case 0x012CEB44:
                    pointer = pointerFactory.Create<DemoCharacterCtrl>(address, relative, true);
                    break;
                case 0x012CE5EC:
                    pointer = pointerFactory.Create<CharacterCtrlBase>(address, relative, true);
                    break;
                default:
                    pointer = null;
                    break;
            }
            return pointer;
        }
    }
}
