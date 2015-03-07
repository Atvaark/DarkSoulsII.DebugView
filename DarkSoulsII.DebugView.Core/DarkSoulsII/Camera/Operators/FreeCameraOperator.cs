namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class FreeCameraOperator : PerspectiveCameraOperator, IReadable<FreeCameraOperator>
    {
        public new FreeCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
