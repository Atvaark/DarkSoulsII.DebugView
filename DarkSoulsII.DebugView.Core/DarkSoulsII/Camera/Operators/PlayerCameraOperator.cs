namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
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
