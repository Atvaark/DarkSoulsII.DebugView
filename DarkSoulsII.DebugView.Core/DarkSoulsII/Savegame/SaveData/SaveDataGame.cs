namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame.SaveData
{
    public class SaveDataGame : IReadable<SaveDataGame>
    {
        public SaveDataGame Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}