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
            this.FormClosing += Employee_Manager_FormClosing;
        }

        private void Employee_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.Dispose();
            Application.Exit();
        }
    }
}
