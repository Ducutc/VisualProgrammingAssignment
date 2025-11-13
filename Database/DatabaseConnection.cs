using CoffeeHouseABC.Models;
using Microsoft.Data.SqlClient;

namespace CoffeeHouseABC.Database
{
    public class DatabaseConnection
    {
        private static readonly string connectionString = "Data Source=DATPHUNG;Initial Catalog=CoffeeHouseABC;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using SqlConnection conn = GetConnection();
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    
}