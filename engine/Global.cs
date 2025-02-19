using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Assembly
{
    public class Global
    {
        static private ushort numberOfCores;
        static private ushort numberOfPraises;

        public Global()
        {
            numberOfCores = 2;
            numberOfPraises = 3;
        }

        public ushort Get_NumCores()
        {
            return numberOfCores;
        }

        public ushort Get_NumberOfPraises()
        {
            return numberOfPraises;
        }
    }
}