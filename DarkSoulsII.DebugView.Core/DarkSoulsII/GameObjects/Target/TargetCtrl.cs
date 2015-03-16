namespace DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.Target
{
    public class TargetCtrl : GameObject, IReadable<TargetCtrl>
    {

        public new TargetCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }

    }
}