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

namespace DarkSoulsII.DebugView.Test
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Process process = GetProcess("DarkSoulsII");
            MemoryReader reader = MemoryReader.Create(process);
            var gameManagerImplPointer = GetPointer<GameManagerImpl>(reader, 0x011593F4);
            var networkManagerPointer = GetPointer<NetworkManager>(reader, 0x0115A5B4);
            var katanaMainAppPointer = GetPointer<KatanaMainApp>(reader, 0x011A36C4);
            var lookUpTableCache = GetPointer<TextLookUpTableCache>(reader, 0x0115A590).Unbox(reader);

            long startSampleTick = 0;
            int currentSamples = 0;
            int samplesPerSecond = 0;

            int startIngameTick = 0;
            int currentTotalIngameTick = 0;
            int ingameTicksPerSecond = 0;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.OutputEncoding = Encoding.Unicode;
            while (true)
            {
                currentSamples += 1;
                int currentIngameTick = currentTotalIngameTick - startIngameTick;
                if (stopwatch.ElapsedTicks - startSampleTick > Stopwatch.Frequency)
                {
                    samplesPerSecond = currentSamples;
                    currentSamples = 0;
                    startSampleTick = stopwatch.ElapsedTicks;
                    ingameTicksPerSecond = currentIngameTick;
                    startIngameTick = currentTotalIngameTick;
                }

                var gameManagerImpl = gameManagerImplPointer.Unbox(reader);
                var networkManager = networkManagerPointer.Unbox(reader);
                var katanaMainApp = katanaMainAppPointer.Unbox(reader);

                currentTotalIngameTick = gameManagerImpl.Tick;
                Console.WriteLine("State     | Samples/s|    Sample|   Tick/s|       Tick");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("{0, -10}|{1, 10}|{2, 10}|{3, 10}|{4, 10}", gameManagerImpl.ManagerState,
                    samplesPerSecond, currentSamples, ingameTicksPerSecond, currentIngameTick);
                Console.WriteLine("");

                var playerCtrl = gameManagerImpl.PlayerControl;
                if (playerCtrl != null)
                {
                }

                foreach (var characterControl in gameManagerImpl.CharacterManager.CharacterControls)
                {
                    Console.WriteLine(characterControl.ToString());
                }
                Thread.Sleep(15);
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

        private static IPointer<T> GetPointer<T>(IReader reader, int address) where T : class, IReadable<T>, new()
        {
            var gameManagerImplPointer = new Pointer<T>();
            while (gameManagerImplPointer.IsNull)
            {
                gameManagerImplPointer.Read(reader, address, true);
                Thread.Sleep(50);
            }
            return gameManagerImplPointer;
        }
    }
}
