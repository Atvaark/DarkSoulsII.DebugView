namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Model
{
    public class MdlDmy : IReadable<MdlDmy>
    {
        public MdlDmy Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}