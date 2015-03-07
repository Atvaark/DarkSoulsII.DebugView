namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class DefaultCameraOperator : PerspectiveCameraOperator, IReadable<DefaultCameraOperator>
    {
        public new DefaultCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
