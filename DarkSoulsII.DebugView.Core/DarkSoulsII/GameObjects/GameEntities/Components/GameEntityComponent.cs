﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities.Components
{
    public class GameEntityComponent : IReadable<GameEntityComponent>
    {
        public GameEntityComponent Read(IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
