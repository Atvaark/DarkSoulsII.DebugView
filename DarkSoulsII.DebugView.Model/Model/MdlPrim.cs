using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Model
{
    public class MdlPrim : IReadable<MdlPrim>
    {
        public MdlPrim Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}