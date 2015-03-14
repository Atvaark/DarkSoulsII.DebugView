namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData
{
    public class UserData000 : IReadable<UserData000>
    {
        public string SteamId { get; set; }

        public UserData000 Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SteamId = reader.ReadString(16, address + 0x0015, relative);
            return this;
        }
    }
}
