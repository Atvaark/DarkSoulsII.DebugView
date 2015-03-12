﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameData.Items
{
    public class ItemInventory2BagList : ItemInventory2ListBase, IReadable<ItemInventory2BagList>
    {
        public ItemInventory2BagList Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            return this;
        }
    }
}