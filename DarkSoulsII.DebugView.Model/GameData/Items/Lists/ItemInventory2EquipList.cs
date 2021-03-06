﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameData.Items.Lists
{
    public class ItemInventory2EquipList : ItemInventory2EachList<Equipment>, IReadable<ItemInventory2EquipList>
    {
        public new ItemInventory2EquipList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}