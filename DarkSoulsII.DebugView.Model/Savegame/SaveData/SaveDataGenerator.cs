using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Savegame.SaveData
{
    public class SaveDataGenerator : IReadable<SaveDataGenerator>
    {
        public SaveDataGenerator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}