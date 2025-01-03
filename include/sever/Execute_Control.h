#pragma once
#include <array>

namespace ServerLibrary
{
    class Execute_Control
    {
    public:
        Execute_Control(unsigned char* ptr_MyNumImplementedCores);
        virtual ~Execute_Control();

        bool GetFlag_SystemInitialised(unsigned char* ptr_MyNumImplementedCores);
        bool GetFlag_ThreadInitialised(unsigned char coreId);

        void SetConditionCodeOfThisThreadedCore(unsigned char coreId);

    protected:

    private:
        void SetFlag_ThreadInitialised(unsigned char coreId);

        static bool flag_SystemInitialised;
        static bool flag_ThreadInitialised[4];//NUMBER OF CORES
    };
}