namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities
{
    public class SignKeyGuideEntity : IReadable<SignKeyGuideEntity>
    {
        public short Id { get; set; }

        public SignKeyGuideEntity Read(IReader reader, int address, bool relative = false)
        {
            Id = reader.ReadInt16(address + 0x0014, relative);
            return this;
        }
    }
}
