using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Bullet;
using DarkSoulsII.DebugView.Model.Resources.Param.Bullet;

namespace DarkSoulsII.DebugView.Model.GameObjects.GameEntities
{
    public class BulletObject : BulletObjectBase, IReadable<BulletObject>
    {
        public int Index { get; set; }
        public int BulletParamId1 { get; set; }
        public int BulletParamId2 { get; set; }
        public float Life { get; set; }
        public float MaxLife { get; set; }
        public BulletParam Param { get; set; }
        public BulletMotionBase Motion { get; set; }

        public new BulletObject Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            Index = reader.ReadInt32(address + 0x0010, relative);
            BulletParamId1 = reader.ReadInt32(address + 0x001C, relative);
            BulletParamId2 = reader.ReadInt32(address + 0x001C, relative);
            Life = reader.ReadSingle(address + 0x0028, relative);
            MaxLife = reader.ReadSingle(address + 0x002C, relative);
            Param = pointerFactory.Create<BulletParam>(address + 0x0044, relative).Unbox(pointerFactory, reader);
            Motion = pointerFactory.Create<BulletMotionBase>(address + 0x0048, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}