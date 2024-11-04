using System;
using System.Windows.Forms;

namespace CSC436_Walmart_Management_System___App
{
    public partial class Form1 : Form
    {
        private DatabaseHelper dbHelper;

        public Form1()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper(); // Initialize the DatabaseHelper

            // Explicitly link FormClosing event
            this.FormClosing += Form1_FormClosing;
        }

        private void ProdSearchButton(object sender, EventArgs e)
        {
            this.Hide(); // Hide Form1
            Product_Search productSearch = new Product_Search(dbHelper); // Pass dbHelper to Product_Search
            productSearch.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.Dispose(); // Ensure the database connection is disposed
            Application.Exit(); // Forcefully exit the application
        }
    }
}
