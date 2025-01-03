using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLORENCE.Frame.Serv
{
    public class Execute
    {
        static private Exe.Execute_Control execute_Control = null;
        private Thread listenRespond = null;

        public Execute()
        {

        }
        public void Initialise()
        {
            Framework.GetServer().GetAlgorithms().Initialise(Framework.GetServer().GetGlobal().Get_NumCores());


        }

        public void Initialise_Control(
            int numberOfCores,
            Global global
        )
        {
            execute_Control = new Exe.Execute_Control(numberOfCores);
            while (execute_Control == null) { /* Wait while is created */ }
        }

        public void Initialise_Threads(
            int numberOfCores
        )
        {
            listenRespond = new Thread(Framework.GetServer().GetAlgorithms().GetIO_ListenRespond().Thread_io_ListenRespond);
            listenRespond.Start();
        }
    }
}
