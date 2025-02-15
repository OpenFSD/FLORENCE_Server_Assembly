using System.Collections;
using System.Collections.Concurrent;

namespace Server_Assembly
{
    public class IO_ListenRespond
    {
        static private Server_Assembly.IO_ListenRespond_Control io_Control;

        public IO_ListenRespond()
        {
            io_Control = null;
        }
        public void InitialiseControl()
        {
            io_Control = new Server_Assembly.IO_ListenRespond_Control();
            while (io_Control == null) { /* Wait while is created */ }
        }

        public void Thread_Input_Listen()
        {
            while (true)
            {
                //Valve.Networking.CopyPayloadFromMessage();//todo
                Florence.IO_Server.Library.Flip_InBufferToWrite();
                Florence.IO_Server.WriteEnable.Request_Write_Stack_Server_InputAction(0);
                Florence.IO_Server.Library.Push_Stack_Server_InputPraises();
                switch (Florence.IO_Server.Library.Get_State_OfCoreToLaunch())
                {
                case false://IDLE
                    Florence.IO_Server.ConcurrentQue.Request_Wait_Launch_ConcurrentThread();
                    break;

                case true://ACTIVE  

                    break;
                }
                Florence.IO_Server.WriteEnable.End_Write_Stack_Server_InputAction(0);
            }
        }

        public void Thread_Output_Send()
        {
            while (true)
            {
                Florence.IO_Server.WriteEnable.Request_Write_Stack_Server_OutputRecieve(0);
                while(Florence.IO_Server.WriteEnable.Get_Flag_IsStackLoaded_Server_OutputRecieve())
                {
                    Florence.IO_Server.Library.Pop_Stack_Server_OutputPraise();
                    Florence.IO_Server.Library.Flip_OutBufferToWrite();
                    //Valve.Networking.CreateAndSendNewMessage();//todo
                }
                Florence.IO_Server.WriteEnable.End_Write_Stack_Server_OutputRecieve(0);
            }
        }

        public Server_Assembly.IO_ListenRespond_Control GetIO_Control()
        {
            return io_Control;
        }
    }
}
