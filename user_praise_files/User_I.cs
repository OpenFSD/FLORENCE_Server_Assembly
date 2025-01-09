//using Server_Assembly.In;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Assembly
{
    public class User_I
    {
        static private Server_Assembly.UserIn.Praise0_Input praise0_Input;
        static private Server_Assembly.UserIn.Praise1_Input praise1_Input;

        public User_I() 
        {
            praise0_Input = new Server_Assembly.UserIn.Praise0_Input();
            praise1_Input = new Server_Assembly.UserIn.Praise1_Input();
        }

        public Server_Assembly.UserIn.Praise0_Input GetPraise0_Input()
        {
            return praise0_Input;
        }

        public Server_Assembly.UserIn.Praise1_Input GetPraise1_Input()
        {
            return praise1_Input;
        }
    }
}
