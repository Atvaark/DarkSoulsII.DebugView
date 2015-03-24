using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Model
{
    public class MdlDmy : IReadable<MdlDmy>
    {
        public MdlDmy Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}