namespace Server_Assembly
{
    public class Server
    {
        static private Server_Assembly.Algorithms algorithms;
        static private Server_Assembly.Data data;
        static private Server_Assembly.Execute execute;
        static private Server_Assembly.Global global;

        public Server()
        {
            global = new Server_Assembly.Global();
            while (global == null) { /* Wait while is created */ }

            algorithms = new Server_Assembly.Algorithms((ushort)global.Get_NumCores());
            while (algorithms == null) { /* Wait while is created */ }

            data = new Server_Assembly.Data();
            while (data == null) { /* Wait while is created */ }
            data.InitialiseControl();

            execute = new Server_Assembly.Execute();
            while (execute == null) { /* Wait while is created */ }
            execute.Initialise_Control((ushort)global.Get_NumCores(), global);

            System.Console.WriteLine("Server_Assembly: Client");
        }

        public Server_Assembly.Algorithms GetAlgorithms()
        {
            return algorithms;
        }
        public Server_Assembly.Data GetData()
        {
            return data;
        }

        public Server_Assembly.Global GetGlobal()
        {
            return global;
        }

        public Server_Assembly.Execute GetExecute()
        {
            return execute;
        }
    }
}