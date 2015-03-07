namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class DemoCameraOperator : PerspectiveCameraOperator, IReadable<DemoCameraOperator>
    {
        public new DemoCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
