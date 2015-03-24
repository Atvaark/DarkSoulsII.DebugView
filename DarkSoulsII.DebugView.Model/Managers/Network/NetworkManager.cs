using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Network
{
    public class NetworkManager : IReadable<NetworkManager>
    {
        public NetSessionManager SessionManager { get; set; }
        public NetSyncDataManager SyncDataManager { get; set; }
        public NetSummonSlotManager SummonSlotManager { get; set; }
        public NetEnemyManager EnemyManager { get; set; }
        public NetSvrManager ServerManager { get; set; }
        public NetSvrStateChartManager ServerStateChartManager { get; set; }
        public NetParamContainer ParamContainer { get; set; }

        public NetworkManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SessionManager = pointerFactory.Create<NetSessionManager>(address + 0x0000).Unbox(pointerFactory, reader);
            SyncDataManager = pointerFactory.Create<NetSyncDataManager>(address + 0x0008).Unbox(pointerFactory, reader);

            SummonSlotManager = pointerFactory.Create<NetSummonSlotManager>(address + 0x0010).Unbox(pointerFactory, reader);
            EnemyManager = pointerFactory.Create<NetEnemyManager>(address + 0x0014).Unbox(pointerFactory, reader);
            ServerManager = pointerFactory.Create<NetSvrManager>(address + 0x0018).Unbox(pointerFactory, reader);
            ServerStateChartManager = pointerFactory.Create<NetSvrStateChartManager>(address + 0x001C).Unbox(pointerFactory, reader);
            ParamContainer = pointerFactory.Create<NetParamContainer>(address + 0x0020).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
