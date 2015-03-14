namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Area
{
    public class MapChameleonAreaData : IReadable<MapChameleonAreaData>
    {
        public int ChameleonId { get; set; }
        public int ChameleonIndex { get; set; }
        public int ModelId1 { get; set; }
        public int ModelId2 { get; set; }
        public int ModelId3 { get; set; }
        public int ModelId4 { get; set; }
        public byte RolledId1Flag { get; set; }
        public byte RolledId2Flag { get; set; }
        public byte RolledId3Flag { get; set; }
        public byte RolledId4Flag { get; set; }

        public static int Size
        {
            get { return 28; }
        }

        public MapChameleonAreaData Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ChameleonId = reader.ReadInt32(address + 0x0000, relative);
            ChameleonIndex = reader.ReadInt32(address + 0x0004, relative);
            ModelId1 = reader.ReadInt32(address + 0x0008, relative);
            ModelId2 = reader.ReadInt32(address + 0x000C, relative);
            ModelId3 = reader.ReadInt32(address + 0x0010, relative);
            ModelId4 = reader.ReadInt32(address + 0x0014, relative);
            RolledId1Flag = reader.ReadByte(address + 0x0018, relative);
            RolledId2Flag = reader.ReadByte(address + 0x0019, relative);
            RolledId3Flag = reader.ReadByte(address + 0x001A, relative);
            RolledId4Flag = reader.ReadByte(address + 0x001B, relative);

            return this;
        }
    }
}
