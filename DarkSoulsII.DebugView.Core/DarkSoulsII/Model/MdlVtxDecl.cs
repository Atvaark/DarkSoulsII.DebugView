namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Model
{
    public class MdlVtxDecl : IReadable<MdlVtxDecl>
    {
        public MdlVtxDecl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}