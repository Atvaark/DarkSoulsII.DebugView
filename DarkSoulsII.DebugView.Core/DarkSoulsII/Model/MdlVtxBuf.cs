namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Model
{
    public class MdlVtxBuf : IReadable<MdlVtxBuf>
    {
        public MdlVtxBuf Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}