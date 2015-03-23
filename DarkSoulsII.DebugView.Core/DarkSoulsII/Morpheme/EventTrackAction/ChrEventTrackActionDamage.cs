namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionDamage : MorphemeEventTrackAction, IReadable<ChrEventTrackActionDamage>
    {
        public new ChrEventTrackActionDamage Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}