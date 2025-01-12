namespace Server_Assembly
{
    public class Program
    {
        private static Server_Assembly.Framework serverAssembly = null;

        public static void Main(String[] args)
        {
            System.Console.WriteLine("Server_Assembly START");

            serverAssembly = new Server_Assembly.Framework();
            while (serverAssembly == null) { /* wait untill created */ }
        }
    }
}