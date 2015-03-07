namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
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

        public NetworkManager Read(IReader reader, int address, bool relative = false)
        {
            SessionManager = Pointer<NetSessionManager>.CreateAndUnbox(reader, address + 0x0000);
            SyncDataManager = Pointer<NetSyncDataManager>.CreateAndUnbox(reader, address + 0x0008);

            SummonSlotManager = Pointer<NetSummonSlotManager>.CreateAndUnbox(reader, address + 0x0010);
            EnemyManager = Pointer<NetEnemyManager>.CreateAndUnbox(reader, address + 0x0014);
            ServerManager = Pointer<NetSvrManager>.CreateAndUnbox(reader, address + 0x0018);
            ServerStateChartManager = Pointer<NetSvrStateChartManager>.CreateAndUnbox(reader, address + 0x001C);
            ParamContainer = Pointer<NetParamContainer>.CreateAndUnbox(reader, address + 0x0020);
            return this;
        }
    }
}
