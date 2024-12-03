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
    public partial class BrandAdder : Form{
        private readonly DatabaseHelper dbHelper;
        public BrandAdder(DatabaseHelper dbHelper){
            InitializeComponent();
            this.dbHelper = dbHelper;
        }

        private void brandIdTxt_KeyPress(object sender, KeyPressEventArgs e){

            if (brandIdTxt.Text.Length < 5 || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;
        }

        private void addBrandBtn_Click(object sender, EventArgs e){
            // Check that both brandNameTxt and brandIdTxt are not empty
            if (string.IsNullOrWhiteSpace(brandNameTxt.Text) || string.IsNullOrWhiteSpace(brandIdTxt.Text))
            {
                MessageBox.Show("Please enter a brand name and brand ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check that brandIdTxt is not already in brand table
            if (dbHelper.BrandExists(brandIdTxt.Text))
            {
                MessageBox.Show("Brand ID already exists.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Insert brand into brand table brandIdTxt.Text, brandNameTxt.Text, chainExclusiveChk.Checked
            dbHelper.InsertBrand(brandIdTxt.Text, brandNameTxt.Text, chainExclusiveChk.Checked);
            MessageBox.Show("Brand added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }


    }

}
