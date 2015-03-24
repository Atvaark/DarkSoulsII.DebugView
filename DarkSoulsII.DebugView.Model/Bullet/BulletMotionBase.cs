using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Standard;

namespace DarkSoulsII.DebugView.Model.Bullet
{
    public class BulletMotionBase : IReadable<BulletMotionBase>
    {
        public Vector3 Rotation { get; set; }
        public Vector3 Position { get; set; }
        public Vector3 Velocity { get; set; }

        public BulletMotionBase Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Is it actually a quaternion?
            Rotation = pointerFactory.Create<Vector3>(address + 0x0030, relative, true).Unbox(pointerFactory, reader);

            Position = pointerFactory.Create<Vector3>(address + 0x0050, relative, true).Unbox(pointerFactory, reader);
            
            Velocity = pointerFactory.Create<Vector3>(address + 0x0080, relative, true).Unbox(pointerFactory, reader);
            return this;
        }

    }
}