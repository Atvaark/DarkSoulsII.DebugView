namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame.SaveData
{
    public class SaveDataItemPack : IReadable<SaveDataItemPack>
    {
        public SaveDataItemPack Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}