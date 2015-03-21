namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Model
{
    public class MdlMtx : IReadable<MdlMtx>
    {
        public MdlMtx Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}