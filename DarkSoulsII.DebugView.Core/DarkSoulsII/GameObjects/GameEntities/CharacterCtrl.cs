using System;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Character;
using DarkSoulsII.DebugView.Core.Standard;
using DarkSoulsII.DebugView.Core.Standard.Templates;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities
{
    public class CharacterCtrl : CharacterCtrlBase, IReadable<CharacterCtrl>
    {
        public double AngleY { get; set; }
        public Vector3 Position { get; set; }
        public int Health { get; set; }
        public int HealthMaxHuman { get; set; }
        public int HealthMaxHollow { get; set; }
        public float Stamina { get; set; }
        public float StaminaMax { get; set; }
        public float Petrification { get; set; }
        public float PetrificationMax { get; set; }
        public float Poison { get; set; }
        public float PoisonMax { get; set; }
        public ChrAsmCtrl AsmControl { get; set; }

        public new CharacterCtrl Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);

            // TODO: Maybe it's a quarternion?
            var angleYFlag = reader.ReadUInt32(address + 0x0058, relative);
            var cosineY = reader.ReadSingle(address + 0x0068, relative);
            var angleY = Math.Acos(cosineY)*180.0/Math.PI;
            AngleY = (angleYFlag & 0x80000000) > 0 ? 360 - angleY : angleY;

            Position = Pointer<Vector3>.Create(address + 0x0070).Unbox(reader);

            Name = Pointer<StdString>.Create(address + 0x00C8).Unbox(reader).Value;

            Health = reader.ReadInt32(address + 0x00FC);
            HealthMaxHuman = reader.ReadInt32(address + 0x0104);
            HealthMaxHollow = reader.ReadInt32(address + 0x0108);
            Stamina = reader.ReadSingle(address + 0x0140);
            StaminaMax = reader.ReadSingle(address + 0x0148);

            Petrification = reader.ReadSingle(address + 0x014A);
            PetrificationMax = reader.ReadSingle(address + 0x01A8);
            Poison = reader.ReadSingle(address + 0x01AC);
            PoisonMax = reader.ReadSingle(address + 0x01B4);


            AsmControl = Pointer<ChrAsmCtrl>.CreateAndUnbox(reader, address + 0x2D4);

            return this;
        }

        public override string ToString()
        {
            return string.Format("{0} HP: {1}/{2} Stamina: {3:F1}/{4:F1} Position: {5}, Angle = {6:F1}", Name, Health,
                HealthMaxHuman, Stamina, StaminaMax, Position, AngleY);
        }
    }
}
