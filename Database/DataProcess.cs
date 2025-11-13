using CoffeeHouseABC.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ktra
{
    internal class DataProcess
    {
        static SqlConnection connection = null;
        private static void KetNoiCSDL()
        {
            connection = DatabaseConnection.GetConnection();
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }//Hàm đóng kết nối CSDL

        private static void DongKetNoiCSDL()
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
            connection.Dispose();
        }

        //Hàm thực thi câu lệnh dạng Select trả về một DataTable
        public static DataTable ReadTable(string sql)
        {
            DataTable dtBang = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqldataAdapte = new SqlDataAdapter(sql,
            connection);
            sqldataAdapte.Fill(dtBang);
            DongKetNoiCSDL();
            return dtBang;
        }

        //Hàm thực lệnh insert hoặc update hoặc delete
        public static void UpdateData(string sql)
        {
            KetNoiCSDL();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = connection;
            sqlcommand.CommandText = sql;
            sqlcommand.ExecuteNonQuery();
            DongKetNoiCSDL();
        }

    }
}
