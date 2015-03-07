namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class GrapplerCameraOperator : PerspectiveCameraOperator, IReadable<GrapplerCameraOperator>
    {
        public new GrapplerCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
