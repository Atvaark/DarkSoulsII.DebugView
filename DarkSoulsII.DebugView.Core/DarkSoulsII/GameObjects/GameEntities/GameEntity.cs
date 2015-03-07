namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities
{
    public class GameEntity : GameObject, IReadable<GameEntity>
    {
        public new GameEntity Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            // GameEntityComponent 0x000C
            return this;
        }
    }
}
