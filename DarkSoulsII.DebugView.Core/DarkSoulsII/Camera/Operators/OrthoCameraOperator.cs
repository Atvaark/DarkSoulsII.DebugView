namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class OrthoCameraOperator : CameraOperator, IReadable<OrthoCameraOperator>
    {
        public new OrthoCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
