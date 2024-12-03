using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public class DatabaseHelper : IDisposable {
    private MySqlConnection conn;
    private string connectionString;

    public DatabaseHelper() {
        string server = "127.0.0.1";
        string database = "Walmart_Product_Manager";
        string user = "root";
        string password = Environment.GetEnvironmentVariable("DEV_TESTING_PASS")
                          ?? throw new InvalidOperationException("DEV_TESTING_PASS environment variable is not set.");
        string port = "3306";

        connectionString = $"Server={server};Port={port};Database={database};User ID={user};Password={password};SslMode=none;";
        conn = new MySqlConnection(connectionString);
    }

    public DataTable ExecuteQuery(MySqlCommand cmd) {
        DataTable dataTable = new DataTable();
        cmd.Connection = conn;

        try {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dataTable);
        }
        catch (Exception ex) {
            MessageBox.Show($"Error executing query: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally {
            conn.Close();
        }

        return dataTable;
    }

    public List<int> GetStoreIDs() {
        List<int> storeIDs = new List<int>();
        string query = "SELECT store_id FROM store";

        try {
            using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            storeIDs.Add(reader.GetInt32("store_id"));
                        }
                    }
                }
            }
        }
        catch (Exception ex) {
            MessageBox.Show($"Error fetching store IDs: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return storeIDs;
    }

    public List<string> GetBrands() {
        List<string> brands = new List<string>();
        string query = "SELECT brand_ID FROM brand";

        try {
            using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            brands.Add(reader.GetString("brand_ID"));
                        }
                    }
                }
            }
        }
        catch (Exception ex) {
            MessageBox.Show($"Error fetching brands: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return brands;
    }

    public List<(int, string)> GetDepartments() {
        List<(int, string)> departments = new List<(int, string)>();
        string query = "SELECT dept_id, dept_name FROM department";

        try {
            using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            int deptId = reader.GetInt32("dept_id");
                            string deptName = reader.GetString("dept_name");
                            departments.Add((deptId, deptName));
                        }
                    }
                }
            }
        }
        catch (Exception ex) {
            MessageBox.Show($"Error fetching departments: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return departments;
    }

    public bool SkuExists(int sku) {
        string query = "SELECT COUNT(*) FROM unit_price WHERE SKU = @sku";
        bool exists = false;

        try {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@sku", sku);

            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            exists = count > 0;
        }
        catch (Exception ex) {
            MessageBox.Show($"Error checking SKU existence: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally {
            conn.Close();
        }

        return exists;
    }

    public void InsertProduct(int sku, string prodName, decimal minPrice, decimal size, string brand, int deptId, string unit) {
        try {
            using (MySqlCommand cmd = new MySqlCommand()) {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product (SKU, dept_id, prod_name, size, unit, price) " +
                                  "VALUES (@sku, @deptId, @prodName, @size, @unit, @minPrice)";
                cmd.Parameters.AddWithValue("@sku", sku);
                cmd.Parameters.AddWithValue("@prodName", prodName);
                cmd.Parameters.AddWithValue("@minPrice", minPrice);
                cmd.Parameters.AddWithValue("@size", size);
                cmd.Parameters.AddWithValue("@deptId", deptId);
                cmd.Parameters.AddWithValue("@unit", unit);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex) {
            MessageBox.Show($"Error inserting product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally {
            conn.Close();
        }
    }

    public void Dispose() {
        if (conn != null && conn.State == ConnectionState.Open) {
            conn.Close();
            conn.Dispose();
        }
    }

    public void InsertStocks(int storeID, int sku) {
        try {
            using (MySqlCommand cmd = new MySqlCommand()) {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO stocks (store_id, SKU) VALUES (@store_id, @sku)";
                cmd.Parameters.AddWithValue("@store_id", storeID);
                cmd.Parameters.AddWithValue("@sku", sku);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex) {
            MessageBox.Show($"Error inserting stocks: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally {
            conn.Close();
        }
    }

    public void InsertManufactures(int sku, string brandID) {
        try {
            using (MySqlCommand cmd = new MySqlCommand()) {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO manufactures (SKU, brand_ID) VALUES (@sku, @brandID)";
                cmd.Parameters.AddWithValue("@sku", sku);
                cmd.Parameters.AddWithValue("@brandID", brandID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex) {
            MessageBox.Show($"Error inserting manufactures: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally {
            conn.Close();
        }
    }

    internal bool BrandExists(string brandId){
        // Check if brand ID already exists in the brand table
        string query = "SELECT COUNT(*) FROM brand WHERE brand_ID = @brandID";
        bool exists = false;

        try
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@brandID", brandId);

            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            exists = count > 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error checking Brand existence: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            conn.Close();
        }

        return exists;
    }

    internal void InsertBrand(string brandID, string brandName, bool @store_brand){
        // insert into brand table brandID, brandName, store_brand
        try
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO brand (brand_ID, brand_name, chain_exclusive) VALUES (@brandID, @brandName, @store_brand)";
                cmd.Parameters.AddWithValue("@brandID", brandID);
                cmd.Parameters.AddWithValue("@brandName", brandName);
                cmd.Parameters.AddWithValue("@store_brand", store_brand);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error inserting brand: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            conn.Close();
        }
    }
}

