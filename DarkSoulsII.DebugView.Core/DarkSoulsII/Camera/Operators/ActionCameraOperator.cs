namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class ActionCameraOperator : PerspectiveCameraOperator, IReadable<ActionCameraOperator>
    {
        public new ActionCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
