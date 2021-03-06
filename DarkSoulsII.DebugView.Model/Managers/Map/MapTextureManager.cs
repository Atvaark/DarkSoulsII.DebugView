﻿using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Managers.Character;
using DarkSoulsII.DebugView.Model.Texture;

namespace DarkSoulsII.DebugView.Model.Managers.Map
{
    public class MapTextureManager : IReadable<MapTextureManager>
    {
        public ChrTextureManager ChrTextureManager { get; set; }
        public MapTexture MapTexture1 { get; set; }
        public MapTexture MapTexture2 { get; set; }

        public MapTextureManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ChrTextureManager = pointerFactory.Create<ChrTextureManager>(address + 0x0004, relative).Unbox(pointerFactory, reader);
            MapTexture1 = pointerFactory.Create<MapTexture>(address + 0x0014, relative).Unbox(pointerFactory, reader);
            MapTexture2 = pointerFactory.Create<MapTexture>(address + 0x0018, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
