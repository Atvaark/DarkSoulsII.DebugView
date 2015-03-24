using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Resources.Param.Sign;

namespace DarkSoulsII.DebugView.Model.Sign
{
    public class BloodstainSetCtrl : SignSetCommonCtrl<BloodstainParam>, IReadable<BloodstainSetCtrl>
    {
        public new BloodstainSetCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}