namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame.SaveData
{
    public class SaveDataGetObjItem : IReadable<SaveDataGetObjItem>
    {
        public SaveDataGetObjItem Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}