namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class MenuCameraOperator : PerspectiveCameraOperator, IReadable<MenuCameraOperator>
    {
        public new MenuCameraOperator Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}
