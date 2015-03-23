namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionBossDamage : MorphemeEventTrackAction, IReadable<ChrEventTrackActionBossDamage>
    {
        public new ChrEventTrackActionBossDamage Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}