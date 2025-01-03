using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FLORENCE.Frame
{
    public class Server
    {
        static private FLORENCE.Frame.Serv.Algorithms algorithms;
        static private FLORENCE.Frame.Serv.Data data;
        static private FLORENCE.Frame.Serv.Execute execute;
        static private FLORENCE.Frame.Serv.Global global;

        public Server()
        {
            global = new FLORENCE.Frame.Serv.Global();
            while (global == null) { /* Wait while is created */ }

            algorithms = new FLORENCE.Frame.Serv.Algorithms(global.Get_NumCores());
            while (algorithms == null) { /* Wait while is created */ }

            data = new FLORENCE.Frame.Serv.Data();
            while (data == null) { /* Wait while is created */ }
            data.InitialiseControl();

            execute = new FLORENCE.Frame.Serv.Execute();
            while (execute == null) { /* Wait while is created */ }
            execute.Initialise_Control(global.Get_NumCores(), global);

            System.Console.WriteLine("FLORENCE: Client");
        }

        public FLORENCE.Frame.Serv.Algorithms GetAlgorithms()
        {
            return algorithms;
        }
        public FLORENCE.Frame.Serv.Data GetData()
        {
            return data;
        }

        public FLORENCE.Frame.Serv.Global GetGlobal()
        {
            return global;
        }

        public FLORENCE.Frame.Serv.Execute GetExecute()
        {
            return execute;
        }
    }
}