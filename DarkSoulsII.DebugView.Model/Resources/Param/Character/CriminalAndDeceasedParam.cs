using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class CriminalAndDeceasedParam : IReadable<CriminalAndDeceasedParam>
    {
        public CriminalAndDeceasedParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
