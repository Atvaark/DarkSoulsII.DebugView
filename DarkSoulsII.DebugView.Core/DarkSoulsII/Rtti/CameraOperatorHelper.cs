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

        public IPointer<CameraOperator> ResolvePointer(IReader reader, int address, bool relative = false)
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
                    pointer = Pointer<ActionCameraOperator>.Create(address);
                    break;
                case 0x012DD08C:
                    pointer = Pointer<DefaultCameraOperator>.Create(address);
                    break;
                case 0x012DD0E4:
                    pointer = Pointer<DemoCameraOperator>.Create(address);
                    break;
                case 0x012B03AC:
                    pointer = Pointer<EventCameraOperator>.Create(address);
                    break;
                case 0x012DD1DC:
                    pointer = Pointer<ExFollowCameraOperator>.Create(address);
                    break;
                case 0x012DD23C:
                    pointer = Pointer<FallDeadCameraOperator>.Create(address);
                    break;
                case 0x012DCDD4:
                    pointer = Pointer<FreeCameraOperator>.Create(address);
                    break;
                case 0x012DCE84:
                    pointer = Pointer<FreeOrthoCameraOperator>.Create(address);
                    break;
                case 0x012B0558:
                    pointer = Pointer<GrapplerCameraOperator>.Create(address);
                    break;
                case 0x012DCED4:
                    pointer = Pointer<IngameCameraOperator>.Create(address);
                    break;
                case 0x012B0608:
                    pointer = Pointer<MenuCameraOperator>.Create(address);
                    break;
                case 0x012DD294:
                    pointer = Pointer<NormalCameraOperator>.Create(address);
                    break;
                case 0x0134F624:
                    pointer = Pointer<OrthoCameraOperator>.Create(address);
                    break;
                case 0x0134A3CC:
                    pointer = Pointer<PerspectiveCameraOperator>.Create(address);
                    break;
                case 0x012DCF7C:
                    pointer = Pointer<PlayerCameraOperator>.Create(address);
                    break;
                case 0x012DD2E4:
                    pointer = Pointer<SubjectiveCameraOperator>.Create(address);
                    break;
                case 0x0134F64C:
                    pointer = Pointer<TransitionCameraOperator>.Create(address);
                    break;
                case 0x0134A3FC:
                    pointer = Pointer<CameraOperator>.Create(address);
                    break;
                default:
                    pointer = null;
                    break;
            }
            return pointer;
        }
    }
}
