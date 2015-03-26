using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items
{
    public class Equipment : IReadable<Equipment>
    {
        public int ItemId { get; set; }
        public int IconId { get; set; }
        public Equipment Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Refactor the item structure from Bag, Repository and Equipment
            ItemId = reader.ReadInt32(address + 0x0004, relative);
            IconId = reader.ReadInt32(address + 0x0008, relative);
            return this;
        }

    }
}