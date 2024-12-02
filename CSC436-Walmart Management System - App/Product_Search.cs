using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSC436_Walmart_Management_System___App {
    public partial class Product_Search : Form
    {
        private readonly DatabaseHelper dbHelper;

        public Product_Search(DatabaseHelper existingDbHelper)
        {
            InitializeComponent();
            dbHelper = existingDbHelper;

            // Populate combo boxes with initial data
            PopulateComboBox(storeList, dbHelper.GetStoreIDs().Cast<object>().ToList(), "Any");
            PopulateComboBox(brandList, dbHelper.GetBrands().Cast<object>().ToList(), "Any");
            PopulateComboBox(deptList, dbHelper.GetDepartments().Select(d => (object)d.Item2).ToList(), "Any");
            PopulateComboBox(unitList, ["ml", "lt", "lb", "pcs"], "oz");
            LoadData(""); // Load initial data with an empty search

            // Link FormClosing event
            this.FormClosing += Product_Search_FormClosing;

            // Attach event handlers for radio button changes
            prod_search_rad.CheckedChanged += ToggleMode;
            add_prod_rad.CheckedChanged += ToggleMode;
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
            string[] searchArr = searchTxt.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            MySqlCommand cmd = new MySqlCommand();
            List<string> conditions = BuildConditions(searchArr, cmd);

            string query = BuildQuery(conditions, cmd);

            // Set command text and execute query
            cmd.CommandText = query;
            dataGridView1.DataSource = dbHelper.ExecuteQuery(cmd);
            dataGridView1_Resize();
        }

        private List<string> BuildConditions(string[] searchArr, MySqlCommand cmd)
        {
            List<string> conditions = new List<string>();

            // Add conditions for product name based on selected search logic
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
            List<string> conditions = new List<string>();
            for (int i = 0; i < searchArr.Length; i++)
            {
                string paramName = $"@word{i}";
                cmd.Parameters.AddWithValue(paramName, "%" + searchArr[i] + "%");
                conditions.Add($"prod_name LIKE {paramName}");
            }
            return new List<string> { string.Join(logicOp, conditions) };
        }

        private string BuildQuery(List<string> conditions, MySqlCommand cmd)
        {
            // Base SELECT query
            string query = "SELECT unit_price.SKU, unit_price.dept_name AS 'Department', " +
                           "unit_price.prod_name AS 'Product', unit_price.size, unit_price.price, " +
                           "unit_price.unit_price AS 'Unit Price', unit_price.unit";

            // Dynamically add columns based on selected filters
            query += BuildSelectClause(cmd);

            // Base table
            query += " FROM unit_price";

            // Join conditions
            query += BuildJoinClauses(cmd);

            // WHERE clause with dynamic conditions
            if (conditions.Count > 0)
            {
                query += " WHERE " + string.Join(" AND ", conditions);
            }

            // Additional filters
            AddStoreCondition(cmd, ref query);
            AddPriceConditions(cmd, ref query);
            AddDeptCondition(cmd, ref query);
            AddBrandCondition(cmd, ref query);
            AddSkuCondition(cmd, ref query);

            return query;
        }

        private string BuildSelectClause(MySqlCommand cmd)
        {
            string selectClause = "";

            if (storeList.SelectedIndex != 0)
            {
                selectClause += ", stocks.store_id AS 'Store #'";
            }

            if (brandList.SelectedIndex != 0)
            {
                selectClause += ", manufactures.brand_ID AS 'Brand'";
            }

            return selectClause;
        }

        private string BuildJoinClauses(MySqlCommand cmd)
        {
            string joinClauses = "";

            if (storeList.SelectedIndex != 0)
            {
                joinClauses += " LEFT OUTER JOIN stocks ON unit_price.SKU = stocks.SKU";
            }

            if (brandList.SelectedIndex != 0)
            {
                joinClauses += " LEFT OUTER JOIN manufactures ON unit_price.SKU = manufactures.SKU " +
                               "LEFT OUTER JOIN brand ON manufactures.brand_ID = brand.brand_ID";
            }

            if (deptList.SelectedIndex != 0)
            {
                joinClauses += " JOIN department ON unit_price.dept_id = department.dept_id";
            }

            return joinClauses;
        }

        private void AddPriceConditions(MySqlCommand cmd, ref string query)
        {
            if (!string.IsNullOrEmpty(minTxt?.Text))
            {
                query += " AND unit_price.price >= @min_price";
                cmd.Parameters.AddWithValue("@min_price", minTxt.Text);
            }

            if (!string.IsNullOrEmpty(maxTxt?.Text))
            {
                query += " AND unit_price.price <= @max_price";
                cmd.Parameters.AddWithValue("@max_price", maxTxt.Text);
            }
        }

        private void AddStoreCondition(MySqlCommand cmd, ref string query)
        {
            if (storeList.SelectedIndex != 0)
            {
                query += " AND stocks.store_id = @store_id";
                cmd.Parameters.AddWithValue("@store_id", storeList.SelectedItem.ToString());
            }
        }

        private void AddDeptCondition(MySqlCommand cmd, ref string query)
        {
            if (deptList.SelectedIndex != 0)
            {
                query += " AND unit_price.dept_id = @dept_id";
                cmd.Parameters.AddWithValue("@dept_id", deptList.SelectedIndex);
            }
        }

        private void AddBrandCondition(MySqlCommand cmd, ref string query)
        {
            if (brandList.SelectedIndex != 0)
            {
                query += " AND manufactures.brand_ID = @brand_ID";
                cmd.Parameters.AddWithValue("@brand_ID", brandList.SelectedItem.ToString());
            }
        }

        private void AddSkuCondition(MySqlCommand cmd, ref string query)
        {
            if (!string.IsNullOrEmpty(skuTxt?.Text))
            {
                query += " AND unit_price.SKU = @sku";
                cmd.Parameters.AddWithValue("@sku", skuTxt.Text);
            }
        }

        private void PopulateComboBox(ComboBox comboBox, List<object> items, string defaultItem)
        {
            comboBox.Items.Add(defaultItem);
            comboBox.Items.AddRange(items.ToArray());
            comboBox.SelectedIndex = 0;
        }

        private void Product_Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.Dispose();
            Application.Exit();
        }



        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (prod_search_rad.Checked)
            {
                LoadData(prodNameTxt.Text);
            }
            else if (add_prod_rad.Checked)
            {
                AddProduct();
            }
        }

        private void AddProduct()
        {
            // Validate product fields
            if (prodNameTxt.Text == "")
            {
                ShowError("Product Name cannot be empty.");
                return;
            }

            if (skuTxt.Text == "")
            {
                ShowError("SKU cannot be empty.");
                return;
            }

            if (minTxt.Text == "")
            {
                ShowError("Minimum Price cannot be empty.");
                return;
            }

            if (sizeTxt.Text == "")
            {
                ShowError("Size cannot be empty.");
                return;
            }

            if (brandList.SelectedIndex == 0)
            {
                ShowError("Brand cannot be empty.");
                return;
            }

            if (deptList.SelectedIndex == 0)
            {
                ShowError("Department cannot be empty.");
                return;
            }

            // Validate SKU as integer
            if (!int.TryParse(skuTxt.Text, out int sku))
            {
                ShowError("SKU must be a number.");
                return;
            }

            // Validate Minimum Price as decimal
            if (!decimal.TryParse(minTxt.Text, out decimal min))
            {
                ShowError("Minimum Price must be a number.");
                return;
            }

            // Validate Size as decimal
            if (!decimal.TryParse(sizeTxt.Text, out decimal size))
            {
                ShowError("Size must be a number.");
                return;
            }

            // Check if SKU exists in the database
            if (dbHelper.SkuExists(sku))
            {
                ShowError("SKU already exists in the database.");
                return;
            }

            // Insert product into the database
            dbHelper.InsertProduct(sku, prodNameTxt.Text, min, size, brandList.SelectedItem.ToString(), deptList.SelectedIndex, unitList.SelectedItem.ToString());

            // Insert product into stocks table
            if (storeList.SelectedIndex == 0)
            {
                List<int> storeIDs = dbHelper.GetStoreIDs();
                foreach (int storeID in storeIDs)
                {
                    dbHelper.InsertStocks(storeID, sku);
                }
            }
            else
            {
                dbHelper.InsertStocks(storeList.SelectedIndex, sku);
            }

            // Insert product into manufactures table
            dbHelper.InsertManufactures(sku, brandList.SelectedItem.ToString());

            MessageBox.Show("Product added successfully.");
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message);
        }

        private void ToggleMode(object sender, EventArgs e)
        {
            bool isSearchMode = prod_search_rad.Checked;

            unitGrpBox.Enabled = !isSearchMode;
            searchBtn.Text = isSearchMode ? "Search" : "Add Product";
            maxTxt.Visible = isSearchMode ? true : false;
            maxLbl.Visible = isSearchMode ? true : false;
            minLbl.Visible = isSearchMode ? true : false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int SKU = Convert.ToInt32(selectedRow.Cells["SKU"].Value);
                string productName = selectedRow.Cells["Product"].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells["price"].Value);

                ProductDetailsForm detailsForm = new ProductDetailsForm(SKU, productName, price, dbHelper);
                detailsForm.ShowDialog();
                LoadData(prodNameTxt.Text);
            }
        }

        // Add function to resize datagradview1 columns(0,1,3,4,5,6) to fit the content
        private void dataGridView1_Resize()
        {
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void addBrandBtn_Click(object sender, EventArgs e)
        {
            BrandAdder brandAdder = new BrandAdder(dbHelper);
            brandAdder.ShowDialog();
            brandList.Items.Clear();
            PopulateComboBox(brandList, dbHelper.GetBrands().Cast<object>().ToList(), "Any");
        }
    }
}
