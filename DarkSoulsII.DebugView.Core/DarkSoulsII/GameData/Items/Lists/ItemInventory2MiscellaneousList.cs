namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items.Lists
{
    public class ItemInventory2MiscellaneousList : IReadable<ItemInventory2MiscellaneousList>
    {
        public Torch Torch { get; set; }

        public ItemInventory2MiscellaneousList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Torch = pointerFactory.Create<Torch>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}
