namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetParamContainer : IReadable<NetParamContainer>
    {
        public NetParamContainer Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
