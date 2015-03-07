using DarkSoulsII.DebugView.Core.Standard;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Controllers
{
    public class SignKeyGuideCtrl : IReadable<SignKeyGuideCtrl>
    {
        public Vector3 Position { get; set; }

        public SignKeyGuideCtrl Read(IReader reader, int address, bool relative = false)
        {
            Position = Pointer<Vector3>.Create(address + 0x0020, relative).Unbox(reader);
            return this;
        }
    }
}
