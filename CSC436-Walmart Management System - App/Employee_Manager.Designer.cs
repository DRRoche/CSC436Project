namespace CSC436_Walmart_Management_System___App
{
    partial class Employee_Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declare all the controls used in the form
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox employeeNameTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.RadioButton exactlyRad;
        private System.Windows.Forms.RadioButton anyRad;
        private System.Windows.Forms.RadioButton allRad;
        private System.Windows.Forms.GroupBox searchMatchChoiceBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton addEmployeeRad;
        private System.Windows.Forms.RadioButton searchRad;
        private System.Windows.Forms.ComboBox positionList;
        private System.Windows.Forms.ComboBox payrollTypeList;
        private System.Windows.Forms.TextBox storeIdTxt;
        private System.Windows.Forms.TextBox payRateTxt;
        private System.Windows.Forms.GroupBox positionGrpBox;
        private System.Windows.Forms.GroupBox payrollGrpBox;
        private System.Windows.Forms.GroupBox storeGrpBox;
        private System.Windows.Forms.GroupBox payRateGrpBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Initialize controls
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeNameTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.exactlyRad = new System.Windows.Forms.RadioButton();
            this.anyRad = new System.Windows.Forms.RadioButton();
            this.allRad = new System.Windows.Forms.RadioButton();
            this.searchMatchChoiceBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addEmployeeRad = new System.Windows.Forms.RadioButton();
            this.searchRad = new System.Windows.Forms.RadioButton();
            this.positionList = new System.Windows.Forms.ComboBox();
            this.payrollTypeList = new System.Windows.Forms.ComboBox();
            this.storeIdTxt = new System.Windows.Forms.TextBox();
            this.payRateTxt = new System.Windows.Forms.TextBox();
            this.positionGrpBox = new System.Windows.Forms.GroupBox();
            this.payrollGrpBox = new System.Windows.Forms.GroupBox();
            this.storeGrpBox = new System.Windows.Forms.GroupBox();
            this.payRateGrpBox = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            // DataGridView
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 270);

            // Employee Name TextBox
            this.employeeNameTxt.Location = new System.Drawing.Point(6, 22);
            this.employeeNameTxt.Name = "employeeNameTxt";
            this.employeeNameTxt.Size = new System.Drawing.Size(212, 23);

            // Search Button
            this.searchBtn.Location = new System.Drawing.Point(238, 21);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.Text = "Search";

            // Exactly Radio Button
            this.exactlyRad.AutoSize = true;
            this.exactlyRad.Checked = true;
            this.exactlyRad.Location = new System.Drawing.Point(6, 22);
            this.exactlyRad.Name = "exactlyRad";
            this.exactlyRad.Size = new System.Drawing.Size(62, 19);

            // Any Radio Button
            this.anyRad.AutoSize = true;
            this.anyRad.Location = new System.Drawing.Point(106, 22);
            this.anyRad.Name = "anyRad";
            this.anyRad.Size = new System.Drawing.Size(46, 19);

            // All Radio Button
            this.allRad.AutoSize = true;
            this.allRad.Location = new System.Drawing.Point(203, 22);
            this.allRad.Name = "allRad";
            this.allRad.Size = new System.Drawing.Size(39, 19);

            // Search Match Choice GroupBox
            this.searchMatchChoiceBox.Controls.Add(this.exactlyRad);
            this.searchMatchChoiceBox.Controls.Add(this.allRad);
            this.searchMatchChoiceBox.Controls.Add(this.anyRad);
            this.searchMatchChoiceBox.Location = new System.Drawing.Point(10, 51);
            this.searchMatchChoiceBox.Name = "searchMatchChoiceBox";
            this.searchMatchChoiceBox.Size = new System.Drawing.Size(303, 47);
            this.searchMatchChoiceBox.Text = "Match:";

            // GroupBox for Employee Name
            this.groupBox1.Controls.Add(this.employeeNameTxt);
            this.groupBox1.Controls.Add(this.searchMatchChoiceBox);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 102);
            this.groupBox1.Text = "Employee Name";

            // GroupBox for Mode
            this.groupBox4.Controls.Add(this.addEmployeeRad);
            this.groupBox4.Controls.Add(this.searchRad);
            this.groupBox4.Location = new System.Drawing.Point(12, 396);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 42);
            this.groupBox4.Text = "Mode";

            // Position GroupBox
            this.positionGrpBox.Controls.Add(this.positionList);
            this.positionGrpBox.Location = new System.Drawing.Point(340, 288);
            this.positionGrpBox.Name = "positionGrpBox";
            this.positionGrpBox.Size = new System.Drawing.Size(150, 50);
            this.positionGrpBox.Text = "Position";

            // Payroll GroupBox
            this.payrollGrpBox.Controls.Add(this.payrollTypeList);
            this.payrollGrpBox.Location = new System.Drawing.Point(340, 340);
            this.payrollGrpBox.Name = "payrollGrpBox";
            this.payrollGrpBox.Size = new System.Drawing.Size(150, 50);
            this.payrollGrpBox.Text = "Payroll Type";

            // Store GroupBox
            this.storeGrpBox.Controls.Add(this.storeIdTxt);
            this.storeGrpBox.Location = new System.Drawing.Point(500, 288);
            this.storeGrpBox.Name = "storeGrpBox";
            this.storeGrpBox.Size = new System.Drawing.Size(150, 50);
            this.storeGrpBox.Text = "Store ID";

            // Pay Rate GroupBox
            this.payRateGrpBox.Controls.Add(this.payRateTxt);
            this.payRateGrpBox.Location = new System.Drawing.Point(500, 340);
            this.payRateGrpBox.Name = "payRateGrpBox";
            this.payRateGrpBox.Size = new System.Drawing.Size(150, 50);
            this.payRateGrpBox.Text = "Pay Rate";

            // ErrorProvider
            this.errorProvider1.ContainerControl = this;

            // Add controls to the form
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.positionGrpBox);
            this.Controls.Add(this.payrollGrpBox);
            this.Controls.Add(this.storeGrpBox);
            this.Controls.Add(this.payRateGrpBox);

            // Form properties
            this.Text = "Employee Manager";
            this.ClientSize = new System.Drawing.Size(800, 450);
        }

        #endregion
    }
}
