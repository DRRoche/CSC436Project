using System.Data;

namespace CSC436_Walmart_Management_System___App
{
    public partial class Employee_Manager : Form
    {
        private readonly DatabaseHelper dbHelper;

        public Employee_Manager(DatabaseHelper existingDbHelper)
        {
            InitializeComponent();
            dbHelper = existingDbHelper;

            // Populate combo boxes with initial data
            PopulateComboBox(positionList, dbHelper.GetRoles().Cast<object>().ToList(), "Any");
            PopulateComboBox(payrollTypeList, dbHelper.GetPayrollTypes().Cast<object>().ToList(), "Any");
            PopulateComboBox(storeList, dbHelper.GetStoreIDs().Cast<object>().ToList(), "All");

            LoadEmployeeData(""); // Load initial data with an empty search

            // Attach event handlers
            searchRad.CheckedChanged += ToggleMode;
            addEmployeeRad.CheckedChanged += ToggleMode;
        }

        private void LoadEmployeeData(string searchTxt)
        {
            try
            {
                string selectedPosition = positionList.SelectedItem.ToString();
                string selectedPayrollType = payrollTypeList.SelectedItem.ToString();
                string storeId = storeList.SelectedIndex == 0 ? "" : storeList.SelectedIndex.ToString();

                // Determine search match mode
                bool matchExact = exactlyRad.Checked;
                bool matchAny = anyRad.Checked;

                DataTable results = dbHelper.GetEmployees(searchTxt, selectedPosition, selectedPayrollType, storeId, matchExact, matchAny);

                if (results.Rows.Count == 0)
                {
                    MessageBox.Show("No employees found matching your search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dataGridView1.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void collapseThis()
        {
            /*
            private void AddEmployee()
            {
                // Trim any leading/trailing spaces to avoid false empty validation
                string employeeName = employeeNameTxt.Text.Trim();
                string payRateText = payRateTxt.Text.Trim();

                // Ensure all required fields are filled (including ComboBox selected values)
                if (string.IsNullOrEmpty(employeeName) ||
                    string.IsNullOrEmpty(payRateText) ||
                    positionList.SelectedIndex == 0 || // Assuming index 0 is the default "Select Position"
                    payrollTypeList.SelectedIndex == 0) // Assuming index 0 is the default "Select Payroll Type"
                {
                    MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure the pay rate is a valid decimal number
                if (!decimal.TryParse(payRateText, out decimal payRate))
                {
                    MessageBox.Show("Pay Rate must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Optional: Validate if Store ID is provided (if applicable)
                int storeId;
                if (!(storeList.SelectedIndex == 0))
                {

                    storeId = storeList.SelectedIndex;
                }

                // Insert employee details into the database
                try
                {
                    dbHelper.InsertEmployee(
                        employeeName,
                        positionList.SelectedItem.ToString(),
                        payrollTypeList.SelectedItem.ToString(),
                        payRate,
                        storeId
                    );

                    MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployeeData(""); // Refresh the data grid to show the added employee
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding employee: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

        private void ToggleMode(object sender, EventArgs e)
        {
            bool isSearchMode = searchRad.Checked;

            // Update button text to reflect the current mode
            searchBtn.Text = isSearchMode ? "Search" : "Add Employee";

            // No need to disable or enable controls. Everything stays enabled, just change functionality
            // Controls will remain enabled regardless of the mode
        }
        private void PopulateComboBox(ComboBox comboBox, List<object> items, string defaultItem)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(defaultItem);
            comboBox.Items.AddRange(items.ToArray());
            comboBox.SelectedIndex = 0;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchRad.Checked)
            {
                // In Search Mode, perform the search operation
                LoadEmployeeData(employeeNameTxt.Text);  // Or however the search data is handled
            }
            else if (addEmployeeRad.Checked)
            {
                // In Add Employee Mode, add the employee
                //AddEmployee();
            }
        }


        private void Employee_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}