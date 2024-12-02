using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            PopulateComboBox(positionList, dbHelper.GetRoles(), "Any");
            PopulateComboBox(payrollTypeList, dbHelper.GetPayrollTypes(), "Any");

            LoadEmployeeData(""); // Load initial data with an empty search

            // Attach event handlers
            searchRad.CheckedChanged += ToggleMode;
            addEmployeeRad.CheckedChanged += ToggleMode;
        }

        private void LoadEmployeeData(string searchTxt)
        {
            string selectedPosition = positionList.SelectedItem.ToString();
            string selectedPayrollType = payrollTypeList.SelectedItem.ToString();
            string storeId = string.IsNullOrEmpty(storeIdTxt.Text) ? null : storeIdTxt.Text;

            dataGridView1.DataSource = dbHelper.GetEmployees(searchTxt, selectedPosition, selectedPayrollType, storeId);
        }

        private void AddEmployee()
        {
            if (string.IsNullOrEmpty(employeeNameTxt.Text) || string.IsNullOrEmpty(payRateTxt.Text) || positionList.SelectedIndex == 0 || payrollTypeList.SelectedIndex == 0)
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(payRateTxt.Text, out decimal payRate))
            {
                MessageBox.Show("Pay Rate must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dbHelper.InsertEmployee(
                employeeNameTxt.Text,
                positionList.SelectedItem.ToString(),
                payrollTypeList.SelectedItem.ToString(),
                payRate,
                int.TryParse(storeIdTxt.Text, out int managerId) ? managerId : (int?)null
            );

            MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEmployeeData("");
        }

        private void ToggleMode(object sender, EventArgs e)
        {
            bool isSearchMode = searchRad.Checked;

            employeeGrpBox.Enabled = !isSearchMode;
            searchBtn.Text = isSearchMode ? "Search" : "Add Employee";
        }

        private void PopulateComboBox(ComboBox comboBox, List<string> items, string defaultItem)
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
                LoadEmployeeData(employeeNameTxt.Text);
            }
            else if (addEmployeeRad.Checked)
            {
                AddEmployee();
            }
        }
    }
}