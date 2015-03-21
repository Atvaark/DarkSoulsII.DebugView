namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Morpheme.EventTrackAction
{
    public class ChrEventTrackActionTimeAct : MorphemeEventTrackAction, IReadable<ChrEventTrackActionTimeAct>
    {
        public new ChrEventTrackActionTimeAct Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}