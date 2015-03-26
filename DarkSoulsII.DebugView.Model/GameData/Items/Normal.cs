using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items
{
    public class Normal : IReadable<Normal>
    {
        public int ItemId { get; set; }
        public int IconId { get; set; }

        public Normal Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ItemId = reader.ReadInt32(address + 0x0004, relative);
            IconId = reader.ReadInt32(address + 0x0008, relative);
            return this;
        }

    }
}