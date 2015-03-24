using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items
{
    public class Torch : IReadable<Torch>
    {
        public float TimeLeft1 { get; set; }
        public float TimeLeft2 { get; set; }

        public Torch Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            TimeLeft1 = reader.ReadSingle(address + 0x0000, relative);
            TimeLeft2 = reader.ReadSingle(address + 0x0004, relative);
            return this;
        }

    }
}
