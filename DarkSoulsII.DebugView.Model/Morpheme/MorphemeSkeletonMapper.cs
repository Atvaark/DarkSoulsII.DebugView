using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Model;

namespace DarkSoulsII.DebugView.Model.Morpheme
{
    public class MorphemeSkeletonMapper : IReadable<MorphemeSkeletonMapper>
    {
        public MdlSkeleton Skeleton { get; set; }

        public MorphemeSkeletonMapper Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Skeleton = pointerFactory.Create<MdlSkeleton>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}