
namespace Server_Assembly
{
    public class Data
    {
        static private Server_Assembly.Data_Control data_Control;
        static private Server_Assembly.Game_Instance gameInstance;
        static private Server_Assembly.game_Instance.Settings settings;
        //byffers
        static private Server_Assembly.Inputs.Input_Instance input_Instnace;
        static private Server_Assembly.Outputs.Output_Instance output_Instnace;
        //stacks        
        static private List<Server_Assembly.Inputs.Input> stack_InputPraise;
        static private List<Server_Assembly.Outputs.Output> stack_OutputPraise;
        //praises
        static private Server_Assembly.Praise_Files.User_I user_IO;

        static private bool state_Buffer_InputPraise_SideToWrite;
        static private bool state_Buffer_OutputPraise_SideToWrite;

        public Data()
        {
            data_Control = null;
            gameInstance = new Server_Assembly.Game_Instance();
            settings = new Server_Assembly.game_Instance.Settings();

            input_Instnace = new Server_Assembly.Inputs.Input_Instance();
            output_Instnace = new Server_Assembly.Outputs.Output_Instance();

            user_IO = new Server_Assembly.Praise_Files.User_I();
            while (user_IO == null) { /* Wait while is created */ }

            state_Buffer_InputPraise_SideToWrite = true;
            state_Buffer_OutputPraise_SideToWrite = false;
         
            System.Console.WriteLine("Server_Assembly: Data");
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
            data_Control = new Server_Assembly.Data_Control();
            while (data_Control == null) { /* Wait while is created */ }
        }

        public void Flip_InBufferToWrite()
        {
            state_Buffer_InputPraise_SideToWrite = !state_Buffer_InputPraise_SideToWrite;
        }
        public void Flip_OutBufferToWrite()
        {
            state_Buffer_OutputPraise_SideToWrite = !state_Buffer_OutputPraise_SideToWrite;
        }

        public Server_Assembly.Data_Control GetData_Control()
        {
            return data_Control;
        }

        public Server_Assembly.Game_Instance GetGame_Instance()
        {
            return gameInstance;
        }
        public Server_Assembly.Inputs.Input_Instance GetInput_Instnace()
        {
            return input_Instnace;
        }
        public Server_Assembly.Outputs.Output_Instance GetOutput_Instnace()
        {
            return output_Instnace;
        }
        public bool GetState_Buffer_InputPraise_SideToWrite()
        {
            return state_Buffer_InputPraise_SideToWrite;
        }
        public bool GetState_Buffer_OutputPraise_SideToWrite()
        {
            return state_Buffer_OutputPraise_SideToWrite;
        }

        public Server_Assembly.game_Instance.Settings GetSettings()
        {
            return settings;
        }
        public List<Server_Assembly.Inputs.Input> GetStack_InputPraise()
        {
            return stack_InputPraise;
        }
        public List<Server_Assembly.Outputs.Output> GetStack_OutputsPraise()
        {
            return stack_OutputPraise;
        }

        public Server_Assembly.Praise_Files.User_I GetUserIO()
        {
            return user_IO;
        }
    }
}
