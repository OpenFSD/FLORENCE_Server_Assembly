using OpenTK.Mathematics;
using OpenTK.Windowing.Common;

namespace Server_Assembly
{
    public class Player
    {
        private bool _firstMove = false;
        private Vector3 player_Position;
        bool isMouseChanged = false;
        private Vector2 mousePos;
        const float cameraSpeed = 1.5f;
        const float sensitivity = 0.2f;

        public Player() 
        {
            _firstMove = true;
        }
       
        public bool Get_isFirstMove()
        {
            return _firstMove;
        }



        public void Set_mouse_X(Int16 value)
        {
            mousePos.X = value;
        }

        public void Set_mouse_Y(Int16 value)
        {
            mousePos.Y = value;
        }

        public void Set_player_Position_X(Int16 value)
        {
            player_Position.X = value;
        }

        public void Set_player_Position_Y(Int16 value)
        {
            player_Position.Y = value;
        }

        public void Set_player_Position_Z(Int16 value)
        {
            player_Position.Z = value;
        }
    }
}
