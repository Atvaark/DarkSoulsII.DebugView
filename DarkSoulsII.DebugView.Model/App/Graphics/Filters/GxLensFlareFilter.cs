using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.App.Graphics.Filters
{
    public class GxLensFlareFilter : IReadable<GxLensFlareFilter>
    {
        public GxLensFlareFilter Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
