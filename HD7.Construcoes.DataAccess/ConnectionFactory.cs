using System.Data.SqlClient;

namespace HD7.Construcoes.DataAccess
{
    public class ConnectionFactory
    {
        public static SqlConnection GetConnection()
        {
            var connectionString = "Server=localhost;Database=HD7;Integrated Security=True;";
            return new SqlConnection(connectionString);
        }
    }
}
