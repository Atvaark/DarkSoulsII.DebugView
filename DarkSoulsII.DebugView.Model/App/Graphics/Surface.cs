using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.App.Graphics
{
    public class Surface : IReadable<Surface>
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Surface Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Width = reader.ReadInt32(address + 0x0024, relative);
            Height = reader.ReadInt32(address + 0x0028, relative);
            return this;
        }
    }
}
