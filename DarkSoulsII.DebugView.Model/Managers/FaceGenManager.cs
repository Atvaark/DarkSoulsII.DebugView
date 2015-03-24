using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers
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
