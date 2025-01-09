namespace Server_Assembly
{
    public class IO_ListenRespond_Control
    {
        static private bool flag_State_IOThread;

        public IO_ListenRespond_Control() 
        {
            flag_State_IOThread = true;
        }

        public bool GetFLAG_STATE_ioThread()
        {
            return flag_State_IOThread; 
        }

        public void SetFLAG_STATE_ioThread(bool value)
        {
            flag_State_IOThread = value;
        }
    }
}
