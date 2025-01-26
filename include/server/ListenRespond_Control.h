#pragma once

namespace Server_Library
{
    class ListenRespond_Control
    {
    public:
        ListenRespond_Control();
        ~ListenRespond_Control();

        bool Get_State_IO_Thread();

        void SetFlag_IO_ThreadState(bool value);

    protected:

    private:
        static bool state_IO_Thread;
    };
}
