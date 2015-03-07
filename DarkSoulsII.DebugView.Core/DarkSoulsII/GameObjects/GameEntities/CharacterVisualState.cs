namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities
{
    public class CharacterVisualState : IReadable<CharacterVisualState>
    {
        public CharacterGlowEffectType GlowEffectType { get; set; }
        public byte Collison { get; set; }
        public byte Hostility1 { get; set; }
        public byte Hostility2 { get; set; }
        public byte Hostility3 { get; set; }

        public CharacterVisualState Read(IReader reader, int address, bool relative = false)
        {
            GlowEffectType = (CharacterGlowEffectType) reader.ReadInt32(address + 0x0038);
            Collison = reader.ReadByte(address + 0x003C);
            Hostility1 = reader.ReadByte(address + 0x003D);
            Hostility2 = reader.ReadByte(address + 0x003E);
            Hostility3 = reader.ReadByte(address + 0x003F);

            return this;
        }
    }
}
