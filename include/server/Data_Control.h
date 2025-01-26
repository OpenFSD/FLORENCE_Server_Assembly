#pragma once
#include <vector>
#include "Input.h"
#include "Output.h"

namespace Server_Library
{
    class Data_Control
    {
    public:
        Data_Control();
        virtual ~Data_Control();
        void Pop_Stack_Server_InputPraise(
            class Input* referenceForCore,
            std::vector<class Input*>* ptr_inputStack
        );
        void Pop_Stack_Server_OutputPraise(
            class Output* distributeBuffer,
            std::vector<class Output*>* ptr_outputStack
        );
        void Push_Stack_Server_InputPraise(
            std::vector<class Input*>* ptr_InputStack,
            class Input* ptr_Buffer_Praise
        );
        void Push_Stack_Server_OutputPraise(
            std::vector<class Output*>* ptr_outputStack,
            class Output* ptr_referenceForCore
        );

        bool GetFlag_InputStackLoaded();
        bool GetFlag_OutputStackLoaded();

        void SetFlag_InputStackLoaded(bool value);
        void SetFlag_OutputStackLoaded(bool value);

    protected:

    private:
        static bool flag_isLoaded_Stack_InputPraise;
        static bool flag_isLoaded_Stack_OutputPraise;
    };
}