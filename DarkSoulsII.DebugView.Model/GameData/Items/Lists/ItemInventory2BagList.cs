using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items.Lists
{
    public class ItemInventory2BagList : ItemInventory2ListBase, IReadable<ItemInventory2BagList>
    {
        public List<Bag> Bags { get; set; }
        public Dictionary<ItemBagSlotType, Bag> EquippedBags { get; set; }
        public ItemInventory2EquipList ItemInventory2DaggerList { get; set; }
        public ItemInventory2EquipList ItemInventory2HeadList { get; set; }
        public ItemInventory2EquipList ItemInventory2RingList { get; set; }
        public ItemInventory2NormalList ItemInventory2AmmunitionList { get; set; }
        public ItemInventory2NormalList ItemInventory2ConsumableList { get; set; }
        public ItemInventory2SpellList ItemInventory2SpellList { get; set; }
        public ItemInventory2RepositoryList ItemInventory2RepositoryList { get; set; }

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

            // Disabled due to performance issues
            //ItemInventory2DaggerList = pointerFactory.Create<ItemInventory2EquipList>(address + 0x1E0D0, relative).Unbox(pointerFactory, reader);
            //ItemInventory2HeadList = pointerFactory.Create<ItemInventory2EquipList>(address + 0x1E0D4, relative).Unbox(pointerFactory, reader);
            //ItemInventory2RingList = pointerFactory.Create<ItemInventory2EquipList>(address + 0x1E0D8, relative).Unbox(pointerFactory, reader);
            //ItemInventory2AmmunitionList = pointerFactory.Create<ItemInventory2NormalList>(address + 0x1E0DC, relative).Unbox(pointerFactory, reader);
            //ItemInventory2ConsumableList = pointerFactory.Create<ItemInventory2NormalList>(address + 0x1E0E0, relative).Unbox(pointerFactory, reader);
            //ItemInventory2SpellList = pointerFactory.Create<ItemInventory2SpellList>(address + 0x1E0E4, relative).Unbox(pointerFactory, reader);
            //ItemInventory2RepositoryList = pointerFactory.Create<ItemInventory2RepositoryList>(address + 0x1E0E8, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}
