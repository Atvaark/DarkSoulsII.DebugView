namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class PerspectiveCameraOperator : CameraOperator, IReadable<PerspectiveCameraOperator>
    {
        public new PerspectiveCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
