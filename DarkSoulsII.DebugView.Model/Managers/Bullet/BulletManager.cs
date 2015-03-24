using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.GameObjects.GameEntities;
using DarkSoulsII.DebugView.Model.Standard;

namespace DarkSoulsII.DebugView.Model.Managers.Bullet
{
    public class BulletManager : IReadable<BulletManager>
    {
        public StdVector<BulletObject> Bullets { get; set; }

        public BulletManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Maybe read the Vector back to front to prevent reading the last entry from failing
            Bullets = pointerFactory.Create<StdVector<BulletObject>>(address + 0x0000, relative, true).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
