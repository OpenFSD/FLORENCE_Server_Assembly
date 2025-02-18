using System.Runtime.InteropServices;

namespace Server_Assembly
{
    public class Framework
    {
        static private Server_Assembly.Server game_server = null;
        static private Valve.Networking networkingServer = null;

        public Framework()
        {
            System.Console.WriteLine("entered => Server_Assembly.Framework()");//TestBench

            game_server = new Server_Assembly.Server();
            while (game_server == null) { /* Wait whileis created */ }
            game_server.GetExecute().Initialise();
            System.Console.WriteLine("created => Server_Assembly.Server()");//TestBench

            //Florence.Server_IO.Library.Create_Hosting_Server();//todo
            System.Console.WriteLine("skipped => Server_Library.Framework_Server()");//TestBench
            //game_server.GetExecute().Initialise_Threads();//todo

            //Valve.Sockets.Library.Initialize();//todo
            //networkingServer = new Valve.Networking();//todo
            //while (networkingServer == null) { /* wait untill created */ }//todo
            System.Console.WriteLine("skipped => Valve.Networking()");//TestBench
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
