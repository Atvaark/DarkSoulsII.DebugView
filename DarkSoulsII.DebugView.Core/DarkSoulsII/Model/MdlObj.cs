namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Model
{
    public class MdlObj : IReadable<MdlObj>
    {
        public MdlObj Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}