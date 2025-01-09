namespace Server_Assembly
{
    public class Global
    {
        static private UInt16 numberOfCores;

        public Global()
        {
            numberOfCores = 4;
        }
        public int Get_NumCores()
        {
            return numberOfCores;
        }
    }
}
