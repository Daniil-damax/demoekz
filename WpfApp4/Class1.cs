using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
namespace WpfApp4
{
    class Class1
    {
        public static string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danek\source\repos\WpfApp4\WpfApp4\Database1.mdf;Integrated Security=True";
        public static bool VhodAdmin(string login, string pass)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            string sql = $"SELECT Login,Pass from Admins";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);

            SqlDataReader reader= comm.ExecuteReader();
            while (reader.Read())
            {
                if(reader[0].ToString() == login && reader[1].ToString() == pass)
                {
                    conn.Close();
                    return true;
                }
               
            }
            conn.Close();
            return false;

        }
        public static void CreateAdmin(string login, string pass)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            string sql = $"INSERT INTO Admins (Login,Pass) VALUES ('{login}','{pass}')";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
        }
        public static void FillData(DataGrid data)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            string sql = $"SELECT * FROM Admins";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            data.ItemsSource = table.DefaultView;
            conn.Close();
        }
    }
}
