using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.GameObjects.Target
{
    public class TargetBulletCtrl : TargetCtrl, IReadable<TargetBulletCtrl>
    {
        public new TargetBulletCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}