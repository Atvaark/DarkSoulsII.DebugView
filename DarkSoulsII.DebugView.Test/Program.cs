using System;
using System.Diagnostics;
using System.Linq;
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
            Process process = null;
            while (process == null)
            {
                process = Process.GetProcessesByName("DarkSoulsII").FirstOrDefault();
                Thread.Sleep(200);
            }

            MemoryReader reader = MemoryReader.Create(process);
            var gameManagerImplPointer = GetPointer<GameManagerImpl>(reader, 0x011593F4);
            var networkManagerPointer = GetPointer<NetworkManager>(reader, 0x0115A5B4);
            var katanaMainAppPointer = GetPointer<KatanaMainApp>(reader, 0x011A36C4);
            var lookUpTableCache = GetPointer<TextLookUpTableCache>(reader, 0x0115A590).Unbox(reader);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                Console.Clear();
                sw.Restart();
                var gameManagerImpl = gameManagerImplPointer.Unbox(reader);
                var networkManager = networkManagerPointer.Unbox(reader);
                var katanaMainApp = katanaMainAppPointer.Unbox(reader);
                Console.WriteLine(gameManagerImpl.FrameCount + " " + gameManagerImpl.ManagerState + " " +
                                  sw.ElapsedMilliseconds);

                var playerCtrl = gameManagerImpl.PlayerControl;
                if (playerCtrl != null)
                {
                }

                foreach (var characterControl in gameManagerImpl.CharacterManager.CharacterControls)
                {
                    Console.WriteLine(characterControl.ToString());
                }

                Thread.Sleep(200);
            }
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
