using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_DesignPattern.Models
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance = new DatabaseConnection();

        private DatabaseConnection()
        {
            Connection = new SqlConnection(ConnectionString);
        }

        public static DatabaseConnection GetInstance()
        {
            return instance;
        }

        private string ConnectionString = @"Server=DESKTOP-4K8O21F\SQLEXPRESS;Database=DP;Integrated Security=True;User Id=root;Password=root";

        private SqlConnection Connection;

        private SqlCommand Command;


        private void Connect()
        {
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
        }


        public int Execute(string query, List<SqlParameter> parameters)
        {
            Connect();

            Command = new SqlCommand(query, Connection);

            if (Command != null)
                foreach (var parameter in parameters)
                    Command.Parameters.Add(parameter);

            int result = Command.ExecuteNonQuery();

            Connection.Close();

            return result;
        }

        public DataTable Get(string query, List<SqlParameter> parameters)
        {
            Connect();

            Command = new SqlCommand(query, Connection);

            if (parameters != null)
                foreach (var parameter in parameters)
                    Command.Parameters.Add(parameter);

            SqlDataAdapter adapter = new SqlDataAdapter(Command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            Connection.Close();

            return dataTable;
        }

        public object Scalar(string query, List<SqlParameter> parameters)
        {
            Connect();

            Command = new SqlCommand(query, Connection);

            if (parameters != null)
                foreach (var parameter in parameters)
                    Command.Parameters.Add(parameter);

            object result = Command.ExecuteScalar();

            Connection.Close();

            return result;
        }

    }
}
