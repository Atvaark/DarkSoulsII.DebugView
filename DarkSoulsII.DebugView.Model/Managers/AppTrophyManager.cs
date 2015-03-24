using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Steam.Achievement;

namespace DarkSoulsII.DebugView.Model.Managers
{
    public class AppTrophyManager : IReadable<AppTrophyManager>
    {
        public AppTrophyManagerImplWin TrophyManager { get; set; }

        public AppTrophyManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            TrophyManager = pointerFactory.Create<AppTrophyManagerImplWin>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}