namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Bullet
{
    public class BulletAttachMotion : BulletMotionBase, IReadable<BulletAttachMotion>
    {
        public new BulletAttachMotion Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}