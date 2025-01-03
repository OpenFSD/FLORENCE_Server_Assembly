using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLORENCE.Frame.Serv
{
    public class Algorithms
    {
        //static private FLORENCE.Frame.Serv.Algo.Game gameAlgorithms;
        static private FLORENCE.Frame.Serv.Algo.IO_ListenRespond io_ListenRespond;

        public Algorithms(int numberOfCores)
        {
            //gameAlgorithms = new FLORENCE.Frame.Serv.Algo.Game();
            //while (gameAlgorithms == null) { /* Wait while is created */ }

            System.Console.WriteLine("FLORENCE: Algorithms");//TEST
        }

        public void Initialise(int numberOfCores)
        {
            io_ListenRespond = new FLORENCE.Frame.Serv.Algo.IO_ListenRespond();
            while (io_ListenRespond == null) { /* wait untill class constructed */ }
            io_ListenRespond.InitialiseControl();
        }

        // public FLORENCE.Frame.Serv.Algo.Game GetGameAlgorithms()
        // {
        //     return gameAlgorithms;
        // }

        public FLORENCE.Frame.Serv.Algo.IO_ListenRespond GetIO_ListenRespond()
        {
            return io_ListenRespond;
        }
    }
}