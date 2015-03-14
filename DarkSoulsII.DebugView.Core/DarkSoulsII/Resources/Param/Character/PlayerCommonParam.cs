namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Character
{
    public class PlayerCommonParam : IReadable<PlayerCommonParam>
    {
        public PlayerCommonParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
