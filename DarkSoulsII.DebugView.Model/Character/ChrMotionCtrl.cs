using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Morpheme;

namespace DarkSoulsII.DebugView.Model.Character
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