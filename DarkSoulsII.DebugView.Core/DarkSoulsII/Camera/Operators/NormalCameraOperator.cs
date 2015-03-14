namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class NormalCameraOperator : PerspectiveCameraOperator, IReadable<NormalCameraOperator>
    {
        public new NormalCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
