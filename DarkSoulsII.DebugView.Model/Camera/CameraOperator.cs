using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Standard;

namespace DarkSoulsII.DebugView.Model.Camera
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
