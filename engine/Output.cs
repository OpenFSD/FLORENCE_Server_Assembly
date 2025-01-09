﻿using Server_Assembly.In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Server_Assembly
{
    public class Output
    {
        static private Server_Assembly.Out.Output_Control output_Control;
        private Server_Assembly.In.Player player;

        static private int praiseEventId;
        static private Object praiseOutputBuffer_Subset;

        private static float[] vertices = {
            -0.5f, -0.5f, -0.5f,  0.0f, 0.0f,
            0.5f, -0.5f, -0.5f,  1.0f, 0.0f,
            0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
            0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
            -0.5f,  0.5f, -0.5f,  0.0f, 1.0f,
            -0.5f, -0.5f, -0.5f,  0.0f, 0.0f,

            -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
            0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
            0.5f,  0.5f,  0.5f,  1.0f, 1.0f,
            0.5f,  0.5f,  0.5f,  1.0f, 1.0f,
            -0.5f,  0.5f,  0.5f,  0.0f, 1.0f,
            -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,

            -0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
            -0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
            -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
            -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
            -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
            -0.5f,  0.5f,  0.5f,  1.0f, 0.0f,

            0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
            0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
            0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
            0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
            0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
            0.5f,  0.5f,  0.5f,  1.0f, 0.0f,

            -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
            0.5f, -0.5f, -0.5f,  1.0f, 1.0f,
            0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
            0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
            -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
            -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,

            -0.5f,  0.5f, -0.5f,  0.0f, 1.0f,
            0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
            0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
            0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
            -0.5f,  0.5f,  0.5f,  0.0f, 0.0f,
            -0.5f,  0.5f, -0.5f,  0.0f, 1.0f
        };
        private static uint[] indices = {  // note that we start from 0!
            0, 1, 3,   // first triangle
            1, 2, 3    // second triangle
        };
        private static float[] texCoords = {
            0.0f, 0.0f,  // lower-left corner  
            1.0f, 0.0f,  // lower-right corner
            0.5f, 1.0f   // top-center corner
        };

        public Output()
        {
            player = new Server_Assembly.In.Player();

            praiseEventId = new int();
            praiseEventId = 0;

            praiseOutputBuffer_Subset = null;

            System.Console.WriteLine("FLORENCE: Output");
        }
        public void Initalise_Graphics()
        {
            using (var graphics = new Server_Assembly.Out.Graphics(
                Framework.GetClient().GetData().GetSettings().GetGameWindowSettings(),
                Framework.GetClient().GetData().GetSettings().GetNativeWindowSettings()
            ))
            {
                Server_Assembly.Settings.Set_systemInitialised(true);
                graphics.Run();
            }
        }

        public void InitialiseControl()
        {
            output_Control = new Server_Assembly.Out.Output_Control();
            while (output_Control == null) { /* Wait while is created */ }
        }
        public uint[] Get_Indices()
        {
            return indices;
        }
        public Object GetOutputBufferSubset()
        {
            return praiseOutputBuffer_Subset;
        }

        public float[] Get_Vertices()
        {
            return vertices;
        }
        public Server_Assembly.In.Player GetPlayer()
        {
            return player;
        }

        public int GetPraiseEventId()
        {
            return praiseEventId;
        }

        public void SetInputBufferSubSet(Object value)
        {
            praiseOutputBuffer_Subset = value;
        }

        public void SetPraiseEventId(int value)
        {
            praiseEventId = value;
        }
    }
}