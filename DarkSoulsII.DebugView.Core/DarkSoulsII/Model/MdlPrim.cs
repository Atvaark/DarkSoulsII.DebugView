namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Model
{
    public class MdlPrim : IReadable<MdlPrim>
    {
        public MdlPrim Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}