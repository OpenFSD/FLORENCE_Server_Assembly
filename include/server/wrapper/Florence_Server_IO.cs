/*
 *  Managed C# wrapper for FLORENCE Server library by Jasper Assembly Pty Ltd.
 *  Copyright (c) 2022 - 2025 Brenton James Maddocks BEng(CompSys).  
 *  All rights reserved.
 */
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Florence.IO_Server
{
    public static class ConcurrentQue
    {
        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Request_Wait_Launch_ConcurrentThread();
    }

    public static class WriteEnable
    {
        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Request_Write_Stack_Server_InputAction(byte coreId);

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void End_Write_Stack_Server_InputAction(byte coreId);

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Request_Write_Stack_Server_OutputRecieve(byte coreId);

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void End_Write_Stack_Server_OutputRecieve(byte coreId);


        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)] 
        public static extern bool Get_Flag_IsStackLoaded_Server_OutputRecieve();
    }

    public static class Library
    {
        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Create_Hosting_Server();

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Create_Write_Stack_Server_InputAction();

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Create_Write_Stack_Server_OutputRecieve();

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Flip_InBufferToWrite();

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Flip_OutBufferToWrite();

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern bool Get_State_OfCoreToLaunch();
        
        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Pop_Stack_Server_OutputPraise();

        [DllImport("Server_DLL.dll", CharSet = CharSet.Unicode)]
        public static extern void Push_Stack_Server_InputPraises();

    }
    

    [SuppressUnmanagedCodeSecurity]
    internal static class PraiseEvents
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
