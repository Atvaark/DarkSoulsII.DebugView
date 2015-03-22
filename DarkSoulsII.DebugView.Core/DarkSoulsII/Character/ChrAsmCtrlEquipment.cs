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

        public ChrAsmCtrlEquipment Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Weight = reader.ReadSingle(address + 0x003C);
            WeightPercentage = reader.ReadSingle(address + 0x0040);

            WeaponLeft1 = pointerFactory.Create<ChrAsmCtrlEquipmentWeapon>(address + 0x0044, relative, true).Unbox(pointerFactory, reader);
            WeaponLeft2 = pointerFactory.Create<ChrAsmCtrlEquipmentWeapon>(address + 0x0070, relative, true).Unbox(pointerFactory, reader);
            WeaponLeft3 = pointerFactory.Create<ChrAsmCtrlEquipmentWeapon>(address + 0x009C, relative, true).Unbox(pointerFactory, reader);
            WeaponRight1 = pointerFactory.Create<ChrAsmCtrlEquipmentWeapon>(address + 0x00C8, relative, true).Unbox(pointerFactory, reader);
            WeaponRight2 = pointerFactory.Create<ChrAsmCtrlEquipmentWeapon>(address + 0x00F4, relative, true).Unbox(pointerFactory, reader);
            WeaponRight3 = pointerFactory.Create<ChrAsmCtrlEquipmentWeapon>(address + 0x0120, relative, true).Unbox(pointerFactory, reader);

            Head = pointerFactory.Create<ChrAsmCtrlEquipmentArmor>(address + 0x01A4, relative, true).Unbox(pointerFactory, reader);
            Chest = pointerFactory.Create<ChrAsmCtrlEquipmentArmor>(address + 0x01C0, relative, true).Unbox(pointerFactory, reader);
            Hands = pointerFactory.Create<ChrAsmCtrlEquipmentArmor>(address + 0x01DC, relative, true).Unbox(pointerFactory, reader);
            Legs = pointerFactory.Create<ChrAsmCtrlEquipmentArmor>(address + 0x01F8, relative, true).Unbox(pointerFactory, reader);

            Arrows1 = pointerFactory.Create<ChrAsmCtrlEquipmentAmmo>(address + 0x021C, relative, true).Unbox(pointerFactory, reader);
            Arrows2 = pointerFactory.Create<ChrAsmCtrlEquipmentAmmo>(address + 0x0228, relative, true).Unbox(pointerFactory, reader);
            Bolts1 = pointerFactory.Create<ChrAsmCtrlEquipmentAmmo>(address + 0x0234, relative, true).Unbox(pointerFactory, reader);
            Bolts2 = pointerFactory.Create<ChrAsmCtrlEquipmentAmmo>(address + 0x0240, relative, true).Unbox(pointerFactory, reader);

            Ring1 = pointerFactory.Create<ChrAsmCtrlEquipmentRing>(address + 0x0258, relative, true).Unbox(pointerFactory, reader);
            Ring2 = pointerFactory.Create<ChrAsmCtrlEquipmentRing>(address + 0x0264, relative, true).Unbox(pointerFactory, reader);
            Ring3 = pointerFactory.Create<ChrAsmCtrlEquipmentRing>(address + 0x0270, relative, true).Unbox(pointerFactory, reader);
            Ring4 = pointerFactory.Create<ChrAsmCtrlEquipmentRing>(address + 0x027C, relative, true).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
