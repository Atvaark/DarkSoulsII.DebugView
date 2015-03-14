namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App
{
    public class MainApp : IReadable<MainApp>
    {
        public MainApp Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
