using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Demo
{
    public class DemoManager : IReadable<DemoManager>
    {
        public DemoManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Add DemoManagerParam 0020
            return this;
        }
    }
}
