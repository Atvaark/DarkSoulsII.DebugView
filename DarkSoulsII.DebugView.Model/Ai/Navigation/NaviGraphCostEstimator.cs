using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Ai.Navigation
{
    public class NaviGraphCostEstimator : IReadable<NaviGraphCostEstimator>
    {
        public NaviGraphCostEstimator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}