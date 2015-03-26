using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items
{
    public class Spell : IReadable<Spell>
    {
        public int SpellId { get; set; }
        public int IconId { get; set; }
        public Spell Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Refactor the item structure from Bag, Repository, Equipment and Spell
            SpellId = reader.ReadInt32(address + 0x0004, relative);
            IconId = reader.ReadInt32(address + 0x0008, relative);
            return this;
        }

    }
}