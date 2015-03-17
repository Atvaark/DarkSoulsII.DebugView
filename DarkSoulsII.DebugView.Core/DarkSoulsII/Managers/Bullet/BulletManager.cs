﻿using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities;
using DarkSoulsII.DebugView.Core.Standard.Templates;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Bullet
{
    public class BulletManager : IReadable<BulletManager>
    {
        public StdVector<BulletObject> Bullets { get; set; }

        public BulletManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Bullets = pointerFactory.Create<StdVector<BulletObject>>(address + 0x0000, relative, true).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
