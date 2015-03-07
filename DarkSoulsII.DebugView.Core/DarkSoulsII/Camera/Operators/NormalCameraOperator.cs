namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class NormalCameraOperator : PerspectiveCameraOperator, IReadable<NormalCameraOperator>
    {
        public new NormalCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
