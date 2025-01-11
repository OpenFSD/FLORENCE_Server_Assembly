using Server_Assembly.UserIn;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Assembly.In
{
    public class Input_Control
    {
        static private bool[] isSelected_PraiseEventId = new bool[0];
        static int numberOfPraises;

        public Input_Control()
        {
            numberOfPraises = 2;//move to global
            isSelected_PraiseEventId = new bool[numberOfPraises];
        }

        private void LoadValuesInToInputSubset(
            int praiseEventId
        )
        {
            switch (praiseEventId)
            {
//===
//===
                case 0:
                    Praise0_Input subset_Praise0_Doublebuffer = (Praise0_Input)Framework.GetClient().GetData().GetBuffer_BackInputDouble().Get_InputBufferSubset();
                    Praise0_Input subset_Praise0_thirdBuffer = (Praise0_Input)Framework.GetClient().GetData().GetThirdInputBuffer().Get_InputBufferSubset();
                    subset_Praise0_thirdBuffer.Set_Mouse_X(subset_Praise0_Doublebuffer.Get_Mouse_X());
                    subset_Praise0_thirdBuffer.Set_Mouse_Y(subset_Praise0_Doublebuffer.Get_Mouse_X());
                    break;

                case 1:
                    Praise1_Input subset_Praise1_Doublebuffer = (Praise1_Input)Framework.GetClient().GetData().GetBuffer_BackInputDouble().Get_InputBufferSubset();
                    Praise1_Input subset_Praise1_thirdBuffer = (Praise1_Input)Framework.GetClient().GetData().GetThirdInputBuffer().Get_InputBufferSubset();
                    subset_Praise1_thirdBuffer.Set_Position_X(subset_Praise1_Doublebuffer.Get_Position_X());
                    subset_Praise1_thirdBuffer.Set_Position_Y(subset_Praise1_Doublebuffer.Get_Position_Y());
                    subset_Praise1_thirdBuffer.Set_Position_Z(subset_Praise1_Doublebuffer.Get_Position_Z());
                    break;
//===
//===
            }
        }
        private void SelectSetIntputSubset(
            int praiseEventId
        )
        {
            switch (praiseEventId)
            {
//===
//===
                case 0:
                    Framework.GetClient().GetData().GetThirdInputBuffer().Set_InputBuffer_SubSet(Framework.GetClient().GetData().GetUserIO().GetPraise0_Input());
                    break;

		        case 1:
                    Framework.GetClient().GetData().GetThirdInputBuffer().Set_InputBuffer_SubSet(Framework.GetClient().GetData().GetUserIO().GetPraise1_Input());
                    break;
//===
//===
            }
		}
    }
}
