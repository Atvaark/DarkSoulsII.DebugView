namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class DefaultCameraOperator : PerspectiveCameraOperator, IReadable<DefaultCameraOperator>
    {
        public new DefaultCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
