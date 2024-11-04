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
            MySqlCommand cmd;
            DataTable dataTable = null;

            if (exactlyRad.Checked == true)
            {
                string query = "SELECT * FROM unit_price WHERE prod_name LIKE @prod_name";
                cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@prod_name", "%" + searchTxt + "%");
                dataTable = dbHelper.ExecuteQuery(cmd);
            }
            else if (anyRad.Checked == true)
            {

            }
            else if (allRad.Checked == true) 
            {
                
            }
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
