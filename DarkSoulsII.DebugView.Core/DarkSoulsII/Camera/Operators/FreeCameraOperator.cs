namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class FreeCameraOperator : PerspectiveCameraOperator, IReadable<FreeCameraOperator>
    {
        public new FreeCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
