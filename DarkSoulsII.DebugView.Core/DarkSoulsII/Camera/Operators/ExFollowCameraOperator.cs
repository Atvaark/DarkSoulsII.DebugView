namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class ExFollowCameraOperator : PerspectiveCameraOperator, IReadable<ExFollowCameraOperator>
    {
        public new ExFollowCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
