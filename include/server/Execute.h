#pragma once
#include <array>
#include <thread>
#include "Execute_Control.h"
#include "Framework_Server.h"
#include "Global.h"
#include "concurrent_que\\Framework_ConcurrentQue.h"
#include "write_enable\\Framework_WriteEnable.h"

namespace Server_Library
{
    class Execute
    {
    public:
        Execute(
            class Global* ptr_Global,
            unsigned char number_Implemented_Cores
        );
        virtual ~Execute();
        void Initialise();
        void Initialise_Control(
            unsigned char number_Implemented_Cores,
            class Global* ptr_Global
        );
        void Initialise_Threads();
        void Initialise_Libraries();
        class Execute_Control* Get_Execute_Control();
        class ConcurrentQue::Framework_ConcurrentQue* Get_LaunchConcurrency_ServerSide();
        class WaitEnableWrite::Framework_WriteEnable* Get_WriteEnable_Stack_Server_InputPraise();
        class WaitEnableWrite::Framework_WriteEnable* Get_WriteEnable_Stack_Server_OutputPraise();

    protected:

    private:
        static class Execute_Control* ptr_Execute_Control;
        static class ConcurrentQue::Framework_ConcurrentQue* ptr_LaunchConcurrency_ServerSide;
        static std::thread* ptr_Thread_WithCoreId[4];//NUMBER OF CORES
        static class WaitEnableWrite::Framework_WriteEnable* ptr_WriteEnable_Stack_InputPraise;
        static class WaitEnableWrite::Framework_WriteEnable* ptr_WriteEnable_Stack_OutputPraise;
    };
}