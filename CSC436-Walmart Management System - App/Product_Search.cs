using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSC436_Walmart_Management_System___App
{
    public partial class Product_Search : Form
    {
        private readonly DatabaseHelper dbHelper;

        public Product_Search(DatabaseHelper existingDbHelper)
        {
            InitializeComponent();
            dbHelper = existingDbHelper;
            PopulateStoreList();
            LoadData(""); // Load initial data with an empty search

            // Link FormClosing event
            this.FormClosing += Product_Search_FormClosing;
        }

        private void validateNumericKeypress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control keys, and the decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void LoadData(string searchTxt)
        {
            string[] searchArr = searchTxt.Split(new[] { ' ', '\t' }, StringSplitOptions.TrimEntries);
            MySqlCommand cmd = new MySqlCommand();
            List<string> conditions = BuildConditions(searchArr, cmd);

            string query = BuildQuery(conditions, cmd);

            // Set command text and execute query
            cmd.CommandText = query;
            dataGridView1.DataSource = dbHelper.ExecuteQuery(cmd);
        }

        private string BuildQuery(List<string> conditions, MySqlCommand cmd)
        {
            // Determine table and add any store ID condition
            string query = storeList.SelectedIndex != 0 ? "SELECT * FROM prod_list_by_store WHERE store_id = @store_id AND " : "SELECT * FROM unit_price WHERE ";
            if (storeList.SelectedIndex != 0)
            {
                cmd.Parameters.AddWithValue("@store_id", storeList.SelectedIndex);
            }

            // Add text search conditions
            query += string.Join(" ", conditions);

            // Add price range conditions
            AddPriceConditions(cmd, ref query);

            return query;
        }

        private List<string> BuildConditions(string[] searchArr, MySqlCommand cmd)
        {
            List<string> conditions = new List<string>();

            if (exactlyRad.Checked)
            {
                conditions.Add("prod_name LIKE @prod_name");
                cmd.Parameters.AddWithValue("@prod_name", "%" + string.Join(" ", searchArr) + "%");
            }
            else if (anyRad.Checked || allRad.Checked)
            {
                string logicOp = anyRad.Checked ? " OR " : " AND ";
                conditions.AddRange(CreateSearchConditions(searchArr, cmd, logicOp));
            }

            return conditions;
        }

        private IEnumerable<string> CreateSearchConditions(string[] searchArr, MySqlCommand cmd, string logicOp)
        {
            for (int i = 0; i < searchArr.Length; i++)
            {
                string paramName = $"@word{i}";
                cmd.Parameters.AddWithValue(paramName, "%" + searchArr[i] + "%");
                yield return $"prod_name LIKE {paramName}";
            }
        }

        private void AddPriceConditions(MySqlCommand cmd, ref string query)
        {
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
        }

        private void PopulateStoreList()
        {
            storeList.Items.Add("Any");
            storeList.Items.AddRange(dbHelper.GetStoreIDs().Cast<object>().ToArray());
            storeList.SelectedIndex = 0;
        }

        private void Product_Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.Dispose();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData(searchTxt.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Example: Extracting data from columns in the selected row
                int SKU = Convert.ToInt32(selectedRow.Cells["SKU"].Value);
                string productName = selectedRow.Cells["prod_name"].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells["price"].Value);

                // Create a new form and pass the data to it
                ProductDetailsForm detailsForm = new ProductDetailsForm(SKU, productName, price, dbHelper);
                detailsForm.ShowDialog();  // Show as a dialog box or use Show() if you don't want it modal
            }
        }
    }
}
