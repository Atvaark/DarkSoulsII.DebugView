using System.Collections.Generic;
using System.Linq;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items.Lists
{
    public class ItemInventory2ShopList : ItemInventory2ListBase, IReadable<ItemInventory2ShopList>
    {
        public List<Shop> Shops { get; set; }

        public ItemInventory2ShopList()
        {
            Shops = new List<Shop>();
        }
        public new ItemInventory2ShopList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            Shops = pointerFactory.CreateArrayDereferenced<Shop>(address + 0x0FB8, relative, 64)
                .Select(p => p.Unbox(pointerFactory, reader))
                .ToList();
            return this;
        }

    }
}
