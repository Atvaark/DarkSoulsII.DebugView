using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Standard
{
    public class StdWstring : IReadable<StdWstring>
    {
        public string Value { get; set; }

        public StdWstring Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int length = reader.ReadInt32(address + 0x0010);
            int stringAddress = length >= 8 ? reader.ReadInt32(address) : address;
            Value = reader.ReadUnicodeString(length, stringAddress);
            return this;
        }
    }
}
