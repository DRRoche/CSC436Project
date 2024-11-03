using System.Data;
using System.IO;

namespace CSC436_Walmart_Management_System___App
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void ProdSearchButton(object sender, EventArgs e)
        {
            this.Hide(); // Hide Form1
            Product_Search productSearch = new Product_Search();
            productSearch.Show();
        }
    }
}
