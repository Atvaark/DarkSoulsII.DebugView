namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Model
{
    public class AppFlverModelCtrl : ModelCtrl, IReadable<AppFlverModelCtrl>
    {
        public new AppFlverModelCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}