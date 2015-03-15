using System.Collections.Generic;
using System.Linq;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items.Lists
{
    public class ItemInventory2CofferList : ItemInventory2ListBase, IReadable<ItemInventory2CofferList>
    {
        public List<Coffer> Coffers { get; set; }

        public ItemInventory2CofferList()
        {
            Coffers = new List<Coffer>();
        }
        public new ItemInventory2CofferList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);

            // Disabled due to performance issues
            //Coffers = pointerFactory.CreateArrayDereferenced<Coffer>(address + 0x0014, relative, 256)
            //    .Select(p => p.Unbox(pointerFactory, reader))
            //    .ToList();

            return this;
        }

    }
}
