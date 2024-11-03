using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

public class DatabaseHelper
{
    string connectionString;

    public DatabaseHelper()
    {
        // Replace with your actual database details
        string server = "127.0.0.1";
        string database = "Walmart_Product_Manager";
        string user = "root";
        string password = System.Environment.GetEnvironmentVariable("DEV_TESTING_PASS") ?? throw new InvalidOperationException("DEV_TESTING_PASS environment variable is not set.");
        string port = "3306";

        // Build the connection string
        connectionString = $"Server={server};Port={port};Database={database};User ID={user};Password={password};SslMode=none;";
    }

    public DataTable ExecuteQuery(string query)
    {
        DataTable dataTable = new DataTable();

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        return dataTable;
    }
}