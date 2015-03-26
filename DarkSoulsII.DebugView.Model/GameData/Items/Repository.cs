using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items
{
    public class Repository : IReadable<Repository>
    {
        public int ItemId { get; set; }
        public int IconId { get; set; }
        //public int Count { get; set; }
        //public float Durability { get; set; } 
        public Repository Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Refactor the item structure from Bag and Repository
            ItemId = reader.ReadInt32(address + 0x0004, relative);
            IconId = reader.ReadInt32(address + 0x0008, relative);
            //Count = reader.ReadInt32(address + 0x0010, relative);
            //Durability = reader.ReadSingle(address + 0x0010, relative);
            return this;
        }

    }
}