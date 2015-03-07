using DarkSoulsII.DebugView.Core.Standard;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera
{
    public class CameraOperator : IReadable<CameraOperator>
    {
        public Matrix4 Matrix { get; set; }

        public CameraOperator Read(IReader reader, int address, bool relative = false)
        {
            Matrix = Pointer<Matrix4>.Create(address + 0x0010, relative).Unbox(reader);

            return this;
        }
    }
}
