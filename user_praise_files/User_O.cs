using Server_Assembly.In;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Assembly
{
    public class User_O
    {
        static private Server_Assembly.UserOut.Praise0_Output praise0_Output;
        static private Server_Assembly.UserOut.Praise1_Output praise1_Output;

        public User_O()
        {
            praise0_Output = new Server_Assembly.UserOut.Praise0_Output();
            praise1_Output = new Server_Assembly.UserOut.Praise1_Output();
        }

        public Server_Assembly.UserOut.Praise0_Output GetPraise0_Outnput()
        {
            return praise0_Output;
        }

        public Server_Assembly.UserOut.Praise1_Output GetPraise1_Output()
        {
            return praise1_Output;
        }
    }
}
