using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FLORENCE.Frame
{
    public class Networking
    {
        static private Valve.Sockets.NetworkingSockets sockets = null;
        static private Valve.Sockets.NetworkingMessage netMessage;

        public Networking()
        {
            sockets = new Valve.Sockets.NetworkingSockets();
            netMessage = new Valve.Sockets.NetworkingMessage();
        }

        static private int BoolToInt(bool value)
        {
            int temp = 0;
            if(value)temp = 1;
            if (!value) temp = 0;
            return temp;
        }
        static private int BitArrayToInt(bool[] arr, int count)
        {
            int ret = 0;
            int tmp;
            for (int i = 0; i < count; i++)
            {
                tmp = BoolToInt(arr[i]);
                ret |= tmp << (count - i - 1);
            }
            return ret;
        }

        static public void CreateNetworkingServer()
        {
            Valve.Sockets.NetworkingSockets server = new Valve.Sockets.NetworkingSockets();

            uint pollGroup = server.CreatePollGroup();

            Valve.Sockets.StatusCallback status = (ref Valve.Sockets.StatusInfo info) =>
            {
                switch (info.connectionInfo.state)
                {
                    case Valve.Sockets.ConnectionState.None:
                        break;

                    case Valve.Sockets.ConnectionState.Connecting:
                        server.AcceptConnection(info.connection);
                        server.SetConnectionPollGroup(pollGroup, info.connection);
                        break;

                    case Valve.Sockets.ConnectionState.Connected:
                        Console.WriteLine("Client connected - ID: " + info.connection + ", IP: " + info.connectionInfo.address.GetIP());
                        break;

                    case Valve.Sockets.ConnectionState.ClosedByPeer:
                    case Valve.Sockets.ConnectionState.ProblemDetectedLocally:
                        server.CloseConnection(info.connection);
                        Console.WriteLine("Client disconnected - ID: " + info.connection + ", IP: " + info.connectionInfo.address.GetIP());
                        break;
                }
            };

            Valve.Sockets.NetworkingUtils utils = new Valve.Sockets.NetworkingUtils();
            utils.SetStatusCallback(status);

            Valve.Sockets.Address address = new Valve.Sockets.Address();

            address.SetAddress("::0", port);

            uint listenSocket = server.CreateListenSocket(ref address);

#if VALVESOCKETS_SPAN
	        MessageCallback message = (in NetworkingMessage netMessage) => {
		        Console.WriteLine("Message received from - ID: " + netMessage.connection + ", Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);
	        };
#else
            const int maxMessages = 20;

            Valve.Sockets.NetworkingMessage[] netMessages = new Valve.Sockets.NetworkingMessage[maxMessages];
#endif

            while (!Console.KeyAvailable)
            {
                server.RunCallbacks();

#if VALVESOCKETS_SPAN
		        server.ReceiveMessagesOnPollGroup(pollGroup, message, 20);
#else
                int netMessagesCount = server.ReceiveMessagesOnPollGroup(pollGroup, netMessages, maxMessages);

                if (netMessagesCount > 0)
                {
                    for (int i = 0; i < netMessagesCount; i++)
                    {
                        ref Valve.Sockets.NetworkingMessage netMessage = ref netMessages[i];

                        Console.WriteLine("Message received from - ID: " + netMessage.connection + ", Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);

                        netMessage.Destroy();
                    }
                }
#endif

                Thread.Sleep(15);
            }
            server.DestroyPollGroup(pollGroup);
        }

        public static void CreateAndSendNewMessage()
        {
            byte[] data = new byte[64];
            sockets.SendMessageToConnection(connection, data);
        }

        public static void CopyPayloadFromMessage()
        {
            byte[] buffer = new byte[1024];
            netMessage.CopyTo(buffer);

            int switch_praiseEventId = 0;
            bool[] temp_bool_array;
            
            for (Int16 i = 0; i < 16; i++)
            {
                temp_bool_array = new bool[16];
                temp_bool_array[i] = Convert.ToBoolean(buffer[i]);
                switch_praiseEventId = Networking.BitArrayToInt(temp_bool_array, 16); ;
            }
            switch (switch_praiseEventId)
            {
                case 0:
                    for (Int16 i = 16; i < 16; i++)
                    {
                        temp_bool_array = new bool[16];
                        temp_bool_array[i] = Convert.ToBoolean(buffer[i]);
                        //FLORENCE.Framework.GetServer()->GetData()->GetInputBuffer(FLORENCE.Framework.GetServer()->GetData()->GetStateOfInBufferWrite())->
                    }
                    //data = new byte[64];
                    break;

                case 1:
                    //ToDo
                    break;

                default:
                    break;
            }
        }

        public static void SetA_HookForDebugInformation()
        {
            Valve.Sockets.DebugCallback debug = (type, message) =>
            {
                Console.WriteLine("Debug - Type: " + type + ", Message: " + message);
            };

            Valve.Sockets.NetworkingUtils utils = new Valve.Sockets.NetworkingUtils();

            utils.SetDebugCallback(Valve.Sockets.DebugType.Everything, debug);
        }
    }
}
