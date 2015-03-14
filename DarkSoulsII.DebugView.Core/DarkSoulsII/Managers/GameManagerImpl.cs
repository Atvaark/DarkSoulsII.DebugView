using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Ai;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.App;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Bullet;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Character;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Demo;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Event;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Input;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Sign;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers
{
    public class GameManagerImpl : GameManager, IReadable<GameManagerImpl>
    {
        public CharacterManager CharacterManager { get; set; }
        public CameraManager CameraManager { get; set; }
        public AiManager AiManager { get; set; }
        public AppResourceManager ResourceManager { get; set; }
        public MapManager MapManager { get; set; }
        public BulletManager BulletManager { get; set; }
        public EventManager EventManager { get; set; }
        public FaceGenManager FaceGenManager { get; set; }
        public RumbleManager RumbleManager { get; set; }
        public SignManager SignManager { get; set; }
        public GameDataManager GameDataManager { get; set; }
        public PlayerCtrl PlayerControl { get; set; }
        public SaveLoadSystem SaveLoadSystem { get; set; }
        public int Tick { get; set; }
        public AppDecalManager DecalManager { get; set; }
        public DemoManager DemoManager { get; set; }
        public GameManagerState ManagerState { get; set; }

        public new GameManagerImpl Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            
            CharacterManager = Pointer<CharacterManager>.CreateAndUnbox(reader, address + 0x0018, relative);
            CameraManager = Pointer<CameraManager>.CreateAndUnbox(reader, address + 0x001C, relative);
            AiManager = Pointer<AiManager>.CreateAndUnbox(reader, address + 0x0020, relative);
            ResourceManager = Pointer<AppResourceManager>.CreateAndUnbox(reader, address + 0x0024, relative);
            MapManager = Pointer<MapManager>.CreateAndUnbox(reader, address + 0x0028, relative);
            BulletManager = Pointer<BulletManager>.CreateAndUnbox(reader, address + 0x003C, relative);
            EventManager = Pointer<EventManager>.CreateAndUnbox(reader, address + 0x0044, relative);
            FaceGenManager = Pointer<FaceGenManager>.CreateAndUnbox(reader, address + 0x004C, relative);
            RumbleManager = Pointer<RumbleManager>.CreateAndUnbox(reader, address + 0x0050, relative);
            SignManager = Pointer<SignManager>.CreateAndUnbox(reader, address + 0x0054, relative);
            GameDataManager = Pointer<GameDataManager>.CreateAndUnbox(reader, address + 0x0060, relative);
            PlayerControl = Pointer<PlayerCtrl>.CreateAndUnbox(reader, address + 0x0074, relative);
            SaveLoadSystem = Pointer<SaveLoadSystem>.CreateAndUnbox(reader, address + 0x0068, relative);
            Tick = reader.ReadInt32(address + 0x00A4, relative);
            DecalManager = Pointer<AppDecalManager>.CreateAndUnbox(reader, address + 0x0648, relative);
            DemoManager = Pointer<DemoManager>.CreateAndUnbox(reader, address + 0x065C, relative);
            ManagerState = (GameManagerState) reader.ReadInt32(address + 0x0DEC, relative);
            return this;
        }
    }
}
