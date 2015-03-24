using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Savegame.SaveData
{
    public class SaveDataEnd : IReadable<SaveDataEnd>
    {
        public int Size { get; set; }

        public SaveDataEnd Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int unknown = reader.ReadInt32(address + 0x0004, relative);
            Size = reader.ReadInt32(address + 0x0008, relative);
            return this;
        }

    }
}