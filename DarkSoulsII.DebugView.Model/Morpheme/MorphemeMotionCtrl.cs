using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Morpheme
{
    public class MorphemeMotionCtrl : IReadable<MorphemeMotionCtrl>
    {
        public MorphemeSkeletonMapper SkeletonMapper { get; set; }
        public MorphemeChrCtrl ChrCtrl { get; set; }
        public MorphemeEventTrackCtrl EventTrackCtrl { get; set; }

        public MorphemeMotionCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SkeletonMapper = pointerFactory.Create<MorphemeSkeletonMapper>(address + 0x0014, relative).Unbox(pointerFactory, reader);
            ChrCtrl = pointerFactory.Create<MorphemeChrCtrl>(address + 0x0018, relative).Unbox(pointerFactory, reader);
            EventTrackCtrl = pointerFactory.Create<MorphemeEventTrackCtrl>(address + 0x001C, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}