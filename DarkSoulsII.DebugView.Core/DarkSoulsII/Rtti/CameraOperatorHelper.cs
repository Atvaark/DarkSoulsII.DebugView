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
                    pointer = Pointer<ActionCameraOperator>.Create(address, relative);
                    break;
                case 0x012DD08C:
                    pointer = Pointer<DefaultCameraOperator>.Create(address, relative);
                    break;
                case 0x012DD0E4:
                    pointer = Pointer<DemoCameraOperator>.Create(address, relative);
                    break;
                case 0x012B03AC:
                    pointer = Pointer<EventCameraOperator>.Create(address, relative);
                    break;
                case 0x012DD1DC:
                    pointer = Pointer<ExFollowCameraOperator>.Create(address, relative);
                    break;
                case 0x012DD23C:
                    pointer = Pointer<FallDeadCameraOperator>.Create(address, relative);
                    break;
                case 0x012DCDD4:
                    pointer = Pointer<FreeCameraOperator>.Create(address, relative);
                    break;
                case 0x012DCE84:
                    pointer = Pointer<FreeOrthoCameraOperator>.Create(address, relative);
                    break;
                case 0x012B0558:
                    pointer = Pointer<GrapplerCameraOperator>.Create(address, relative);
                    break;
                case 0x012DCED4:
                    pointer = Pointer<IngameCameraOperator>.Create(address, relative);
                    break;
                case 0x012B0608:
                    pointer = Pointer<MenuCameraOperator>.Create(address, relative);
                    break;
                case 0x012DD294:
                    pointer = Pointer<NormalCameraOperator>.Create(address, relative);
                    break;
                case 0x0134F624:
                    pointer = Pointer<OrthoCameraOperator>.Create(address, relative);
                    break;
                case 0x0134A3CC:
                    pointer = Pointer<PerspectiveCameraOperator>.Create(address, relative);
                    break;
                case 0x012DCF7C:
                    pointer = Pointer<PlayerCameraOperator>.Create(address, relative);
                    break;
                case 0x012DD2E4:
                    pointer = Pointer<SubjectiveCameraOperator>.Create(address, relative);
                    break;
                case 0x0134F64C:
                    pointer = Pointer<TransitionCameraOperator>.Create(address, relative);
                    break;
                case 0x0134A3FC:
                    pointer = Pointer<CameraOperator>.Create(address, relative);
                    break;
                default:
                    pointer = null;
                    break;
            }
            return pointer;
        }
    }
}
