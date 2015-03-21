using DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Character
{
    public class ChrMotionCtrl : IReadable<ChrMotionCtrl>
    {
        public MorphemeMotionCtrl MorphemeMotionCtrl { get; set; }

        public ChrMotionCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            MorphemeMotionCtrl = pointerFactory.Create<MorphemeMotionCtrl>(address + 0x0028, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}