﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Texture
{
    public class MapTexture : MdlTexture, IReadable<MapTexture>
    {
        public new MapTexture Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
