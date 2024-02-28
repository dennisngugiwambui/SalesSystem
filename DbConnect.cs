using System;
using System.Data;
using System.Data.SqlClient;


namespace SalesSystem
{
    public class DbConnect 
    {
        private SqlConnection connection;
        private string connectionString;

        public SqlConnection Connection { get { return connection; } }

        public DbConnect()
        {
            connectionString = "Data Source=DESKTOP-SEM7QMC\\SQLEXPRESS;Initial Catalog=SalesSystem;Persist Security Info=True;User ID=smartenduser;Password=l0l0t1ng@2209;TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);
        }

        public void SetConnectionString(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                OpenConnection();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while executing the query: " + ex.Message);
                MessageBox.Show("An error occured while executing the query" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }


        public void Dispose()
        {
            CloseConnection();
            connection.Dispose();
        }
        public object ExecuteScalar(string query)
        {
           using (SqlCommand command = new SqlCommand(query, connection))
           {
                OpenConnection();
                object result = command.ExecuteScalar();
                CloseConnection();
                return result;
           }
        }

        public DataTable ExecuteParameterizedQuery(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
        }
    }
}
