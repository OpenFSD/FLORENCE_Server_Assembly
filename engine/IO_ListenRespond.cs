using System.Collections;

namespace Server_Assembly
{
    public class IO_ListenRespond
    {
        static private UInt16 threadId = 1;
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

        public void Thread_io_ListenRespond()
        {
            Framework.GetGameServer().GetExecute().GetExecute_Control().SetConditionCodeOfThisThreadedCore(threadId);

            while (Framework.GetGameServer().GetExecute().GetExecute_Control().GetFlag_SystemInitialised((ushort)Framework.GetGameServer().GetGlobal().Get_NumCores()) != false)
            {
                // wait untill ALL threads initalised in preperation of system init.
            }
            while (true)
            {
                switch (Server_Assembly.Framework.GetGameServer().GetAlgorithms().GetIO_ListenRespond().GetIO_Control().GetFLAG_STATE_ioThread())
                {
                    case true:
                    {

                            //TODO
                            //Networking.CreateAndSendNewMessage();
                            Server_Assembly.Framework.GetGameServer().GetAlgorithms().GetIO_ListenRespond().GetIO_Control().SetFLAG_STATE_ioThread(false);
                        break;
                    }
                    case false:
                    {
                            Florence.Stack_IO.Stack_InputPraise.Write_Start(0);
                            Networking.CopyPayloadFromMessage();
                            Framework.GetGameServer().GetData().Flip_InBufferToWrite();
                            Florence.IO_Buffers.Library.Push_Stack_InputPraises();
                            //Florence.IO_Buffers.Library.Set_Ack_InputAction_Capture(true);
                            Florence.Stack_IO.Stack_InputPraise.Write_End(0);
                            Framework.GetGameServer().GetAlgorithms().GetIO_ListenRespond().GetIO_Control().SetFLAG_STATE_ioThread(true);
                        break;
                    }
                }
            }
        }
        public Server_Assembly.IO_ListenRespond_Control GetIO_Control()
        {
            return io_Control;
        }
    }
}
