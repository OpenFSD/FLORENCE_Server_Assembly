using Server_Assembly.In;
using Server_Assembly.Out.Gfx;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Assembly
{
    public class Input
    {
        static private Server_Assembly.In.Input_Control input_Control;
        private Server_Assembly.In.Player player;
        static private Object praiseInputBuffer_Subset;

        static private UInt16 praiseEventId;
        

        public Input()
        {
            input_Control = null;

            praiseEventId = new int();
            praiseEventId = 0;

            praiseInputBuffer_Subset = null;

            player = new Server_Assembly.In.Player();
            while (player == null) { /* Wait while is created */ }

            System.Console.WriteLine("FLORENCE: Input");
        }

        public void InitialiseControl() 
        {
            input_Control = new Server_Assembly.In.Input_Control();
            while (input_Control == null) { /* Wait while is created */ }
        }

        public Object Get_InputBufferSubset()
        {
            return praiseInputBuffer_Subset;
        }

        public Server_Assembly.In.Input_Control GetInputControl()
        {
            return input_Control;
        }

        public Server_Assembly.In.Player GetPlayer() 
        { 
            return player; 
        }

        public int GetPraiseEventId() 
        {   
            return praiseEventId; 
        }

        public void Set_InputBuffer_SubSet(Object value)
        {
            praiseInputBuffer_Subset = value;
        }

        public void SetPraiseEventId(UInt16 value)
        {
            praiseEventId = value;
        }
    }
}