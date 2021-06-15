using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Controls;
using System.Data.SqlClient;
namespace WpfApp5
{
    class Class1
    {
        public static string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danek\source\repos\WpfApp5\WpfApp5\Database1.mdf;Integrated Security=True";
        public static bool RegUsers(string login,string pass, string fio,string email,string tel, string birthday)
        {
            if(IsExistUser(login)== true)
            {
                return false;
            }
            SqlConnection connection = new SqlConnection(connection_string);
            string sql = $"INSERT INTO Users (Login_user,Pass_user,FIO_user,Email_user,Tel_user,Birthday_user) " +
                $"VALUES ('{login}','{pass}','{fio}','{email}','{tel}','{birthday}')";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        public static int VhodUsers(string login,string pass)
        {
            SqlConnection connection = new SqlConnection(connection_string);
            string sql = $"SELECT Id From Users WHERE Login_user='{login}' AND Pass_user='{pass}'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int id = Convert.ToInt32(reader[0].ToString());
                connection.Close();
                return id;
                
            }
            connection.Close();
            return -1;
            
        }
        public static bool IsExistUser(string login)
        {
            SqlConnection connection = new SqlConnection(connection_string);
            string sql = $"SELECT Login_user From Users WHERE Login_user='{login}'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;

        }
        public static void FillDataGrid(DataGrid grid)
        {
            SqlConnection connection = new SqlConnection(connection_string);
            string sql = $"SELECT Login_user,Pass_user,FIO_user,Email_user,Tel_user,Birthday_user From Users";
            SqlCommand command = new SqlCommand(sql, connection);
            DataTable table = new DataTable();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            grid.ItemsSource = table.DefaultView;
            connection.Close();
        }
    }
}
