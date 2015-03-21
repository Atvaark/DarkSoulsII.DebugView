namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Model
{
    public class MdlIdxBuf : IReadable<MdlIdxBuf>
    {
        public MdlIdxBuf Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}