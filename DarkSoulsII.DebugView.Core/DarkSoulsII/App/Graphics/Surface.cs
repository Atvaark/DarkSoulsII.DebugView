namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics
{
    public class Surface : IReadable<Surface>
    {
        public Surface Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
