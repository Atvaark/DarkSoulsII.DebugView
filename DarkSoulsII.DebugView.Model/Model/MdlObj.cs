using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Model
{
    public class MdlObj : IReadable<MdlObj>
    {
        public MdlObj Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}