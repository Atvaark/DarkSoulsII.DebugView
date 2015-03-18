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
        public CharacterVisualState VisualState { get; set; }
        public int Health { get; set; }
        public int HealthMaxHuman { get; set; }
        public int HealthMaxHollow { get; set; }
        public float Stamina { get; set; }
        public float StaminaMax { get; set; }
        public float Petrification { get; set; }
        public float PetrificationMax { get; set; }
        public float Poison { get; set; }
        public float PoisonMax { get; set; }
        public float SpeedFactor { get; set; }
        public ChrAsmCtrl AsmControl { get; set; }

        public new CharacterCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);

            // TODO: Maybe it's a quaternion?
            var angleYFlag = reader.ReadUInt32(address + 0x0058, relative);
            var cosineY = reader.ReadSingle(address + 0x0068, relative);
            var angleY = Math.Acos(cosineY)*180.0/Math.PI;
            AngleY = (angleYFlag & 0x80000000) > 0 ? 360 - angleY : angleY;

            Position = pointerFactory.Create<Vector3>(address + 0x0070, relative, true).Unbox(pointerFactory, reader);

            VisualState = pointerFactory.Create<CharacterVisualState>(address + 0x0090, relative).Unbox(pointerFactory, reader);

            Name = pointerFactory.Create<StdWstring>(address + 0x00C8, relative, true).Unbox(pointerFactory, reader).Value;

            Health = reader.ReadInt32(address + 0x00FC, relative);
            HealthMaxHuman = reader.ReadInt32(address + 0x0104, relative);
            HealthMaxHollow = reader.ReadInt32(address + 0x0108, relative);
            Stamina = reader.ReadSingle(address + 0x0140, relative);
            StaminaMax = reader.ReadSingle(address + 0x0148, relative);

            Petrification = reader.ReadSingle(address + 0x014A, relative);
            PetrificationMax = reader.ReadSingle(address + 0x01A8, relative);
            Poison = reader.ReadSingle(address + 0x01AC, relative);
            PoisonMax = reader.ReadSingle(address + 0x01B4, relative);
            SpeedFactor = reader.ReadSingle(address + 0x0208, relative);

            AsmControl = pointerFactory.Create<ChrAsmCtrl>(address + 0x2D4, relative).Unbox(pointerFactory, reader);
            return this;
        }

        public override string ToString()
        {
            return string.Format("{0} HP: {1}/{2} Stamina: {3:F1}/{4:F1} Position: {5}, Angle = {6:F1}", Name, Health,
                HealthMaxHuman, Stamina, StaminaMax, Position, AngleY);
        }
    }
}
