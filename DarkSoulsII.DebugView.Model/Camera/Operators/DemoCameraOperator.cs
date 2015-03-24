using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Camera.Operators
{
    public class DemoCameraOperator : PerspectiveCameraOperator, IReadable<DemoCameraOperator>
    {
        public new DemoCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
