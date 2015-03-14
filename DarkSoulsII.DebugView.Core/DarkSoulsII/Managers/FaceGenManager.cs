namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers
{
    public class FaceGenManager : IReadable<FaceGenManager>
    {
        public FaceGenManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Add FaceGenParamContainer  00B0
            return this;
        }
    }
}
