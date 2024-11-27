using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSC436_Walmart_Management_System___App {
    public partial class Product_Search : Form {
        private readonly DatabaseHelper dbHelper;

        public Product_Search(DatabaseHelper existingDbHelper) {
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

        private void validateNumericKeypress(object sender, KeyPressEventArgs e) {
            // Allow only digits, control keys, and the decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') {
                e.Handled = true;
            }
        }

        private void LoadData(string searchTxt) {
            string[] searchArr = searchTxt.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            MySqlCommand cmd = new MySqlCommand();
            List<string> conditions = BuildConditions(searchArr, cmd);

            string query = BuildQuery(conditions, cmd);

            // Set command text and execute query
            cmd.CommandText = query;
            dataGridView1.DataSource = dbHelper.ExecuteQuery(cmd);
        }

        private List<string> BuildConditions(string[] searchArr, MySqlCommand cmd) {
            List<string> conditions = new List<string>();

            // Add conditions for product name based on selected search logic
            if (exactlyRad.Checked) {
                conditions.Add("prod_name LIKE @prod_name");
                cmd.Parameters.AddWithValue("@prod_name", "%" + string.Join(" ", searchArr) + "%");
            }
            else if (anyRad.Checked || allRad.Checked) {
                string logicOp = anyRad.Checked ? " OR " : " AND ";
                conditions.AddRange(CreateSearchConditions(searchArr, cmd, logicOp));
            }

            return conditions;
        }

        private IEnumerable<string> CreateSearchConditions(string[] searchArr, MySqlCommand cmd, string logicOp) {
            List<string> conditions = new List<string>();
            for (int i = 0; i < searchArr.Length; i++) {
                string paramName = $"@word{i}";
                cmd.Parameters.AddWithValue(paramName, "%" + searchArr[i] + "%");
                conditions.Add($"prod_name LIKE {paramName}");
            }
            return new List<string> { string.Join(logicOp, conditions) };
        }

        private string BuildQuery(List<string> conditions, MySqlCommand cmd) {
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
            if (conditions.Count > 0) {
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

        private string BuildSelectClause(MySqlCommand cmd) {
            string selectClause = "";

            if (storeList.SelectedIndex != 0) {
                selectClause += ", stocks.store_id AS 'Store #'";
            }

            if (brandList.SelectedIndex != 0) {
                selectClause += ", manufactures.brand_ID AS 'Brand'";
            }

            return selectClause;
        }

        private string BuildJoinClauses(MySqlCommand cmd) {
            string joinClauses = "";

            if (storeList.SelectedIndex != 0) {
                joinClauses += " LEFT OUTER JOIN stocks ON unit_price.SKU = stocks.SKU";
            }

            if (brandList.SelectedIndex != 0) {
                joinClauses += " LEFT OUTER JOIN manufactures ON unit_price.SKU = manufactures.SKU " +
                               "LEFT OUTER JOIN brand ON manufactures.brand_ID = brand.brand_ID";
            }

            if (deptList.SelectedIndex != 0) {
                joinClauses += " JOIN department ON unit_price.dept_id = department.dept_id";
            }

            return joinClauses;
        }

        private void AddPriceConditions(MySqlCommand cmd, ref string query) {
            if (!string.IsNullOrEmpty(minTxt?.Text)) {
                query += " AND unit_price.price >= @min_price";
                cmd.Parameters.AddWithValue("@min_price", minTxt.Text);
            }

            if (!string.IsNullOrEmpty(maxTxt?.Text)) {
                query += " AND unit_price.price <= @max_price";
                cmd.Parameters.AddWithValue("@max_price", maxTxt.Text);
            }
        }

        private void AddStoreCondition(MySqlCommand cmd, ref string query) {
            if (storeList.SelectedIndex != 0) {
                query += " AND stocks.store_id = @store_id";
                cmd.Parameters.AddWithValue("@store_id", storeList.SelectedItem.ToString());
            }
        }

        private void AddDeptCondition(MySqlCommand cmd, ref string query) {
            if (deptList.SelectedIndex != 0) {
                query += " AND unit_price.dept_id = @dept_id";
                cmd.Parameters.AddWithValue("@dept_id", deptList.SelectedIndex);
            }
        }

        private void AddBrandCondition(MySqlCommand cmd, ref string query) {
            if (brandList.SelectedIndex != 0) {
                query += " AND manufactures.brand_ID = @brand_ID";
                cmd.Parameters.AddWithValue("@brand_ID", brandList.SelectedItem.ToString());
            }
        }

        private void AddSkuCondition(MySqlCommand cmd, ref string query) {
            if (!string.IsNullOrEmpty(skuTxt?.Text)) {
                query += " AND unit_price.SKU = @sku";
                cmd.Parameters.AddWithValue("@sku", skuTxt.Text);
            }
        }

        private void PopulateComboBox(ComboBox comboBox, List<object> items, string defaultItem) {
            comboBox.Items.Add(defaultItem);
            comboBox.Items.AddRange(items.ToArray());
            comboBox.SelectedIndex = 0;
        }

        private void Product_Search_FormClosing(object sender, FormClosingEventArgs e) {
            dbHelper.Dispose();
            Application.Exit();
        }

        

        private void searchBtn_Click(object sender, EventArgs e) {
            if (prod_search_rad.Checked) {
                LoadData(prodNameTxt.Text);
            }
            else if (add_prod_rad.Checked) {
                AddProduct();
            }
        }

        private void AddProduct() {
            // check that all fields [prodNameTxt(max char:100), skuTxt, minTxt, sizeTxt] are filled and brandList and deptList index 0 are not selected and set prodErr state given field can't be empty
            bool prodErr = false;
            if (prodNameTxt.Text == "") {
                prodErr = true;
                MessageBox.Show("Product Name cannot be empty.");
            }
            if (skuTxt.Text == "") {
                prodErr = true;
                MessageBox.Show("SKU cannot be empty.");
            }
            if (minTxt.Text == "") {
                prodErr = true;
                MessageBox.Show("Minimum Price cannot be empty.");
            }
            if (sizeTxt.Text == "") {
                prodErr = true;
                MessageBox.Show("Size cannot be empty.");
            }
            if (brandList.SelectedIndex == 0) {
                prodErr = true;
                MessageBox.Show("Brand cannot be empty.");
            }
            if (deptList.SelectedIndex == 0) {
                prodErr = true;
                MessageBox.Show("Department cannot be empty.");
            }
            if (!prodErr) {
                // check that skuTxt is a number and set skuErr state given skuTxt is not a number
                bool skuErr = false;
                if (!int.TryParse(skuTxt.Text, out int sku)) {
                    skuErr = true;
                    MessageBox.Show("SKU must be a number.");
                }
                if (!skuErr) {
                    // check that minTxt is a number and set minErr state given minTxt is not a number
                    bool minErr = false;
                    if (!decimal.TryParse(minTxt.Text, out decimal min)) {
                        minErr = true;
                        MessageBox.Show("Minimum Price must be a number.");
                    }
                    if (!minErr) {
                        // check that sizeTxt is a number and set sizeErr state given sizeTxt is not a number
                        bool sizeErr = false;
                        if (!decimal.TryParse(sizeTxt.Text, out decimal size)) {
                            sizeErr = true;
                            MessageBox.Show("Size must be a number.");
                        }
                        if (!sizeErr) {
                            // check that unitList index 0 is not selected and set unitErr state given unitList index 0 is selected
                            bool unitErr = false;
                           
                            if (!unitErr) {
                                // check that skuTxt is not already in the database and set skuErr state given skuTxt is already in the database
                                bool skuExists = dbHelper.SkuExists(sku);
                                if (skuExists) {
                                    MessageBox.Show("SKU already exists in the database.");
                                }
                                if (!skuExists) {
                                    // insert product into database
                                    dbHelper.InsertProduct(sku, prodNameTxt.Text, min, size, brandList.SelectedItem.ToString(), deptList.SelectedIndex, unitList.SelectedItem.ToString());
                                    // insert product into stocks table for each store in storeList if storeList index 0 is selected otherwise insert product into stocks table for the store selected in storeList
                                    if (storeList.SelectedIndex == 0) {
                                        List<int> storeIDs = dbHelper.GetStoreIDs();
                                        foreach (int storeID in storeIDs) {
                                            dbHelper.InsertStocks(storeID, sku);
                                        }
                                        MessageBox.Show("Product added successfully.");
                                    }
                                    else {
                                        dbHelper.InsertStocks(storeList.SelectedIndex, sku);
                                        MessageBox.Show("Product added successfully.");
                                    }
                                    // insert product in manufactures table with sku and brandList selected item
                                    dbHelper.InsertManufactures(sku, brandList.SelectedItem.ToString());
                                }
                            }
                        }
                    }
                }
            }


            MessageBox.Show("Add Product functionality is under development.");
        }

        private void ToggleMode(object sender, EventArgs e) {
            bool isSearchMode = prod_search_rad.Checked;

            unitGrpBox.Enabled = !isSearchMode;
            searchBtn.Text = isSearchMode ? "Search" : "Add Product";
            maxTxt.Visible = isSearchMode ? true : false;
            maxLbl.Visible = isSearchMode ? true : false;
            minLbl.Visible = isSearchMode ? true : false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int SKU = Convert.ToInt32(selectedRow.Cells["SKU"].Value);
                string productName = selectedRow.Cells["prod_name"].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells["price"].Value);

                ProductDetailsForm detailsForm = new ProductDetailsForm(SKU, productName, price, dbHelper);
                detailsForm.ShowDialog();
            }
        }
    }
}
