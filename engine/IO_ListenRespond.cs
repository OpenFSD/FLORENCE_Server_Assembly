using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLORENCE.Frame.Serv.Algo
{
    public class IO_ListenRespond
    {
        static private Int16 threadId = 1;
        static private FLORENCE.Frame.Serv.Algo.IO.IO_ListenRespond_Control io_Control;

        public IO_ListenRespond()
        {
            io_Control = null;
        }
        public void InitialiseControl()
        {
            io_Control = new FLORENCE.Frame.Serv.Algo.IO.IO_ListenRespond_Control();
            while (io_Control == null) { /* Wait while is created */ }
        }

        public void Thread_io_ListenRespond()
        {
            //Framework.GetClient().GetExecute().GetExecute_Control().SetConditionCodeOfThisThreadedCore(threadId);
            //while (Framework.GetClient().GetExecute().GetExecute_Control().GetFlag_SystemInitialised(Framework.GetClient().GetGlobal().Get_NumCores()) != false)
            //{
            // wait untill ALL threads initalised in preperation of system init.
            //}
            bool switchState_IO = true;
            while (true)
            {
                switch (switchState_IO)
                {
                    case true:
                    {
                        //TODO
                        switchState_IO = false;
                        break;
                    }
                    case false:
                    {
                        //TODO
                        Networking.CopyPayloadFromMessage();
                        switchState_IO = true;
                        break;
                    }
                }
            }
        }
        public FLORENCE.Frame.Serv.Algo.IO.IO_ListenRespond_Control GetIO_Control()
        {
            return io_Control;
        }
    }
}
