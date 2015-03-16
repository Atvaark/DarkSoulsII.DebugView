namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame.SaveData
{
    public class SaveDataLoadInfo : IReadable<SaveDataLoadInfo>
    {
        public SaveDataLoadInfo Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}