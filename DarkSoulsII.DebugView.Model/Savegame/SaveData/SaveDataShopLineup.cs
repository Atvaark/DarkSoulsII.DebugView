using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Savegame.SaveData
{
    public class SaveDataShopLineup : IReadable<SaveDataShopLineup>
    {
        public SaveDataShopLineup Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}