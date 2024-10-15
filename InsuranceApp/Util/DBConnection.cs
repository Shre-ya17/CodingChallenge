using System.Data.SqlClient;
using System.Configuration;

namespace Util
{
    public class DBConnection
    {
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            return connection;
        }
    }
}
