namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame.SaveData
{
    public class SaveDataLoadInfo2 : IReadable<SaveDataLoadInfo2>
    {
        public SaveDataLoadInfo2 Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}