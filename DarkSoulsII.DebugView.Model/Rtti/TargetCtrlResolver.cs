using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.GameObjects.Target;

namespace DarkSoulsII.DebugView.Model.Rtti
{
    public class TargetCtrlResolver : AbstractRttiResolver<TargetCtrl>
    {
        protected override IPointer<TargetCtrl> ResolvePointerTransitive(IPointerFactory pointerFactory, int address, bool relative, int vtable)
        {
            IPointer<TargetCtrl> pointer;
            switch (vtable)
            {
                case 0x012D7DA4:
                    pointer = pointerFactory.Create<TargetMapGeneralLocationCtrl>(address, relative, true);
                    break;
                case 0x012D7D0C:
                    pointer = pointerFactory.Create<TargetMapCtrl>(address, relative, true);
                    break;
                case 0x012D7C8C:
                    pointer = pointerFactory.Create<TargetGeneratorCtrl>(address, relative, true);
                    break;
                case 0x012D7BA4:
                    pointer = pointerFactory.Create<TargetCharacterCtrl>(address, relative, true);
                    break;
                case 0x012C3EF4:
                    pointer = pointerFactory.Create<TargetBulletCtrl>(address, relative, true);
                    break;
                case 0x012D7C1C:
                    pointer = pointerFactory.Create<TargetCtrl>(address, relative, true);
                    break;
                default:
                    pointer = null;
                    break;
            }
            return pointer;
        }

    }
}