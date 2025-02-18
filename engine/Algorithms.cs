namespace Server_Assembly
{
    public class Algorithms
    {
        //static private Server_Assembly.Algo.Game gameAlgorithms;
        static private Server_Assembly.IO_ListenRespond io_ListenRespond;

        public Algorithms(UInt16 numberOfCores)
        {
            //gameAlgorithms = new Server_Assembly.Algo.Game();
            //while (gameAlgorithms == null) { /* Wait while is created */ }

            System.Console.WriteLine("Server_Assembly: Algorithms");//TEST
        }

        public void Initialise(UInt16 numberOfCores)
        {
            io_ListenRespond = new Server_Assembly.IO_ListenRespond();
            while (io_ListenRespond == null) { /* wait untill class constructed */ }
            io_ListenRespond.InitialiseControl();
        }

        // public Server_Assembly.Algo.Game GetGameAlgorithms()
        // {
        //     return gameAlgorithms;
        // }

        public Server_Assembly.IO_ListenRespond GetIO_ListenRespond()
        {
            return io_ListenRespond;
        }
    }
}