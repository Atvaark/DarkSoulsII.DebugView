using DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Sign;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Sign
{
    public class SummonSignSetCtrl : SignSetCommonCtrl<SummonSignParam>, IReadable<SummonSignSetCtrl>
    {
        public new SummonSignSetCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}