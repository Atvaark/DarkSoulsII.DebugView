using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Savegame.SaveData
{
    public class SaveDataItemPack : IReadable<SaveDataItemPack>
    {
        public SaveDataItemPack Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}