namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class IngameCameraOperator : TransitionCameraOperator, IReadable<IngameCameraOperator>
    {
        public new IngameCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
