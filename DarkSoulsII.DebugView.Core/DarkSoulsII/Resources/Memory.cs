namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources
{
    public class Memory : IReadable<Memory>
    {
        public byte[] Data { get; set; }

        public Memory Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int size = reader.ReadInt32(address + 0x000C, relative);
            Data = GenericPointer.Create(reader, address + 0x0008, relative).Unbox(reader,
                (r, a) => r.Read(size, a));
            return this;
        }
    }
}
