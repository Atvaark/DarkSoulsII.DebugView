using DarkSoulsII.DebugView.Core.DarkSoulsII.Character.Equipment;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Character
{
    public class ChrAsmCtrlEquipment : IReadable<ChrAsmCtrlEquipment>
    {
        public float Weight { get; set; }
        public float WeightPercentage { get; set; }
        public ChrAsmCtrlEquipmentWeapon WeaponLeft1 { get; set; }
        public ChrAsmCtrlEquipmentWeapon WeaponLeft2 { get; set; }
        public ChrAsmCtrlEquipmentWeapon WeaponLeft3 { get; set; }
        public ChrAsmCtrlEquipmentWeapon WeaponRight1 { get; set; }
        public ChrAsmCtrlEquipmentWeapon WeaponRight2 { get; set; }
        public ChrAsmCtrlEquipmentWeapon WeaponRight3 { get; set; }
        public ChrAsmCtrlEquipmentArmor Head { get; set; }
        public ChrAsmCtrlEquipmentArmor Chest { get; set; }
        public ChrAsmCtrlEquipmentArmor Hands { get; set; }
        public ChrAsmCtrlEquipmentArmor Legs { get; set; }
        public ChrAsmCtrlEquipmentAmmo Arrows1 { get; set; }
        public ChrAsmCtrlEquipmentAmmo Arrows2 { get; set; }
        public ChrAsmCtrlEquipmentAmmo Bolts1 { get; set; }
        public ChrAsmCtrlEquipmentAmmo Bolts2 { get; set; }
        public ChrAsmCtrlEquipmentRing Ring1 { get; set; }
        public ChrAsmCtrlEquipmentRing Ring2 { get; set; }
        public ChrAsmCtrlEquipmentRing Ring3 { get; set; }
        public ChrAsmCtrlEquipmentRing Ring4 { get; set; }

        public ChrAsmCtrlEquipment Read(IReader reader, int address, bool relative = false)
        {
            Weight = reader.ReadSingle(address + 0x003C);
            WeightPercentage = reader.ReadSingle(address + 0x0040);

            WeaponLeft1 = Pointer<ChrAsmCtrlEquipmentWeapon>.Create(address + 0x0044, relative).Unbox(reader);
            WeaponLeft2 = Pointer<ChrAsmCtrlEquipmentWeapon>.Create(address + 0x0070, relative).Unbox(reader);
            WeaponLeft3 = Pointer<ChrAsmCtrlEquipmentWeapon>.Create(address + 0x009C, relative).Unbox(reader);
            WeaponRight1 = Pointer<ChrAsmCtrlEquipmentWeapon>.Create(address + 0x00C8, relative).Unbox(reader);
            WeaponRight2 = Pointer<ChrAsmCtrlEquipmentWeapon>.Create(address + 0x00F4, relative).Unbox(reader);
            WeaponRight3 = Pointer<ChrAsmCtrlEquipmentWeapon>.Create(address + 0x0120, relative).Unbox(reader);

            Head = Pointer<ChrAsmCtrlEquipmentArmor>.Create(address + 0x02F4, relative).Unbox(reader);
            Chest = Pointer<ChrAsmCtrlEquipmentArmor>.Create(address + 0x0310, relative).Unbox(reader);
            Hands = Pointer<ChrAsmCtrlEquipmentArmor>.Create(address + 0x032C, relative).Unbox(reader);
            Legs = Pointer<ChrAsmCtrlEquipmentArmor>.Create(address + 0x0348, relative).Unbox(reader);

            Arrows1 = Pointer<ChrAsmCtrlEquipmentAmmo>.Create(address + 0x036C, relative).Unbox(reader);
            Arrows2 = Pointer<ChrAsmCtrlEquipmentAmmo>.Create(address + 0x0378, relative).Unbox(reader);
            Bolts1 = Pointer<ChrAsmCtrlEquipmentAmmo>.Create(address + 0x0384, relative).Unbox(reader);
            Bolts2 = Pointer<ChrAsmCtrlEquipmentAmmo>.Create(address + 0x0390, relative).Unbox(reader);

            Ring1 = Pointer<ChrAsmCtrlEquipmentRing>.Create(address + 0x0408, relative).Unbox(reader);
            Ring2 = Pointer<ChrAsmCtrlEquipmentRing>.Create(address + 0x0414, relative).Unbox(reader);
            Ring3 = Pointer<ChrAsmCtrlEquipmentRing>.Create(address + 0x0420, relative).Unbox(reader);
            Ring4 = Pointer<ChrAsmCtrlEquipmentRing>.Create(address + 0x042C, relative).Unbox(reader);

            return this;
        }
    }
}
