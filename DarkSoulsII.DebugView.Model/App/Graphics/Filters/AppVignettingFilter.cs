using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.App.Graphics.Filters
{
    public class AppVignettingFilter : IReadable<AppVignettingFilter>
    {
        public AppVignettingFilter Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
