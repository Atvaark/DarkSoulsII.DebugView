using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Resources.Param.Sign;

namespace DarkSoulsII.DebugView.Model.Sign
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