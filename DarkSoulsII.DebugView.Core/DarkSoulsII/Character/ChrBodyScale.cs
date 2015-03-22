namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Character
{
    public class ChrBodyScale : IReadable<ChrBodyScale>
    {
        public float HeadScale { get; set; }
        public float ChestScale { get; set; }
        public float PelvisScale { get; set; }
        public float ArmsScale { get; set; }
        public float LegsScale { get; set; }

        public ChrBodyScale Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            HeadScale = reader.ReadSingle(address + 0x0008, relative);
            ChestScale = reader.ReadSingle(address + 0x000C, relative);
            PelvisScale = reader.ReadSingle(address + 0x0010, relative);
            ArmsScale = reader.ReadSingle(address + 0x0014, relative);
            LegsScale = reader.ReadSingle(address + 0x0018, relative);
            return this;
        }

    }
}