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
    public partial class Product_Search : Form
    {
        private DatabaseHelper dbHelper;

        public Product_Search()
        {
            InitializeComponent();
            // Initialize DatabaseHelper with your database details
            dbHelper = new DatabaseHelper();
            LoadData("SELECT * FROM unit_price");
        }

        private void LoadData(string query)
        {
            DataTable dataTable = dbHelper.ExecuteQuery(query);
            dataGridView1.DataSource = dataTable;
        }

        private void Product_Search_Load(object sender, EventArgs e)
        {
            string searchTxt = searchBox.Text;
            string query = "SELECT * FROM unit_price where prod_name like '%" + searchTxt + "%'";
            LoadData(query);


        }
    }
}
