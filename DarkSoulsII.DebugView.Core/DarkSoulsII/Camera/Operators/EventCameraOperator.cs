namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class EventCameraOperator : PerspectiveCameraOperator, IReadable<EventCameraOperator>
    {
        public new EventCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
