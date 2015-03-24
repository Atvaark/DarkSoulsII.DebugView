using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Camera.Operators
{
    public class SubjectiveCameraOperator : PerspectiveCameraOperator, IReadable<SubjectiveCameraOperator>
    {
        public new SubjectiveCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
