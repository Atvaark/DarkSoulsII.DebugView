namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionBossExtraMotion : MorphemeEventTrackAction, IReadable<ChrEventTrackActionBossExtraMotion>
    {
        public new ChrEventTrackActionBossExtraMotion Read(IPointerFactory pointerFactory, IReader reader, int address,
            bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}