using System.Text;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources
{
    public class FileResourceObject : ResourceObject, IReadable<FileResourceObject>
    {
        public string Name { get; set; }

        public new FileResourceObject Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            Name = GenericPointer.Create(reader, address + 0x005C, relative).Unbox(reader,
                (r, a) => r.ReadNullTerminatedStringChunked(Encoding.Unicode, 2, 16, a, false));
            return this;
        }
    }
}
