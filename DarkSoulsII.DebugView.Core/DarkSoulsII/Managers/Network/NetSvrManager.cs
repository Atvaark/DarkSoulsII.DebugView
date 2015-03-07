using DarkSoulsII.DebugView.Core.DarkSoulsII.Network;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
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

        public NetSvrManager Read(IReader reader, int address, bool relative = false)
        {
            Memory = Pointer<NetSvrMemory>.CreateAndUnbox(reader, address + 0x002C);
            JobRunner = Pointer<NetSvrJobRunner>.CreateAndUnbox(reader, address + 0x0030);
            ClientInterface = Pointer<NetSvrClientInterface>.CreateAndUnbox(reader, address + 0x0034);
            LoginManager = Pointer<NetSvrLoginManager>.CreateAndUnbox(reader, address + 0x0038);
            Properties = Pointer<NetSvrProperties>.CreateAndUnbox(reader, address + 0x003C);
            PlayerManager = Pointer<NetSvrPlayerManager>.CreateAndUnbox(reader, address + 0x0040);
            SummonSignManager = Pointer<NetSvrSummonSignManager>.CreateAndUnbox(reader, address + 0x0044);
            PreviewCharacterManager = Pointer<NetSvrPreviewChrManager>.CreateAndUnbox(reader, address + 0x0048);
            BloodMessageManager = Pointer<NetSvrBloodMessageManager>.CreateAndUnbox(reader, address + 0x004C);
            BloodstainManager = Pointer<NetSvrBloodstainManager>.CreateAndUnbox(reader, address + 0x0050);
            GhostManager = Pointer<NetSvrGhostManager>.CreateAndUnbox(reader, address + 0x0054);
            BreakInManager = Pointer<NetSvrBreakInManager>.CreateAndUnbox(reader, address + 0x0058);
            VisitorManager = Pointer<NetSvrVisitorManager>.CreateAndUnbox(reader, address + 0x005C);
            DuelManager = Pointer<NetSvrDuelManager>.CreateAndUnbox(reader, address + 0x0060);
            PlayerWatcher = Pointer<NetPlayerWatcher>.CreateAndUnbox(reader, address + 0x0068);
            return this;
        }
    }
}
