using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Steam.Achievement
{
    public class AppTrophy : IReadable<AppTrophy>, IFixedSize
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size
        {
            get { return 400; }
        }

        public AppTrophy Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Id = reader.ReadInt32(address + 0x0000, relative);
            Name = reader.ReadAnsiString(128, address + 0x0008, relative).TrimEnd('\0');
            return this;
        }

    }
}