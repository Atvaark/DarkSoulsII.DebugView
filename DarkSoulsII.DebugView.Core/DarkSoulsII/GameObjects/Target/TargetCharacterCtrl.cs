namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.Target
{
    public class TargetCharacterCtrl : TargetCtrl, IReadable<TargetCharacterCtrl>
    {
        /// <summary>
        /// Key & 0x7F = +0x002C at CharacterCtrl
        /// </summary>
        public int Key { get; set; }
        public int Unknown { get; set; }

        public new TargetCharacterCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            Key = reader.ReadInt32(address + 0x0010, relative);
            Unknown = reader.ReadInt32(address + 0x001C, relative);
            return this;
        }
    }
}