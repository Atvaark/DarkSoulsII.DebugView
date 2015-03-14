namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class ExFollowCameraOperator : PerspectiveCameraOperator, IReadable<ExFollowCameraOperator>
    {
        public new ExFollowCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
