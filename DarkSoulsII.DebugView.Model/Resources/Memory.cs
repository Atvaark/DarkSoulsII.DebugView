using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources
{
    public class Memory : IReadable<Memory>
    {
        public byte[] Data { get; set; }

        public Memory Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int size = reader.ReadInt32(address + 0x000C, relative);
            int dataAddress = reader.ReadInt32(address + 0x0008, relative);
            Data = reader.Read(size, dataAddress); // TODO: Test
            return this;
        }
    }
}
