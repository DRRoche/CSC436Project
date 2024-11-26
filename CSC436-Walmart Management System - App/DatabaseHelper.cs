using System;
using System.Data;
using MySql.Data.MySqlClient;

public class DatabaseHelper : IDisposable
{
    private MySqlConnection conn;
    private string connectionString;

    public DatabaseHelper()
    {
        string server = "127.0.0.1";
        string database = "Walmart_Product_Manager";
        string user = "root";
        string password = System.Environment.GetEnvironmentVariable("DEV_TESTING_PASS") ?? throw new InvalidOperationException("DEV_TESTING_PASS environment variable is not set.");
        string port = "3306";

        connectionString = $"Server={server};Port={port};Database={database};User ID={user};Password={password};SslMode=none;";
        conn = new MySqlConnection(connectionString);
    }

    public DataTable ExecuteQuery(MySqlCommand cmd)
    {
        DataTable dataTable = new DataTable();
        cmd.Connection = conn;

        if (conn.State != ConnectionState.Open)
            conn.Open();

        try
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        return dataTable;
    }

    public List<int> GetStoreIDs()
    {
        List<int> storeIDs = new List<int>();
        string query = "SELECT store_id FROM store";

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        storeIDs.Add(reader.GetInt32("store_id"));
                    }
                }
            }
        }
        return storeIDs;
    }

    public List<string> GetBrands()
    {
        List<string> brands = new List<string>();
        string query = "SELECT brand_name FROM brand";

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        brands.Add(reader.GetString("brand_name"));
                    }
                }
            }
        }
        return brands;
    }

    public List<(int, string)> GetDepartments()
    {
        List<(int, string)> departments = new List<(int, string)>();
        string query = "SELECT dept_id, dept_name FROM department";

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int deptId = reader.GetInt32("dept_id");
                        string deptName = reader.GetString("dept_name");
                        departments.Add((deptId, deptName));
                    }
                }
            }
        }
        return departments;
    }

    public void Dispose()
    {
        if (conn != null && conn.State == ConnectionState.Open)
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
