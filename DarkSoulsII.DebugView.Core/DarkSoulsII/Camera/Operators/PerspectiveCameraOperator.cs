namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class PerspectiveCameraOperator : CameraOperator, IReadable<PerspectiveCameraOperator>
    {
        public new PerspectiveCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
