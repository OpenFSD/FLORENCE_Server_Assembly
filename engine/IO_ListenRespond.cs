using System.Collections;
using System.Collections.Concurrent;

namespace Server_Assembly
{
    public class IO_ListenRespond
    {
        static private byte listen_CoreId;
        static private byte respond_CoreId;
        static private Server_Assembly.IO_ListenRespond_Control io_Control;

        public IO_ListenRespond()
        {
            listen_CoreId = 255;
            respond_CoreId = 255;
            io_Control = null;
        }
        public void InitialiseControl()
        {
            io_Control = new Server_Assembly.IO_ListenRespond_Control();
            while (io_Control == null) { /* Wait while is created */ }
        }

        public void Thread_Input_Listen()
        {
            listen_CoreId = 0;
            bool done_once = true;
            while (Server_Assembly.Framework.GetGameServer().GetExecute().GetExecute_Control().GetFlag_ThreadInitialised(listen_CoreId) == true)
            {
                if (done_once == true)
                {
                    Server_Assembly.Framework.GetGameServer().GetExecute().GetExecute_Control().SetFlag_ThreadInitialised(listen_CoreId);
                    done_once = false;
                }
            }
            System.Console.WriteLine("Thread Initialised => Thread_Input_Listen()");//TestBench
            while (Server_Assembly.Framework.GetGameServer().GetExecute().GetExecute_Control().GetFlag_Server_Shell_Initialised() == true)
            {
            
            }
            System.Console.WriteLine("Thread Started => Thread_Input_Listen()");//TestBench
            while (Server_Assembly.Framework.GetGameServer().GetExecute().GetExecute_Control().GetFlag_Server_Shell_Initialised() == false)
            {
                //Valve.Networking.CopyPayloadFromMessage();//todo
                Florence.Server_IO.Library.Flip_InBufferToWrite();
                Florence.Server_IO.WriteEnable.Request_Write_Stack_Server_InputAction(0);
                Florence.Server_IO.Library.Push_Stack_Server_InputPraises();
                switch (Florence.Server_IO.Library.Get_State_OfCoreToLaunch())
                {
                case false://IDLE
                    Florence.Server_IO.ConcurrentQue.Request_Wait_Launch_ConcurrentThread();
                    break;

                case true://ACTIVE  

                    break;
                }
                Florence.Server_IO.WriteEnable.End_Write_Stack_Server_InputAction(0);
            }
        }

        public void Thread_Output_Send()
        {
            respond_CoreId = 1;
            bool done_once = true;
            while (Server_Assembly.Framework.GetGameServer().GetExecute().GetExecute_Control().GetFlag_ThreadInitialised(1) == true)
            {
                if (done_once == true)
                {
                    Server_Assembly.Framework.GetGameServer().GetExecute().GetExecute_Control().SetFlag_ThreadInitialised(1);
                    done_once = false;
                }
            }
            System.Console.WriteLine("Thread Initialised => Thread_Output_Send()");//TestBench
            while (Server_Assembly.Framework.GetGameServer().GetExecute().GetExecute_Control().GetFlag_Server_Shell_Initialised() == true)
            {

            }
            System.Console.WriteLine("Thread Started => Thread_Output_Send()");//TestBench
            while (Server_Assembly.Framework.GetGameServer().GetExecute().GetExecute_Control().GetFlag_Server_Shell_Initialised() == false)
            {
                Florence.Server_IO.WriteEnable.Request_Write_Stack_Server_OutputRecieve(0);
                while(Florence.Server_IO.WriteEnable.Get_Flag_IsStackLoaded_Server_OutputRecieve())
                {
                    Florence.Server_IO.Library.Pop_Stack_Server_OutputPraise();
                    Florence.Server_IO.Library.Flip_OutBufferToWrite();
                    //Valve.Networking.CreateAndSendNewMessage();//todo
                }
                Florence.Server_IO.WriteEnable.End_Write_Stack_Server_OutputRecieve(0);
            }
        }

        public Server_Assembly.IO_ListenRespond_Control GetIO_Control()
        {
            return io_Control;
        }
    }
}
