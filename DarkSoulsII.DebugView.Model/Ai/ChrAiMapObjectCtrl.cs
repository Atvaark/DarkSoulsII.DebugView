using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Ai
{
    public class ChrAiMapObjectCtrl : IReadable<ChrAiMapObjectCtrl>
    {
        public ChrAiMapObjectCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}