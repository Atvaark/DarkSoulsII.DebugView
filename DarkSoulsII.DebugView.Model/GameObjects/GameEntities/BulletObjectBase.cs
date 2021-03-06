﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameObjects.GameEntities
{
    public class BulletObjectBase : GameEntity, IReadable<BulletObjectBase>
    {
        public new BulletObjectBase Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}