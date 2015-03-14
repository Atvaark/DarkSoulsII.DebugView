namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class MenuCameraOperator : PerspectiveCameraOperator, IReadable<MenuCameraOperator>
    {
        public new MenuCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
