namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class FallDeadCameraOperator : PerspectiveCameraOperator, IReadable<FallDeadCameraOperator>
    {
        public new FallDeadCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
