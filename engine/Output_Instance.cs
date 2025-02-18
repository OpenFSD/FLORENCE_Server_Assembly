using Server_Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Assembly.Outputs
{
    public class Output_Instance
    {
        static private Server_Assembly.Outputs.Output empty_OutputBuffer;
        static private Server_Assembly.Outputs.Output[] outputDoubleBuffer;
        static private Server_Assembly.Outputs.Output transmitOutputBuffer;

        public Output_Instance()
        {
            empty_OutputBuffer = new Server_Assembly.Outputs.Output();
            while (empty_OutputBuffer == null) { /* Wait while is created */ }
            empty_OutputBuffer.InitialiseControl();

            outputDoubleBuffer = new Server_Assembly.Outputs.Output[2];
            for (byte index = 0; index < 2; index++)
            {
                outputDoubleBuffer[index] = empty_OutputBuffer;
                while (outputDoubleBuffer == null) { /* Wait while is created */ }
            }

            transmitOutputBuffer = new Server_Assembly.Outputs.Output();
            while (transmitOutputBuffer == null) { /* Wait while is created */ }

        }

        private ushort BoolToInt16(bool value)
        {
            ushort temp = new ushort();
            if (value)
            {
                temp = 1;
            }
            else if (!value)
            {
                temp = 0;
            }
            return temp;
        }

        public Server_Assembly.Outputs.Output GetEmptyOutput()
        {
            return empty_OutputBuffer;
        }
        public Server_Assembly.Outputs.Output GetBuffer_FrontOutputDouble()
        {
            return outputDoubleBuffer[BoolToInt16(Server_Assembly.Framework.GetGameServer().GetData().GetState_Buffer_OutputPraise_SideToWrite())];
        }
        public Server_Assembly.Outputs.Output GetBuffer_BackOutputDouble()
        {
            return outputDoubleBuffer[BoolToInt16(!Server_Assembly.Framework.GetGameServer().GetData().GetState_Buffer_OutputPraise_SideToWrite())];
        }

        public Server_Assembly.Outputs.Output GetTransmitOutputBuffer()
        {
            return transmitOutputBuffer;
        }


        public void SetBuffer_Output(Server_Assembly.Outputs.Output value)
        {
            outputDoubleBuffer[BoolToInt16(!Framework.GetGameServer().GetData().GetState_Buffer_InputPraise_SideToWrite())] = value;
        }
    }
}
