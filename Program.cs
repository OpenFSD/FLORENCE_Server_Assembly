using System.Runtime.InteropServices;

namespace FLORENCE
{
    public class Program
    {
        private static FLORENCE.Framework framework = null;
        private static FLORENCE.Frame.Server networkingServer = null;

        public static void Main(String[] args)
        {
            System.Console.WriteLine("FLORENCE START");

            framework = new FLORENCE.Framework();
            while (framework == null) { /* wait untill created */ }


        }

        public static FLORENCE.Framework Get_Framework()
        {
            return framework;
        }
    }
}