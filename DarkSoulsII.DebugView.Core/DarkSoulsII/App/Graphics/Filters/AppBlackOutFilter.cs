namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics.Filters
{
    public class AppBlackOutFilter : IReadable<AppBlackOutFilter>
    {
        public AppBlackOutFilter Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
