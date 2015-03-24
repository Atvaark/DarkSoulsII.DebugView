using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Model
{
    public class MdlVtxBuf : IReadable<MdlVtxBuf>
    {
        public MdlVtxBuf Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}