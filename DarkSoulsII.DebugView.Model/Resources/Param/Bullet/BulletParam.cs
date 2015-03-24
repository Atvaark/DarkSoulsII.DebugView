using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Bullet
{
    public class BulletParam : IReadable<BulletParam>
    {
        public int BulletId { get; set; }
        public byte UnknownFlag4 { get; set; }
        public byte UnknownFlag5 { get; set; }
        public byte UnknownFlag6 { get; set; }
        public byte UnknownFlag7 { get; set; }
        public float FiringDelay { get; set; }
        public float SpreadHorizontal { get; set; }
        public float SpreadVertical { get; set; }
        public float MaxLife { get; set; }
        public float InitialVelocityHorizontal { get; set; }
        public float AccelerationStartDelayHorizontal { get; set; }
        public float TargetVelocityHorizontal { get; set; }
        public float MaxVelocityHorizontal { get; set; }
        public float InitialVelocityVertical { get; set; }
        public float AccelerationStartDelayVertical { get; set; }
        public float TargetVelocityVertical { get; set; }
        public float MaxVelocityVertical { get; set; }
        public float InitialVelocityTangentialVertical { get; set; }
        public float AccelerationDelayTangentialVertical { get; set; }
        public float TargetVelocityTangentialVertical { get; set; }
        public float MaxVelocityTangentialVertical { get; set; }
        public float InitialVelocityTangentialHorizontal { get; set; }
        public float AccelerationDelayTangentialHorizontal { get; set; }
        public float TargetVelocityTangentialHorizontal { get; set; }
        public float MaxVelocityTangentialHorizontal { get; set; }
        public float MaxAngleChange { get; set; }
        public float TrackingMaxAngleChange { get; set; }
        public float TrackingTime { get; set; }
        public byte CollisionCharacter { get; set; }
        public byte CollisionWall { get; set; }
        public byte CollisionFloorCeiling { get; set; }
        public byte CollisionWater { get; set; }
        public int EffectOnFire { get; set; }
        public int BehaviorOnCollision { get; set; }
        public int ChildBullet1Id1 { get; set; }
        public int ChildBullet1Id2 { get; set; }
        public int ChildBullet2Id1 { get; set; }
        public int ChildBullet2Id2 { get; set; }
        public int ChildBullet3Id1 { get; set; }
        public int ChildBullet3Id2 { get; set; }
        public bool SpawnChildBulletsOnCollision { get; set; }
        public bool SpawnChildBulletsOnTimeout { get; set; }
        public bool SpawnChildBulletsOnUnknown { get; set; }
        public bool SpawnChildBulletsOnAlive { get; set; }
        public float Distance { get; set; }

        public BulletParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            BulletId = reader.ReadInt32(address + 0x0000, relative);

            UnknownFlag4 = reader.ReadByte(address + 0x0004, relative);
            UnknownFlag5 = reader.ReadByte(address + 0x0005, relative);
            UnknownFlag6 = reader.ReadByte(address + 0x0006, relative);
            UnknownFlag7 = reader.ReadByte(address + 0x0007, relative);

            FiringDelay = reader.ReadSingle(address + 0x0038, relative);
            SpreadHorizontal = reader.ReadSingle(address + 0x003C, relative);
            SpreadVertical = reader.ReadSingle(address + 0x0040, relative);
            MaxLife = reader.ReadSingle(address + 0x0048, relative);

            InitialVelocityHorizontal = reader.ReadSingle(address + 0x004C, relative);
            AccelerationStartDelayHorizontal = reader.ReadSingle(address + 0x0050, relative);
            TargetVelocityHorizontal = reader.ReadSingle(address + 0x0054, relative);
            MaxVelocityHorizontal = reader.ReadSingle(address + 0x0058, relative);

            InitialVelocityVertical = reader.ReadSingle(address + 0x005C, relative);
            AccelerationStartDelayVertical = reader.ReadSingle(address + 0x0060, relative);
            TargetVelocityVertical = reader.ReadSingle(address + 0x0064, relative);
            MaxVelocityVertical = reader.ReadSingle(address + 0x0068, relative);

            InitialVelocityTangentialVertical = reader.ReadSingle(address + 0x006C, relative);
            AccelerationDelayTangentialVertical = reader.ReadSingle(address + 0x0070, relative);
            TargetVelocityTangentialVertical = reader.ReadSingle(address + 0x0074, relative);
            MaxVelocityTangentialVertical = reader.ReadSingle(address + 0x0078, relative);

            InitialVelocityTangentialHorizontal = reader.ReadSingle(address + 0x007C, relative);
            AccelerationDelayTangentialHorizontal = reader.ReadSingle(address + 0x0080, relative);
            TargetVelocityTangentialHorizontal = reader.ReadSingle(address + 0x0084, relative);
            MaxVelocityTangentialHorizontal = reader.ReadSingle(address + 0x0088, relative);

            MaxAngleChange = reader.ReadSingle(address + 0x0090, relative);
            TrackingMaxAngleChange = reader.ReadSingle(address + 0x0094, relative);
            TrackingTime = reader.ReadSingle(address + 0x0098, relative);

            CollisionCharacter = reader.ReadByte(address + 0x00B0, relative);
            CollisionWall = reader.ReadByte(address + 0x00B1, relative);
            CollisionFloorCeiling = reader.ReadByte(address + 0x00B2, relative);
            CollisionWater = reader.ReadByte(address + 0x00B3, relative);

            EffectOnFire = reader.ReadInt32(address + 0x00B4, relative);
            BehaviorOnCollision = reader.ReadInt32(address + 0x00CC, relative);

            ChildBullet1Id1 = reader.ReadInt32(address + 0x00D4, relative);
            ChildBullet1Id2 = reader.ReadInt32(address + 0x00D8, relative);
            ChildBullet2Id1 = reader.ReadInt32(address + 0x00DC, relative);
            ChildBullet2Id2 = reader.ReadInt32(address + 0x00E0, relative);
            ChildBullet3Id1 = reader.ReadInt32(address + 0x00E4, relative);
            ChildBullet3Id2 = reader.ReadInt32(address + 0x00E8, relative);

            SpawnChildBulletsOnCollision = reader.ReadBoolean(address + 0x00EC, relative);
            SpawnChildBulletsOnTimeout = reader.ReadBoolean(address + 0x00ED, relative);
            SpawnChildBulletsOnUnknown = reader.ReadBoolean(address + 0x00EE, relative);
            SpawnChildBulletsOnAlive = reader.ReadBoolean(address + 0x00EF, relative);

            Distance = reader.ReadSingle(address + 0x0124, relative);
            return this;
        }

    }
}