using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.App.Graphics.Filters
{
    public class ColorVector4 : IReadable<ColorVector4>
    {
        public float Red { get; set; }
        public float Green { get; set; }
        public float Blue { get; set; }
        public float Intensity { get; set; }

        public ColorVector4 Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Red = reader.ReadSingle(address + 0x0000, relative);
            Green = reader.ReadSingle(address + 0x0004, relative);
            Blue = reader.ReadSingle(address + 0x0008, relative);
            Intensity = reader.ReadSingle(address + 0x000C, relative);
            return this;
        }

    }
}