using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities;
using DarkSoulsII.DebugView.Core.Standard;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Controllers
{
    public class ActiveSignCtrl : IReadable<ActiveSignCtrl>
    {
        public const int Size = 60;
        public Vector3 Position { get; set; }
        public SignKeyGuideEntity SignKeyGuideEntity { get; set; }
        public SignKeyGuideCtrl SignKeyGuideCtrl { get; set; }

        public ActiveSignCtrl Read(IReader reader, int address, bool relative = false)
        {
            int coordinateType = reader.ReadInt32(address + 0x0004, relative);
            // coordinateType = 0 => 000C points to another ActiveSignCtrl
            Position = coordinateType == 3
                ? Pointer<Vector3>.Create(address + 0x0008, relative).Unbox(reader)
                : new Vector3();
            // GlowEffect 001C 

            SignKeyGuideEntity = Pointer<SignKeyGuideEntity>.CreateAndUnbox(reader, address + 0x0034, relative);
            SignKeyGuideCtrl = Pointer<SignKeyGuideCtrl>.CreateAndUnbox(reader, address + 0x0038, relative);

            return this;
        }
    }
}
