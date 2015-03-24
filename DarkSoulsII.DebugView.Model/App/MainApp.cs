using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.App
{
    public class MainApp : IReadable<MainApp>
    {
        public MainApp Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
