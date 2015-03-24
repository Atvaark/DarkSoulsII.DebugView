using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Camera.Operators
{
    public class EventCameraOperator : PerspectiveCameraOperator, IReadable<EventCameraOperator>
    {
        public new EventCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
