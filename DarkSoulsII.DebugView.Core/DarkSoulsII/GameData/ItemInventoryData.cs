namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData
{
    public class ItemInventoryData : IReadable<ItemInventoryData>
    {
        public UserItemInventoryData UserData { get; set; }

        public ItemInventoryData Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            UserData = pointerFactory.Create<UserItemInventoryData>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
