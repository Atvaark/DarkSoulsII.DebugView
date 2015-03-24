using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Network;

namespace DarkSoulsII.DebugView.Model.Managers.Network
{
    public class NetSvrManager : IReadable<NetSvrManager>
    {
        public NetSvrMemory Memory { get; set; }
        public NetSvrJobRunner JobRunner { get; set; }
        public NetSvrClientInterface ClientInterface { get; set; }
        public NetSvrLoginManager LoginManager { get; set; }
        public NetSvrProperties Properties { get; set; }
        public NetSvrPlayerManager PlayerManager { get; set; }
        public NetSvrSummonSignManager SummonSignManager { get; set; }
        public NetSvrPreviewChrManager PreviewCharacterManager { get; set; }
        public NetSvrBloodMessageManager BloodMessageManager { get; set; }
        public NetSvrBloodstainManager BloodstainManager { get; set; }
        public NetSvrGhostManager GhostManager { get; set; }
        public NetSvrBreakInManager BreakInManager { get; set; }
        public NetSvrVisitorManager VisitorManager { get; set; }
        public NetSvrDuelManager DuelManager { get; set; }
        public NetPlayerWatcher PlayerWatcher { get; set; }

        public NetSvrManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Memory = pointerFactory.Create<NetSvrMemory>(address + 0x002C).Unbox(pointerFactory, reader);
            JobRunner = pointerFactory.Create<NetSvrJobRunner>(address + 0x0030).Unbox(pointerFactory, reader);
            ClientInterface = pointerFactory.Create<NetSvrClientInterface>(address + 0x0034).Unbox(pointerFactory, reader);
            LoginManager = pointerFactory.Create<NetSvrLoginManager>(address + 0x0038).Unbox(pointerFactory, reader);
            Properties = pointerFactory.Create<NetSvrProperties>(address + 0x003C).Unbox(pointerFactory, reader);
            PlayerManager = pointerFactory.Create<NetSvrPlayerManager>(address + 0x0040).Unbox(pointerFactory, reader);
            SummonSignManager = pointerFactory.Create<NetSvrSummonSignManager>(address + 0x0044).Unbox(pointerFactory, reader);
            PreviewCharacterManager = pointerFactory.Create<NetSvrPreviewChrManager>(address + 0x0048).Unbox(pointerFactory, reader);
            BloodMessageManager = pointerFactory.Create<NetSvrBloodMessageManager>(address + 0x004C).Unbox(pointerFactory, reader);
            BloodstainManager = pointerFactory.Create<NetSvrBloodstainManager>(address + 0x0050).Unbox(pointerFactory, reader);
            GhostManager = pointerFactory.Create<NetSvrGhostManager>(address + 0x0054).Unbox(pointerFactory, reader);
            BreakInManager = pointerFactory.Create<NetSvrBreakInManager>(address + 0x0058).Unbox(pointerFactory, reader);
            VisitorManager = pointerFactory.Create<NetSvrVisitorManager>(address + 0x005C).Unbox(pointerFactory, reader);
            DuelManager = pointerFactory.Create<NetSvrDuelManager>(address + 0x0060).Unbox(pointerFactory, reader);
            PlayerWatcher = pointerFactory.Create<NetPlayerWatcher>(address + 0x0068).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
