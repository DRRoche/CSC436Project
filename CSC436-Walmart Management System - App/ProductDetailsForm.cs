using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CSC436_Walmart_Management_System___App
{
    public partial class ProductDetailsForm : Form
    {
        private readonly DatabaseHelper dbHelper;

        public ProductDetailsForm(int SKU, string productName, decimal price, DatabaseHelper dbHelper)
        {
            InitializeComponent();

            // Display data in text boxes, labels, or other controls
            skuTxt.Text = SKU.ToString();
            prodNameTxt.Text = productName;
            priceTxt.Text = price.ToString("F2"); // Format with 2 decimal places
            this.dbHelper = dbHelper;

            // Attach validation to priceTxt for numeric entry only
            priceTxt.KeyPress += validateNumericKeypress;
        }

        private void validateNumericKeypress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control keys, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true; // Prevent entering multiple decimal points
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Check if price input is a valid decimal
            if (!decimal.TryParse(priceTxt.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepare and execute the SQL command
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE product SET price = @price WHERE SKU = @sku;"))
                {
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@sku", skuTxt.Text);

                    // Use ExecuteNonQuery for UPDATE commands
                    dbHelper.ExecuteQuery(cmd);

                    MessageBox.Show("Product details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating product details:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

