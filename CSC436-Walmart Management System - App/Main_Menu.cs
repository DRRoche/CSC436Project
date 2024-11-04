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

        private void MainMenuClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.Dispose(); // Ensure the database connection is disposed
            Application.Exit(); // Forcefully exit the application
        }
    }
}
