using System.Runtime.InteropServices;

namespace Server_Assembly
{
    public class Framework
    {
        static private Server_Assembly.Server game_server = null;
        static private Server_Assembly.Networking networkingServer = null;

        public Framework()
        {
            
            game_server = new Server_Assembly.Server();
            while (game_server == null) { /* Wait whileis created */ }
            game_server.GetExecute().Initialise();
            game_server.GetExecute().Initialise_Threads((ushort)Framework.GetGameServer().GetGlobal().Get_NumCores());
        
            Florence.IO_Buffers.Library.Create_HostingServer();
            
            Valve.Sockets.Library.Initialize();
            networkingServer = new Server_Assembly.Networking();
            while (networkingServer == null) { /* wait untill created */ }

            System.Console.WriteLine("FLORENCE: Framework");//TEST
        }

        static public Server_Assembly.Server GetGameServer()
        {
            return game_server;
        }


        static public void Get_HostServer()
        {
            Florence.IO_Buffers.Library.Get_HostServer();
        }
        
        static public Server_Assembly.Networking GetNetworkingServer()
        {
             return networkingServer;
        }
    }
}
