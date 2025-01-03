using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLORENCE
{
    public class Framework
    {
        static private FLORENCE.Frame.Server server = null;
        static private FLORENCE.Frame.Networking networkingServer = null;

        static private Int16 threadId = 0;

        public Framework()
        {
            server = new FLORENCE.Frame.Server();
            while (server == null) { /* Wait whileis created */ }
            server.GetExecute().Initialise();
            server.GetExecute().Initialise_Threads(Framework.GetServer().GetGlobal().Get_NumCores());

            //Valve.Sockets.Library.Initialize();
            //networkingServer = new FLORENCE.Frame.Server();
            //while (networkingClient == null) { /* wait untill created */ }

            System.Console.WriteLine("FLORENCE: Framework");//TEST
        }

        static public FLORENCE.Frame.Server GetServer()
        {
            return server;
        }

        static public FLORENCE.Frame.Networking GetNetworkingServer()
        {
             return networkingServer;
        }
    }
}
