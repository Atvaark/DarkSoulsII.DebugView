using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Network
{
    public class NetSvrPreviewChrManager : IReadable<NetSvrPreviewChrManager>
    {
        public NetSvrPreviewChrManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
