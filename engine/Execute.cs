namespace Server_Assembly
{
    public class Execute
    {
        static private Server_Assembly.Execute_Control execute_Control = null;
        private Thread input_Listen = null;
        private Thread output_Send = null;

        public Execute()
        {
            input_Listen = null;
            output_Send = null;
        }
        public void Initialise()
        {
            Server_Assembly.Framework.GetGameServer().GetAlgorithms().Initialise((ushort)Framework.GetGameServer().GetGlobal().Get_NumCores());
        }

        public void Initialise_Control(
            UInt16 numberOfCores,
            Global global
        )
        {
            execute_Control = new Server_Assembly.Execute_Control(numberOfCores);
            while (execute_Control == null) { /* Wait while is created */ }
        }

        public void Initialise_Threads()
        {
            input_Listen = new Thread(Server_Assembly.Framework.GetGameServer().GetAlgorithms().GetIO_ListenRespond().Thread_Input_Listen);
            input_Listen.Start();

            output_Send = new Thread(Server_Assembly.Framework.GetGameServer().GetAlgorithms().GetIO_ListenRespond().Thread_Output_Send);
            output_Send.Start();
        }

        public void Create_And_Run_Graphics()
        {
            using (var graphics = new Server_Assembly.game_Instance.gFX.Graphics(
                Server_Assembly.Framework.GetGameServer().GetData().GetGame_Instance().GetSettings().GetGameWindowSettings(),
                Server_Assembly.Framework.GetGameServer().GetData().GetGame_Instance().GetSettings().GetNativeWindowSettings()
            ))
            {
                //TODO system system initionalised
                graphics.Run();
            }
        }

        public Execute_Control GetExecute_Control()
        {
            return execute_Control;
        }
    }
}