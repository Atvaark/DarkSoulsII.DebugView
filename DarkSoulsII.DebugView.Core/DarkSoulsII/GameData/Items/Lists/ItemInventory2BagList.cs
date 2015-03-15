using System.Collections.Generic;
using System.Linq;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items.Lists
{
    public class ItemInventory2BagList : ItemInventory2ListBase, IReadable<ItemInventory2BagList>
    {
        public List<Bag> Bags { get; set; }
        public Dictionary<ItemBagSlotType, Bag> EquippedBags { get; set; }

        public ItemInventory2BagList()
        {
            Bags = new List<Bag>();
        }

        public new ItemInventory2BagList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            // Disabled due to performance issues
            //Bags = pointerFactory.CreateArrayDereferenced<Bag>(address + 0x0014, relative, 3840)
            //    .Select(p => p.Unbox(pointerFactory, reader))
            //    .ToList();

            EquippedBags = pointerFactory.CreateArray<Bag>(address + 0x1E018, relative, 42)
                .Select((p, i) => new
                {
                    Bag = p.Unbox(pointerFactory, reader),
                    Slot = (ItemBagSlotType)i
                })
                .ToDictionary(pair => pair.Slot, pair => pair.Bag);

            return this;
        }

    }
}
