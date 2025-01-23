using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Assembly.Frame.Serv.Algo
{
    public class User_Alg
    {
        static private Server_Assembly.Frame.Serv.Algo.UserAlg.Praise0_Algorithm praise0_Algorithm = null;
        static private Server_Assembly.Frame.Serv.Algo.UserAlg.Praise1_Algorithm praise1_Algorithm = null;

        public User_Alg() 
        {
            praise0_Algorithm = new Server_Assembly.Frame.Serv.Algo.UserAlg.Praise0_Algorithm();
            while (praise0_Algorithm == null) { /* Wait while is created */ }

            praise1_Algorithm = new Server_Assembly.Frame.Serv.Algo.UserAlg.Praise1_Algorithm();
            while (praise1_Algorithm == null) { /* Wait while is created */ }
        }

        public Server_Assembly.Frame.Serv.Algo.UserAlg.Praise0_Algorithm GetPraise0_Algorithm()
        {
            return praise0_Algorithm;
        }
    }
}
