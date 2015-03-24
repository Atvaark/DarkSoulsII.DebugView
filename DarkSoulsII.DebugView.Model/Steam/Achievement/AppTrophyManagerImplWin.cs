using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Steam.Achievement
{
    public class AppTrophyManagerImplWin : IReadable<AppTrophyManagerImplWin>
    {
        public List<AppTrophy> Trophies { get; set; }

        public AppTrophyManagerImplWin()
        {
            Trophies = new List<AppTrophy>();
        }

        public AppTrophyManagerImplWin Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int trophyListAddress = reader.ReadInt32(address + 0x0008, relative);
            Trophies = pointerFactory
                .CreateArrayDereferenced<AppTrophy>(trophyListAddress, false, 38)
                .Select(p => p.Unbox(pointerFactory, reader))
                .ToList();

            return this;
        }

    }
}