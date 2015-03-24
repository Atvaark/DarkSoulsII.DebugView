using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionAttackStagger : MorphemeEventTrackAction, IReadable<ChrEventTrackActionAttackStagger>
    {
        public new ChrEventTrackActionAttackStagger Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}