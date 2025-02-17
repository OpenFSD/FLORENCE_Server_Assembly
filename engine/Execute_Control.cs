﻿namespace Server_Assembly
{
    public class Execute_Control
    {
        static private bool flag_SystemInitialised;
        static private bool[] flag_ThreadInitialised;

        public Execute_Control(UInt16 numberOfCores)
        {
            flag_SystemInitialised = new bool();
            flag_SystemInitialised = true;

            flag_ThreadInitialised = new bool[numberOfCores];
            for (short index = 0; index < numberOfCores; index++)
            {
                flag_ThreadInitialised[index] = new bool();
                flag_ThreadInitialised[index] = true;
            }
        }

        public bool GetFlag_Server_Shell_Initialised()
        {
            if (Florence.Server_IO.Library.GetFlag_Server_Library_Initialised() == true)
            {
                flag_SystemInitialised = true;
            }
            else
            {
                flag_SystemInitialised = false;
                for (int index = 0; index < Server_Assembly.Framework.GetGameServer().GetGlobal().Get_NumCores(); index++)
                {
                    if (flag_ThreadInitialised[index] == true)
                    {
                        flag_SystemInitialised = true;
                    }
                }
            }    
            return flag_SystemInitialised;
        }

        public bool GetFlag_ThreadInitialised(UInt16 coreId)
        {
            return flag_ThreadInitialised[coreId];
        }

        public void SetConditionCodeOfThisThreadedCore(UInt16 coreId)
        {
            //Todo
            SetFlag_ThreadInitialised(coreId);
        }

        public void SetFlag_ThreadInitialised(UInt16 coreId)
        {
            flag_ThreadInitialised[coreId] = false;
        }
    }
}
