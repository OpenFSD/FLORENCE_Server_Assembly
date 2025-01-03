using FLORENCE.Frame.Serv.Dat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLORENCE.Frame.Serv
{
    public class Data
    {
        static private FLORENCE.Frame.Serv.Dat.Data_Control data_Control;

        public Data()
        {
            System.Console.WriteLine("FLORENCE: Data");
        }

        public Int16 BoolToInt16(bool value)
        {
            Int16 temp = new Int16();
            if (value)
            {
                temp = (Int16)1;
            }
            else if (!value)
            {
                temp = (Int16)0;
            }
            return temp;
        }

        public void InitialiseControl()
        {
            data_Control = new FLORENCE.Frame.Serv.Dat.Data_Control();
            while (data_Control == null) { /* Wait while is created */ }
        }
    }
}
