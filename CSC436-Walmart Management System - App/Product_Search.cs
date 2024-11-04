using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSC436_Walmart_Management_System___App
{
    public partial class Product_Search : Form
    {
        private DatabaseHelper dbHelper;

        public Product_Search(DatabaseHelper existingDbHelper)
        {
            InitializeComponent();
            dbHelper = existingDbHelper;
            LoadData(""); // Load initial data with an empty search

            // Explicitly link FormClosing event
            this.FormClosing += Product_Search_FormClosing;
        }

        private void LoadData(string searchTxt)
        {
            string query = "SELECT * FROM unit_price WHERE prod_name LIKE @prod_name";
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Parameters.AddWithValue("@prod_name", "%" + searchTxt + "%");

            DataTable dataTable = dbHelper.ExecuteQuery(cmd);
            dataGridView1.DataSource = dataTable;
        }

        private void Product_Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.Dispose(); // Dispose of the DatabaseHelper
            Application.Exit(); // Forcefully exit the application
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData(searchBox.Text);
        }
    }
}
