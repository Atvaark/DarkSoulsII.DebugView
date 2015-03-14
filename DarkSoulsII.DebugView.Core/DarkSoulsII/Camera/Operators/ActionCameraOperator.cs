namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class ActionCameraOperator : PerspectiveCameraOperator, IReadable<ActionCameraOperator>
    {
        public new ActionCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
