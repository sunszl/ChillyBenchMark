namespace ChillyBenchMarkNet.Utils
{
    public class SqlHelper
    {
        #region
        private static readonly int SqlModePgSQL = 1;
        private static readonly int SqlModeMySQL = 2;
        #endregion

        private static int _SqlMode = 0;
        private static string _connectionString = "";

        public static void InitSqlHelper(int theSqlMode, string theConnectionString )
        {

        }


    }
}
