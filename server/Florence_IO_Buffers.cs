/*
 *  Managed C# wrapper for FLORENCE Server library by Jasper Assembly Pty Ltd.
 *  Copyright (c) 2022 - 2025 Brenton James Maddocks BEng(CompSys).  
 *  All rights reserved.
 */

using Server_Assembly;
using Server_Assembly;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Florence.IO_Buffers
{
    public static class Library
    {
        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Create_HostingServer();

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Pop_Stack_OutputPraise();

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Push_Stack_InputPraises();

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern bool Get_Ack_InputAction_Capture();

    //get
        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern Server Get_HostServer();
    
    //set
        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Set_Ack_InputAction_Capture(bool value);
    }
    

    [SuppressUnmanagedCodeSecurity]
    internal static class Native
    {
        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern UInt16 Get_PraiseEventId();

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern float Get_Praise0_pitch();

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern float Get_Praise0_yaw();


        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Set_PraiseEventId(UInt16 value);

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Set_Praise0_mousePos_X(Int16 value);

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Set_Praise0_mousePos_Y(Int16 value);
    }
}
