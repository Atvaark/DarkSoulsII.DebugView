namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics.Filters
{
    public class AppDepthOfFieldFilter : IReadable<AppDepthOfFieldFilter>
    {
        public float FocalDistance { get; set; }
        public float Scale { get; set; }

        public AppDepthOfFieldFilter Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            FocalDistance = reader.ReadSingle(address + 0x0044, relative);
            Scale = reader.ReadSingle(address + 0x007C, relative);
            return this;
        }

    }
}