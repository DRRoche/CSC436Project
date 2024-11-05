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

        private string[] strToArray(string input)
        {
            return input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void LoadData(string searchTxt)
        {
            DataTable dataTable = new DataTable();
            string[] searchArr = strToArray(searchTxt);
            string query = "SELECT * FROM unit_price WHERE ";
            MySqlCommand cmd = new MySqlCommand(); // Initialize cmd here

            if (exactlyRad.Checked)
            {
                query += "prod_name LIKE @prod_name";
                cmd.Parameters.AddWithValue("@prod_name", "%" + searchTxt + "%");
            }
            else if (anyRad.Checked)
            {
                // Construct query for any word in searchArr
                List<string> conditions = new List<string>();
                for (int i = 0; i < searchArr.Length; i++)
                {
                    conditions.Add("prod_name LIKE @word" + i);
                    cmd.Parameters.AddWithValue("@word" + i, "%" + searchArr[i] + "%");
                }
                query += string.Join(" OR ", conditions);
            }
            else if (allRad.Checked)
            {
                // Construct query for all words in searchArr
                List<string> conditions = new List<string>();
                for (int i = 0; i < searchArr.Length; i++)
                {
                    conditions.Add("prod_name LIKE @word" + i);
                    cmd.Parameters.AddWithValue("@word" + i, "%" + searchArr[i] + "%");
                }
                query += string.Join(" AND ", conditions);
            }

            cmd.CommandText = query; // Set the command text after building the query

            // Execute the query and bind the results to the DataGridView
            dataTable = dbHelper.ExecuteQuery(cmd);
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
