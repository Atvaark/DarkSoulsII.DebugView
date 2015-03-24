using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Ai.Navigation
{
    public class NaviGraphWorld : IReadable<NaviGraphWorld>
    {
        public NaviGraphCostEstimator NaviGraphCostEstimator { get; set; }
        public NvNaviGraphCostUpdater NvNaviGraphCostUpdater { get; set; }
        public NaviGraphHashTable<NaviGraphParts> Parts { get; set; }
        public NaviGraphHashTable<NaviGraphGate> Gates { get; set; }

        public NaviGraphWorld Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            NaviGraphCostEstimator = pointerFactory.Create<NaviGraphCostEstimator>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            NvNaviGraphCostUpdater = pointerFactory.Create<NvNaviGraphCostUpdater>(address + 0x00010, relative).Unbox(pointerFactory, reader);
            Parts = pointerFactory.Create<NaviGraphHashTable<NaviGraphParts>>(address + 0x0058, relative).Unbox(pointerFactory, reader);
            Gates = pointerFactory.Create<NaviGraphHashTable<NaviGraphGate>>(address + 0x005C, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }

    public class NvNaviGraphCostUpdater : IReadable<NvNaviGraphCostUpdater>
    {
        public NvNaviGraphCostUpdater Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}