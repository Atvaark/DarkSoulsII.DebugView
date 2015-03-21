namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
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