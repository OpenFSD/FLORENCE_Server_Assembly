using System.Runtime.InteropServices;

namespace Server_Assembly
{
    public class Framework
    {
        static private Server_Assembly.Server game_server = null;
        static private Valve.Networking networkingServer = null;

        public Framework()
        {
            System.Console.WriteLine("entered => Server_Assembly.Framework()");//testbecnh

            game_server = new Server_Assembly.Server();
            while (game_server == null) { /* Wait whileis created */ }
            game_server.GetExecute().Initialise();
            game_server.GetExecute().Initialise_Threads();
            System.Console.WriteLine("created => Server_Assembly.Server()");//testbecnh

            //Florence.IO_Server.Library.Create_Hosting_Server();
            System.Console.WriteLine("skipped => Server_Library.Framework_Server()");//testbecnh

            //Valve.Sockets.Library.Initialize();
            //networkingServer = new Valve.Networking();
            //while (networkingServer == null) { /* wait untill created */ }
            System.Console.WriteLine("skipped => Valve.Networking()");//testbecnh
        }

        static public Server_Assembly.Server GetGameServer()
        {
            return game_server;
        }


        static public Valve.Networking GetNetworkingServer()
        {
             return networkingServer;
        }
    }
}
