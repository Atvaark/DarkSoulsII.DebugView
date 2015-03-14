using DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators;
using DarkSoulsII.DebugView.Core.Standard;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers
{
    public class CameraManager : IReadable<CameraManager>
    {
        public FreeCameraOperator FreeCameraOperator { get; set; }
        public PlayerCameraOperator PlayerCameraOperator { get; set; }
        public IngameCameraOperator IngameCameraOperator { get; set; }
        public float FieldOfView { get; set; }
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public Matrix4 Matrix { get; set; }
        public Vector3 CameraTarget { get; set; }

        public CameraManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            FreeCameraOperator = pointerFactory.Create<FreeCameraOperator>(address + 0x0018, relative).Unbox(pointerFactory, reader);
            PlayerCameraOperator = pointerFactory.Create<PlayerCameraOperator>(address + 0x001C, relative).Unbox(pointerFactory, reader);
            IngameCameraOperator = pointerFactory.Create<IngameCameraOperator>(address + 0x0020, relative).Unbox(pointerFactory, reader);

            Matrix = pointerFactory.Create<Matrix4>(address + 0x0160, relative, true).Unbox(pointerFactory, reader);
            CameraTarget = pointerFactory.Create<Vector3>(address + 0x01A0, relative, true).Unbox(pointerFactory, reader);
            FieldOfView = reader.ReadSingle(address + 0x01B0, relative);
            ScreenWidth = reader.ReadInt32(address + 0x01BC, relative);
            ScreenHeight = reader.ReadInt32(address + 0x01C0, relative);

            // CameraParam 0x03AC
            return this;
        }
    }
}
