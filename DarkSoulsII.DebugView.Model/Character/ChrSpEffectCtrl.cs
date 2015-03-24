using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Character
{
    public class ChrSpEffectCtrl : IReadable<ChrSpEffectCtrl>
    {
        public ChrSpEffectCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}