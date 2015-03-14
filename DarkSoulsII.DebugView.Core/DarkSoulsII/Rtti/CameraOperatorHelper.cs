using DarkSoulsII.DebugView.Core.DarkSoulsII.Camera;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators;
using DarkSoulsII.DebugView.Core.Exceptions;
using DarkSoulsII.DebugView.Core.Rtti;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Rtti
{
    public class CameraOperatorHelper : IRttiResolver<CameraOperator>
    {
        private static CameraOperatorHelper _instance;

        private CameraOperatorHelper()
        {
        }

        public static CameraOperatorHelper Instance
        {
            get { return _instance ?? (_instance = new CameraOperatorHelper()); }
        }

        public IPointer<CameraOperator> ResolvePointer(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            if (address == 0)
                return null;

            int vtable;
            try
            {
                vtable = reader.ReadInt32(address, relative);
            }
            catch (MemoryInaccessibleException)
            {
                return null;
            }

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
