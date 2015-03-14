using DarkSoulsII.DebugView.Core.Standard;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera
{
    public class CameraOperator : IReadable<CameraOperator>
    {
        public Matrix4 Matrix { get; set; }

        public CameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Matrix = pointerFactory.Create<Matrix4>(address + 0x0010, relative, true).Unbox(pointerFactory, reader);

            return this;
        }
    }
}
