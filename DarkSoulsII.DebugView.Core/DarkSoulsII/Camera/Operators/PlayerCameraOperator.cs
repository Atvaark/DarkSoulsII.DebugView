namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class PlayerCameraOperator : PerspectiveCameraOperator, IReadable<PlayerCameraOperator>
    {
        public new PlayerCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
