using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Core.DarkSoulsII.App;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Text;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Steam;

namespace DarkSoulsII.DebugView.Test
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Process process = GetProcess("DarkSoulsII");
            IReader reader = MemoryReader.Create(process);
            ICachingPointerFactory pointerFactory = new CachingPointerProxyFactory(reader);
            var gameManagerImplPointer = GetPointer<GameManagerImpl>(pointerFactory, reader, 0x011593F4);
            var networkManagerPointer = GetPointer<NetworkManager>(pointerFactory, reader, 0x0115A5B4);
            var katanaMainAppPointer = GetPointer<KatanaMainApp>(pointerFactory, reader, 0x011A36C4);
            var steamSurveillancePointer = GetPointer<SteamSurveillance>(pointerFactory, reader, 0x011A1B10);
            var lookUpTableCachePointer = GetPointerProxy<TextLookUpTableCache>(pointerFactory, reader, 0x0115A590);
            
            long startSampleTick = 0;
            int currentSampleCount = 0;
            int samplesPerSecond = 0;

            int startIngameTick = 0;
            int currentTotalIngameTick = 0;
            int ingameTicksPerSecond = 0;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.OutputEncoding = Encoding.Unicode;
            while (true)
            {

                currentSampleCount += 1;
                int currentIngameTick = currentTotalIngameTick - startIngameTick;
                if (stopwatch.ElapsedTicks - startSampleTick > Stopwatch.Frequency)
                {
                    samplesPerSecond = currentSampleCount;
                    currentSampleCount = 0;
                    startSampleTick = stopwatch.ElapsedTicks;
                    ingameTicksPerSecond = currentIngameTick;
                    startIngameTick = currentTotalIngameTick;
                }

                var gameManagerImpl = gameManagerImplPointer.Unbox(pointerFactory, reader);
                var networkManager = networkManagerPointer.Unbox(pointerFactory, reader);
                var katanaMainApp = katanaMainAppPointer.Unbox(pointerFactory, reader);
                var steamSurveillance = steamSurveillancePointer.Unbox(pointerFactory, reader);
                var lookUpTableCache = lookUpTableCachePointer.Unbox(pointerFactory, reader);

                currentTotalIngameTick = gameManagerImpl.Tick;
                Console.WriteLine("State     | Samples/s|    Sample|   Tick/s|       Tick");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("{0, -10}|{1, 10}|{2, 10}|{3, 10}|{4, 10}", gameManagerImpl.ManagerState,
                    samplesPerSecond, currentSampleCount, ingameTicksPerSecond, currentIngameTick);
                Console.WriteLine("");

                var playerCtrl = gameManagerImpl.PlayerControl;
                if (playerCtrl != null)
                {
                }

                foreach (var characterControl in gameManagerImpl.CharacterManager.CharacterControls)
                {
                    Console.WriteLine(characterControl.ToString());
                }

                if (currentSampleCount >= currentIngameTick)
                    Thread.Sleep(16);

                Console.Clear();
            }
        }
        
        private static Process GetProcess(string processName)
        {
            Process process = null;
            while (process == null)
            {
                process = Process.GetProcessesByName(processName).FirstOrDefault();
                Thread.Sleep(200);
            }
            return process;
        }

        private static IPointer<T> GetPointer<T>(IPointerFactory pointerFactory, IReader reader, int address) where T : class, IReadable<T>, new()
        {
            var pointer = pointerFactory.Create<T>(address, true);
            while (pointer.Dereferenced == false || pointer.IsNull)
            {
                pointer.Dereference(reader);
            }
            return pointer;
        }


        private static IPointer<T> GetPointerProxy<T>(ICachingPointerFactory pointerFactory, IReader reader, int address) where T : class, IReadable<T>, new()
        {
            var pointer = pointerFactory.CreateProxy<T>(address, true);
            while (pointer.Dereferenced == false || pointer.IsNull)
            {
                pointer.Dereference(reader);
            }
            return pointer;
        }
    }
}
