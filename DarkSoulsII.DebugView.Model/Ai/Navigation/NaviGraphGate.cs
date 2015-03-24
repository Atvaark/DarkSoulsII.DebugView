using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Ai.Navigation
{
    public class NaviGraphGate : IReadable<NaviGraphGate>
    {
        public NaviGraphGate Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}