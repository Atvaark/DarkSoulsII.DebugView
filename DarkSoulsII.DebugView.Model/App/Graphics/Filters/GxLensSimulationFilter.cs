using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.App.Graphics.Filters
{
    public class GxLensSimulationFilter : IReadable<GxLensSimulationFilter>
    {
        public GxLensSimulationFilter Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
