namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class OrthoCameraOperator : CameraOperator, IReadable<OrthoCameraOperator>
    {
        public new OrthoCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
