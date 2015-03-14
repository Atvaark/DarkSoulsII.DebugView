namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics.Filters
{
    public class AppFogFilter : IReadable<AppFogFilter>
    {
        public byte FogBlue { get; set; }
        public byte FogGreen { get; set; }
        public byte FogRed { get; set; }
        public byte FogAlpha { get; set; }
        public float FogDistance { get; set; }
        public float Overlay { get; set; }
        public float Height { get; set; }

        public AppFogFilter Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            FogBlue = reader.ReadByte(address + 0x0004, relative);
            FogGreen = reader.ReadByte(address + 0x0005, relative);
            FogRed = reader.ReadByte(address + 0x0006, relative);
            FogAlpha = reader.ReadByte(address + 0x0007, relative);
            FogDistance = reader.ReadSingle(address + 0x0008, relative);
            Overlay = reader.ReadSingle(address + 0x0024, relative);
            Height = reader.ReadSingle(address + 0x0028, relative);
            return this;
        }
    }
}
