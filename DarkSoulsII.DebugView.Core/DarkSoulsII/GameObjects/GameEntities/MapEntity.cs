using DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Area;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities
{
    public class MapEntity : GameEntity, IReadable<MapEntity>
    {
        public MapAreaCtrlOwner Owner { get; set; }

        public new MapEntity Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            Owner = Pointer<MapAreaCtrlOwner>.CreateAndUnbox(reader, address + 0x0014, relative);

            short type1 = reader.ReadInt16(address + 0x0078, relative);
            short type2 = reader.ReadInt16(address + 0x007A, relative);

            return this;
        }
    }
}
