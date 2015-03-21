using DarkSoulsII.DebugView.Core.Standard;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme
{
    public class MorphemeChrCtrl : IReadable<MorphemeChrCtrl>
    {
        public Vector3 Position { get; set; }
        public Quaternion Rotation { get; set; }
        public bool StandingStill { get; set; }

        public MorphemeChrCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Position = pointerFactory.Create<Vector3>(address + 0x0020, relative, true).Unbox(pointerFactory, reader);
            Rotation = pointerFactory.Create<Quaternion>(address + 0x0030, relative, true).Unbox(pointerFactory, reader);
            StandingStill = reader.ReadBoolean(address + 0x0060, relative);
            return this;
        }

    }
}