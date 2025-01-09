
namespace Server_Assembly
{
    public class Data
    {
        static private Server_Assembly.Data_Control data_Control;

        static private Server_Assembly.Game_Instance game_Instance;

        static private Server_Assembly.Input empty_InputBuffer;
        static private Server_Assembly.Output empty_OutputBuffer;

        static private Server_Assembly.Input[] inputDoubleBuffer;
        static private Server_Assembly.Output[] outputDoubleBuffer;
        
        static private List<Server_Assembly.Input> stack_InputActions;
        static private List<Server_Assembly.Output> stack_OutputRecieves;

        static private Server_Assembly.User_I user_IO;

        static private bool state_Buffer_Input_ToWrite;
        static private bool state_Buffer_Output_ToWrite;
        static private bool state_Buffer_TransmitInput_ToWrite;
        static private bool state_Buffer_RecieveOutput_ToWrite;

        public Data()
        {
            data_Control = null;

            empty_InputBuffer = new Server_Assembly.Input();
            while (empty_InputBuffer == null) { /* Wait while is created */ }
            empty_InputBuffer.InitialiseControl();

            empty_OutputBuffer = new Server_Assembly.Output();
            while (empty_OutputBuffer == null) { /* Wait while is created */ }
            empty_OutputBuffer.InitialiseControl();

            inputDoubleBuffer = new Server_Assembly.Input[2];
            for (byte index = 0; index < 2; index++)
            {
                inputDoubleBuffer[index] = empty_InputBuffer;
                while (inputDoubleBuffer[index] == null) { /* Wait while is created */ }
            }

            outputDoubleBuffer = new Server_Assembly.Output[2];
            for (byte index = 0; index < 2; index++)
            {
                outputDoubleBuffer[index] = empty_OutputBuffer;
                while (outputDoubleBuffer == null) { /* Wait while is created */ }
            }

            stack_InputActions = new List<Server_Assembly.Input>();
            while (stack_InputActions == null) { /* Wait while is created */ }
            stack_InputActions.ElementAt(0).Equals(empty_InputBuffer);

            stack_OutputRecieves = new List<Server_Assembly.Output>();
            while (stack_OutputRecieves == null) { /* Wait while is created */ }
            stack_OutputRecieves.ElementAt(0).Equals(empty_OutputBuffer);

            user_IO = new Server_Assembly.User_I();
            while (user_IO == null) { /* Wait while is created */ }

            state_Buffer_Input_ToWrite = true;
            state_Buffer_Output_ToWrite = false;
            state_Buffer_TransmitInput_ToWrite = true;
            state_Buffer_RecieveOutput_ToWrite = false;

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
            data_Control = new Server_Assembly.Data_Control();
            while (data_Control == null) { /* Wait while is created */ }
        }

        public void Flip_InBufferToWrite()
        {
            state_Buffer_Input_ToWrite = !state_Buffer_Input_ToWrite;
        }
        public void Flip_OutBufferToWrite()
        {
            state_Buffer_Output_ToWrite = !state_Buffer_Output_ToWrite;
        }
        public void Flip_Buffer_TransmitInput_ToWrite()
        {
            state_Buffer_TransmitInput_ToWrite = !state_Buffer_TransmitInput_ToWrite;
        }
        public void Flip_Buffer_RecieveOutput_ToWrite()
        {
            state_Buffer_RecieveOutput_ToWrite = !state_Buffer_RecieveOutput_ToWrite;
        }

        public Server_Assembly.Data_Control GetData_Control()
        {
            return data_Control;
        }

        public Server_Assembly.Input GetEmptyInput()
        {
            return empty_InputBuffer;
        }
        public Server_Assembly.Output GetEmptyOutput()
        {
            return empty_OutputBuffer;
        }

        public bool GetState_Buffer_Input_ToWrite()
        {
            return state_Buffer_Input_ToWrite;
        }
        public bool GetState_Buffer_Output_ToWrite()
        {
            return state_Buffer_Output_ToWrite;
        }
        public bool GetState_Buffer_TransmitInput_ToWrite()
        {
            return state_Buffer_TransmitInput_ToWrite;
        }
        public bool GetState_Buffer_RecieveOutput_ToWrite()
        {
            return state_Buffer_RecieveOutput_ToWrite;
        }

        public Server_Assembly.Input GetBuffer_FrontInputDouble()
        {
            return inputDoubleBuffer[BoolToInt16(GetState_Buffer_Input_ToWrite())];
        }
        public Server_Assembly.Input GetBuffer_BackInputDouble()
        {
            return inputDoubleBuffer[BoolToInt16(!GetState_Buffer_Input_ToWrite())];
        }

        public List<Server_Assembly.Input> GetStackOfInputActions()
        {
            return stack_InputActions;
        }

        public List<Server_Assembly.Output> GetStackOfOutputsRecieved()
        {
            return stack_OutputRecieves;
        }

        public Server_Assembly.User_I GetUserIO()
        {
            return user_IO;
        }

        public void SetInputBuffer(Server_Assembly.Input value)
        {
            inputDoubleBuffer[BoolToInt16(Florence.IO_Buffers.Library.Get_HostServer().GetData().GetState_Buffer_Input_ToWrite())] = value;
        }

        public void SetOutputBuffer(Server_Assembly.Output value)
        {
            outputDoubleBuffer[BoolToInt16(Florence.IO_Buffers.Library.Get_HostServer().GetData().GetState_Buffer_Output_ToWrite())] = value;
        }
    }
}
