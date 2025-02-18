namespace Server_Assembly
{
    public class Game_Instance
    {
        static private Server_Assembly.game_Instance.Arena arena;
        static private Server_Assembly.game_Instance.Map_Default mapDefault;
        static private Server_Assembly.game_Instance.Settings settings;
        static private Server_Assembly.game_Instance.Player[] player;

        public Game_Instance()
        {
            arena = new Server_Assembly.game_Instance.Arena();
            while (arena == null) { /* Wait while is created */ }

            settings = new Server_Assembly.game_Instance.Settings();
            while (settings == null) { /* Wait while is created */ }

            mapDefault = new Server_Assembly.game_Instance.Map_Default();
            while (mapDefault == null) { /* Wait while is created */ }

            player = new Server_Assembly.game_Instance.Player[2];
            for (ushort numberOfPlayers = 0; numberOfPlayers < 2; numberOfPlayers++)
            {
                player[numberOfPlayers] = new Server_Assembly.game_Instance.Player();
                while (player[numberOfPlayers] == null) { /* Wait while is created */ }
            }
        }
        public void Initalise_Graphics()
        {
            using (var graphics = new Server_Assembly.game_Instance.gFX.Graphics(
                Framework.GetGameServer().GetData().GetGame_Instance().GetSettings().GetGameWindowSettings(),
                Framework.GetGameServer().GetData().GetGame_Instance().GetSettings().GetNativeWindowSettings()
            ))
            {
                graphics.Run();
            }
        }

        public Server_Assembly.game_Instance.Arena GetArena()
        {
            return arena;
        }

        public Server_Assembly.game_Instance.Map_Default GetMapDefault()
        {
            return mapDefault;
        }

        public Server_Assembly.game_Instance.Settings GetSettings()
        {
            return settings;
        }

        public Server_Assembly.game_Instance.Player GetPlayer(ushort index_playerID)
        {
            return player[index_playerID];
        }

        public void SetAdd_NewPlayer(Server_Assembly.game_Instance.Player value)
        {/*
            settings.Add_Player();
            player = new Server_Assembly.Player[settings.GetNumberOfPlayers()];

            player[settings.GetNumberOfPlayers()-1] = value;

        */
        }
    }
}
