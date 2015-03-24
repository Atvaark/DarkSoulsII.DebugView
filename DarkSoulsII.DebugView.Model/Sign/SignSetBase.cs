using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Sign
{
    public class SignSetBase : IReadable<SignSetBase>
    {
        public int MaxSignCount { get; set; }
        public int SignCount { get; set; }
        public float RefreshTime { get; set; }

        public SignSetBase Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            MaxSignCount = reader.ReadInt32(address + 0x000C, relative);
            SignCount = reader.ReadInt32(address + 0x001C, relative);
            RefreshTime = reader.ReadSingle(address + 0x0020, relative);
            return this;
        }

    }
}