namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData
{
    public class ItemInventoryData : IReadable<ItemInventoryData>
    {
        public UserItemInventoryData UserData { get; set; }

        public ItemInventoryData Read(IReader reader, int address, bool relative = false)
        {
            UserData = Pointer<UserItemInventoryData>.CreateAndUnbox(reader, address + 0x0008, relative);
            return this;
        }
    }
}
