namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers
{
    public class GameManager : IReadable<GameManager>
    {
        public GameManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
