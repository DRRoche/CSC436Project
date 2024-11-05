using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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

        private void validateNumericKeypress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit and not a control key (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.' ))
            {
                e.Handled = true; // Reject the input
            }
        }

        private string[] strToArray(string input)
        {
            return input.Split(new[] { ' ', '\t' }, StringSplitOptions.TrimEntries);
        }

        private void LoadData(string searchTxt)
        {
            DataTable dataTable = new DataTable();
            string[] searchArr = strToArray(searchTxt);
            string query = "SELECT * FROM unit_price WHERE ";
            MySqlCommand cmd = new MySqlCommand();
            List<string> conditions = new List<string>();

            if (exactlyRad.Checked)
            {
                query += "prod_name LIKE @prod_name";
                cmd.Parameters.AddWithValue("@prod_name", "%" + searchTxt + "%");
            }
            else if (anyRad.Checked)
            {
                // Construct query for any word in searchArr
                query = ConstructLikeQuery(searchArr, query, cmd, conditions, " OR ");
            }
            else if (allRad.Checked)
            {
                // Construct query for all words in searchArr
                query = ConstructLikeQuery(searchArr, query, cmd, conditions, " AND ");
            }
            if (!string.IsNullOrEmpty(minTxt?.Text))
            {
                query += " AND price >= @min_price";
                cmd.Parameters.AddWithValue("@min_price", minTxt.Text);
            }
            if (!string.IsNullOrEmpty(maxTxt?.Text))
            {
                query += " AND price <= @max_price";
                cmd.Parameters.AddWithValue("@max_price", maxTxt.Text);
            }

            cmd.CommandText = query; // Set the command text after building the query

            // Execute the query and bind the results to the DataGridView
            dataTable = dbHelper.ExecuteQuery(cmd);
            dataGridView1.DataSource = dataTable;

            static string ConstructLikeQuery(string[] searchArr, string query, MySqlCommand cmd, List<string> conditions, string logicOp)
            {
                for (int i = 0; i < searchArr.Length; i++)
                {
                    conditions.Add("prod_name LIKE @word" + i);
                    cmd.Parameters.AddWithValue("@word" + i, "%" + searchArr[i] + "%");
                }
                query += string.Join(logicOp, conditions);
                return query;
            }

            

        }



        private void Product_Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.Dispose(); // Dispose of the DatabaseHelper
            Application.Exit(); // Forcefully exit the application
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData(searchTxt.Text);
        }
    }
}
