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
        private System.Windows.Forms.GroupBox employeeGrpBox;
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            employeeNameTxt = new TextBox();
            searchBtn = new Button();
            exactlyRad = new RadioButton();
            anyRad = new RadioButton();
            allRad = new RadioButton();
            searchMatchChoiceBox = new GroupBox();
            employeeGrpBox = new GroupBox();
            groupBox4 = new GroupBox();
            addEmployeeRad = new RadioButton();
            searchRad = new RadioButton();
            positionList = new ComboBox();
            payrollTypeList = new ComboBox();
            storeIdTxt = new TextBox();
            payRateTxt = new TextBox();
            positionGrpBox = new GroupBox();
            payrollGrpBox = new GroupBox();
            storeGrpBox = new GroupBox();
            payRateGrpBox = new GroupBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            searchMatchChoiceBox.SuspendLayout();
            employeeGrpBox.SuspendLayout();
            groupBox4.SuspendLayout();
            positionGrpBox.SuspendLayout();
            payrollGrpBox.SuspendLayout();
            storeGrpBox.SuspendLayout();
            payRateGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 270);
            dataGridView1.TabIndex = 0;
            // 
            // employeeNameTxt
            // 
            employeeNameTxt.Location = new Point(6, 22);
            employeeNameTxt.Name = "employeeNameTxt";
            employeeNameTxt.Size = new Size(212, 23);
            employeeNameTxt.TabIndex = 0;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(238, 21);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            // 
            // exactlyRad
            // 
            exactlyRad.AutoSize = true;
            exactlyRad.Checked = true;
            exactlyRad.Location = new Point(6, 22);
            exactlyRad.Name = "exactlyRad";
            exactlyRad.Size = new Size(14, 13);
            exactlyRad.TabIndex = 0;
            exactlyRad.TabStop = true;
            // 
            // anyRad
            // 
            anyRad.AutoSize = true;
            anyRad.Location = new Point(106, 22);
            anyRad.Name = "anyRad";
            anyRad.Size = new Size(14, 13);
            anyRad.TabIndex = 2;
            // 
            // allRad
            // 
            allRad.AutoSize = true;
            allRad.Location = new Point(203, 22);
            allRad.Name = "allRad";
            allRad.Size = new Size(14, 13);
            allRad.TabIndex = 1;
            // 
            // searchMatchChoiceBox
            // 
            searchMatchChoiceBox.Controls.Add(exactlyRad);
            searchMatchChoiceBox.Controls.Add(allRad);
            searchMatchChoiceBox.Controls.Add(anyRad);
            searchMatchChoiceBox.Location = new Point(10, 51);
            searchMatchChoiceBox.Name = "searchMatchChoiceBox";
            searchMatchChoiceBox.Size = new Size(303, 47);
            searchMatchChoiceBox.TabIndex = 1;
            searchMatchChoiceBox.TabStop = false;
            searchMatchChoiceBox.Text = "Match:";
            // 
            // employeeGrpBox
            // 
            employeeGrpBox.Controls.Add(employeeNameTxt);
            employeeGrpBox.Controls.Add(searchMatchChoiceBox);
            employeeGrpBox.Controls.Add(searchBtn);
            employeeGrpBox.Location = new Point(12, 288);
            employeeGrpBox.Name = "employeeGrpBox";
            employeeGrpBox.Size = new Size(322, 102);
            employeeGrpBox.TabIndex = 1;
            employeeGrpBox.TabStop = false;
            employeeGrpBox.Text = "Employee Name";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(addEmployeeRad);
            groupBox4.Controls.Add(searchRad);
            groupBox4.Location = new Point(12, 396);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(323, 42);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mode";
            // 
            // addEmployeeRad
            // 
            addEmployeeRad.Location = new Point(0, 0);
            addEmployeeRad.Name = "addEmployeeRad";
            addEmployeeRad.Size = new Size(104, 24);
            addEmployeeRad.TabIndex = 0;
            // 
            // searchRad
            // 
            searchRad.Location = new Point(0, 0);
            searchRad.Name = "searchRad";
            searchRad.Size = new Size(104, 24);
            searchRad.TabIndex = 1;
            // 
            // positionList
            // 
            positionList.Location = new Point(0, 0);
            positionList.Name = "positionList";
            positionList.Size = new Size(121, 23);
            positionList.TabIndex = 0;
            // 
            // payrollTypeList
            // 
            payrollTypeList.Location = new Point(0, 0);
            payrollTypeList.Name = "payrollTypeList";
            payrollTypeList.Size = new Size(121, 23);
            payrollTypeList.TabIndex = 0;
            // 
            // storeIdTxt
            // 
            storeIdTxt.Location = new Point(0, 0);
            storeIdTxt.Name = "storeIdTxt";
            storeIdTxt.Size = new Size(100, 23);
            storeIdTxt.TabIndex = 0;
            // 
            // payRateTxt
            // 
            payRateTxt.Location = new Point(0, 0);
            payRateTxt.Name = "payRateTxt";
            payRateTxt.Size = new Size(100, 23);
            payRateTxt.TabIndex = 0;
            // 
            // positionGrpBox
            // 
            positionGrpBox.Controls.Add(positionList);
            positionGrpBox.Location = new Point(340, 288);
            positionGrpBox.Name = "positionGrpBox";
            positionGrpBox.Size = new Size(150, 50);
            positionGrpBox.TabIndex = 3;
            positionGrpBox.TabStop = false;
            positionGrpBox.Text = "Position";
            // 
            // payrollGrpBox
            // 
            payrollGrpBox.Controls.Add(payrollTypeList);
            payrollGrpBox.Location = new Point(340, 340);
            payrollGrpBox.Name = "payrollGrpBox";
            payrollGrpBox.Size = new Size(150, 50);
            payrollGrpBox.TabIndex = 4;
            payrollGrpBox.TabStop = false;
            payrollGrpBox.Text = "Payroll Type";
            // 
            // storeGrpBox
            // 
            storeGrpBox.Controls.Add(storeIdTxt);
            storeGrpBox.Location = new Point(500, 288);
            storeGrpBox.Name = "storeGrpBox";
            storeGrpBox.Size = new Size(150, 50);
            storeGrpBox.TabIndex = 5;
            storeGrpBox.TabStop = false;
            storeGrpBox.Text = "Store ID";
            // 
            // payRateGrpBox
            // 
            payRateGrpBox.Controls.Add(payRateTxt);
            payRateGrpBox.Location = new Point(500, 340);
            payRateGrpBox.Name = "payRateGrpBox";
            payRateGrpBox.Size = new Size(150, 50);
            payRateGrpBox.TabIndex = 6;
            payRateGrpBox.TabStop = false;
            payRateGrpBox.Text = "Pay Rate";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Employee_Manager
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(employeeGrpBox);
            Controls.Add(groupBox4);
            Controls.Add(positionGrpBox);
            Controls.Add(payrollGrpBox);
            Controls.Add(storeGrpBox);
            Controls.Add(payRateGrpBox);
            Name = "Employee_Manager";
            Text = "Employee Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            searchMatchChoiceBox.ResumeLayout(false);
            searchMatchChoiceBox.PerformLayout();
            employeeGrpBox.ResumeLayout(false);
            employeeGrpBox.PerformLayout();
            groupBox4.ResumeLayout(false);
            positionGrpBox.ResumeLayout(false);
            payrollGrpBox.ResumeLayout(false);
            storeGrpBox.ResumeLayout(false);
            storeGrpBox.PerformLayout();
            payRateGrpBox.ResumeLayout(false);
            payRateGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
