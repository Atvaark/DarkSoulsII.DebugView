using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Camera.Operators
{
    public class PlayerCameraOperator : PerspectiveCameraOperator, IReadable<PlayerCameraOperator>
    {
        public new PlayerCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
