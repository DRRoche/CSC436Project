using System;
using System.Windows.Forms;

namespace CSC436_Walmart_Management_System___App
{
    public partial class MainMenu : Form
    {
        private DatabaseHelper dbHelper;

        public MainMenu()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper(); // Initialize the DatabaseHelper

            // Explicitly link FormClosing event
            this.FormClosing += MainMenuClosing;
        }

        private void ProdSearchButton(object sender, EventArgs e)
        {
            this.Hide(); // Hide Main Menu
            Product_Search productSearch = new Product_Search(dbHelper); // Pass dbHelper to Product_Search
            productSearch.Show();
        }

        private void ProdManagerButton(object sender, EventArgs e)
        {
            this.Hide(); // Hide Main Menu
            Product_Manager productManager = new Product_Manager(dbHelper); // Pass dbHelper to Product_Search
            productManager.Show();
        }

        private void EmpLookupButton(object sender, EventArgs e)
        {
            this.Hide(); // Hide Main Menu
            Employee_Lookup employeeLookup = new Employee_Lookup(dbHelper); // Pass dbHelper to Product_Search
            employeeLookup.Show();
        }

        private void EmpManButton(object sender, EventArgs e)
        {
            this.Hide(); // Hide Main Menu
            Employee_Manager employeeManager = new Employee_Manager(dbHelper); // Pass dbHelper to Product_Search
            employeeManager.Show();
        }


        private void MainMenuClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.Dispose(); // Ensure the database connection is disposed
            Application.Exit(); // Forcefully exit the application
        }
    }
}
