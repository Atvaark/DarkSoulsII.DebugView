namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class IngameCameraOperator : TransitionCameraOperator, IReadable<IngameCameraOperator>
    {
        public new IngameCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
