using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameObjects.GameEntities
{
    public class SignKeyGuideEntity : IReadable<SignKeyGuideEntity>
    {
        public short Id { get; set; }

        public SignKeyGuideEntity Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Id = reader.ReadInt16(address + 0x0014, relative);
            return this;
        }
    }
}
