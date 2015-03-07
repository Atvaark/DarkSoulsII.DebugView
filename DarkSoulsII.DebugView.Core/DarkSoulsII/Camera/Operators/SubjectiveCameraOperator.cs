namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class SubjectiveCameraOperator : PerspectiveCameraOperator, IReadable<SubjectiveCameraOperator>
    {
        public new SubjectiveCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
