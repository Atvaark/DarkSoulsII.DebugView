namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class GrapplerCameraOperator : PerspectiveCameraOperator, IReadable<GrapplerCameraOperator>
    {
        public new GrapplerCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
