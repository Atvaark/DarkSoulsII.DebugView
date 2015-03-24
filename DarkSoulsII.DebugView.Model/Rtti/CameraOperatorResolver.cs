using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Camera;
using DarkSoulsII.DebugView.Model.Camera.Operators;

namespace DarkSoulsII.DebugView.Model.Rtti
{
    public class CameraOperatorResolver : AbstractRttiResolver<CameraOperator>
    {
        protected override IPointer<CameraOperator> ResolvePointerTransitive(IPointerFactory pointerFactory, int address, bool relative, int vtable)
        {
            IPointer<CameraOperator> pointer;
            switch (vtable)
            {
                case 0x012DCFCC:
                    pointer = pointerFactory.Create<ActionCameraOperator>(address, relative, true);
                    break;
                case 0x012DD08C:
                    pointer = pointerFactory.Create<DefaultCameraOperator>(address, relative, true);
                    break;
                case 0x012DD0E4:
                    pointer = pointerFactory.Create<DemoCameraOperator>(address, relative, true);
                    break;
                case 0x012B03AC:
                    pointer = pointerFactory.Create<EventCameraOperator>(address, relative, true);
                    break;
                case 0x012DD1DC:
                    pointer = pointerFactory.Create<ExFollowCameraOperator>(address, relative, true);
                    break;
                case 0x012DD23C:
                    pointer = pointerFactory.Create<FallDeadCameraOperator>(address, relative, true);
                    break;
                case 0x012DCDD4:
                    pointer = pointerFactory.Create<FreeCameraOperator>(address, relative, true);
                    break;
                case 0x012DCE84:
                    pointer = pointerFactory.Create<FreeOrthoCameraOperator>(address, relative, true);
                    break;
                case 0x012B0558:
                    pointer = pointerFactory.Create<GrapplerCameraOperator>(address, relative, true);
                    break;
                case 0x012DCED4:
                    pointer = pointerFactory.Create<IngameCameraOperator>(address, relative, true);
                    break;
                case 0x012B0608:
                    pointer = pointerFactory.Create<MenuCameraOperator>(address, relative, true);
                    break;
                case 0x012DD294:
                    pointer = pointerFactory.Create<NormalCameraOperator>(address, relative, true);
                    break;
                case 0x0134F624:
                    pointer = pointerFactory.Create<OrthoCameraOperator>(address, relative, true);
                    break;
                case 0x0134A3CC:
                    pointer = pointerFactory.Create<PerspectiveCameraOperator>(address, relative, true);
                    break;
                case 0x012DCF7C:
                    pointer = pointerFactory.Create<PlayerCameraOperator>(address, relative, true);
                    break;
                case 0x012DD2E4:
                    pointer = pointerFactory.Create<SubjectiveCameraOperator>(address, relative, true);
                    break;
                case 0x0134F64C:
                    pointer = pointerFactory.Create<TransitionCameraOperator>(address, relative, true);
                    break;
                case 0x0134A3FC:
                    pointer = pointerFactory.Create<CameraOperator>(address, relative, true);
                    break;
                default:
                    pointer = null;
                    break;
            }
            return pointer;
        }
    }
}
