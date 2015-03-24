using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Bullet
{
    public class BulletShotMotion : BulletMotionBase, IReadable<BulletShotMotion>
    {
        public new BulletShotMotion Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}