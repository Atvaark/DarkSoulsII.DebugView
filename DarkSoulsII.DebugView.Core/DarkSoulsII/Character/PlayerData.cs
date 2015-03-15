namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Character
{
    public class PlayerData : IReadable<PlayerData>
    {
        public byte Sins { get; set; }
        public short Vitality { get; set; }
        public short Endurance { get; set; }
        public short Vigor { get; set; }
        public short Attunement { get; set; }
        public short Strength { get; set; }
        public short Dexterity { get; set; }
        public short Intelligence { get; set; }
        public short Faith { get; set; }
        public short Adaptability { get; set; }
        public float Stamina { get; set; }
        public float EquipWeightMax { get; set; }
        public int SoulLevel { get; set; }
        public int Souls { get; set; }
        public int SoulMemory { get; set; }
        public int DeathCount { get; set; }
        public byte HollowState { get; set; }
        public short HeirsOfTheSunStanding { get; set; }
        public short BlueSentinelsStanding { get; set; }
        public short BrotherhoodOfBloodStanding { get; set; }
        public short WayOfBlueStanding { get; set; }
        public short RatKingStanding { get; set; }
        public short BellkeepersStanding { get; set; }
        public short DragonRemnantsStanding { get; set; }
        public short CompanyOfChampionsStanding { get; set; }
        public short PilgrimsOfTheDarkStanding { get; set; }

        public PlayerData Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Vitality = reader.ReadInt16(address + 0x0004);
            Endurance = reader.ReadInt16(address + 0x0006);
            Vigor = reader.ReadInt16(address + 0x0008);
            Attunement = reader.ReadInt16(address + 0x000A);
            Strength = reader.ReadInt16(address + 0x000C);
            Dexterity = reader.ReadInt16(address + 0x000E);
            Intelligence = reader.ReadInt16(address + 0x0010);
            Faith = reader.ReadInt16(address + 0x0012);
            Adaptability = reader.ReadInt16(address + 0x0014);

            Stamina = reader.ReadSingle(address + 0x0034);
            EquipWeightMax = reader.ReadSingle(address + 0x0038);
            SoulLevel = reader.ReadInt32(address + 0x00CC);
            Souls = reader.ReadInt32(address + 0x00E8);
            SoulMemory = reader.ReadInt32(address + 0x00F0);
            DeathCount = reader.ReadInt32(address + 0x01A0);
            HollowState = reader.ReadByte(address + 0x01A8);

            HeirsOfTheSunStanding = reader.ReadInt16(address + 0x01C0);
            BlueSentinelsStanding = reader.ReadInt16(address + 0x01C2);
            BrotherhoodOfBloodStanding = reader.ReadInt16(address + 0x01C4);
            WayOfBlueStanding = reader.ReadInt16(address + 0x01C6);
            RatKingStanding = reader.ReadInt16(address + 0x01C8);
            BellkeepersStanding = reader.ReadInt16(address + 0x01CA);
            DragonRemnantsStanding = reader.ReadInt16(address + 0x01CC);
            CompanyOfChampionsStanding = reader.ReadInt16(address + 0x01CE);
            PilgrimsOfTheDarkStanding = reader.ReadInt16(address + 0x01D0);
            Sins = reader.ReadByte(address + 0x01D3);
            return this;
        }
    }
}
