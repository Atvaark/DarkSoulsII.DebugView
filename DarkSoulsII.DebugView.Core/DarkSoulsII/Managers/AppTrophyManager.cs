namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers
{
    public class AppTrophyManager : IReadable<AppTrophyManager>
    {
        public AppTrophyManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}