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
        private System.Windows.Forms.RadioButton searchRad;
        private System.Windows.Forms.RadioButton addEmployeeRad;
        private System.Windows.Forms.GroupBox searchMatchChoiceBox;
        private System.Windows.Forms.GroupBox employeeGrpBox;
        private System.Windows.Forms.GroupBox modeGrpBox;
        private System.Windows.Forms.ComboBox positionList;
        private System.Windows.Forms.ComboBox payrollTypeList;
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
            searchRad = new RadioButton();
            addEmployeeRad = new RadioButton();
            searchMatchChoiceBox = new GroupBox();
            employeeGrpBox = new GroupBox();
            modeGrpBox = new GroupBox();
            positionList = new ComboBox();
            payrollTypeList = new ComboBox();
            payRateTxt = new TextBox();
            positionGrpBox = new GroupBox();
            payrollGrpBox = new GroupBox();
            storeGrpBox = new GroupBox();
            storeList = new ComboBox();
            payRateGrpBox = new GroupBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            searchMatchChoiceBox.SuspendLayout();
            employeeGrpBox.SuspendLayout();
            modeGrpBox.SuspendLayout();
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
            searchBtn.Click += searchBtn_Click;
            // 
            // exactlyRad
            // 
            exactlyRad.AutoSize = true;
            exactlyRad.Checked = true;
            exactlyRad.Location = new Point(6, 22);
            exactlyRad.Name = "exactlyRad";
            exactlyRad.Size = new Size(62, 19);
            exactlyRad.TabIndex = 0;
            exactlyRad.TabStop = true;
            exactlyRad.Text = "Exactly";
            exactlyRad.UseVisualStyleBackColor = true;
            // 
            // anyRad
            // 
            anyRad.AutoSize = true;
            anyRad.Location = new Point(75, 22);
            anyRad.Name = "anyRad";
            anyRad.Size = new Size(46, 19);
            anyRad.TabIndex = 1;
            anyRad.Text = "Any";
            anyRad.UseVisualStyleBackColor = true;
            // 
            // searchRad
            // 
            searchRad.AutoSize = true;
            searchRad.Checked = true;
            searchRad.Location = new Point(6, 22);
            searchRad.Name = "searchRad";
            searchRad.Size = new Size(60, 19);
            searchRad.TabIndex = 0;
            searchRad.TabStop = true;
            searchRad.Text = "Search";
            searchRad.UseVisualStyleBackColor = true;
            searchRad.CheckedChanged += ToggleMode;
            // 
            // addEmployeeRad
            // 
            addEmployeeRad.AutoSize = true;
            addEmployeeRad.Enabled = false;
            addEmployeeRad.Location = new Point(75, 22);
            addEmployeeRad.Name = "addEmployeeRad";
            addEmployeeRad.Size = new Size(102, 19);
            addEmployeeRad.TabIndex = 1;
            addEmployeeRad.Text = "Add Employee";
            addEmployeeRad.UseVisualStyleBackColor = true;
            addEmployeeRad.CheckedChanged += ToggleMode;
            // 
            // searchMatchChoiceBox
            // 
            searchMatchChoiceBox.Controls.Add(exactlyRad);
            searchMatchChoiceBox.Controls.Add(anyRad);
            searchMatchChoiceBox.Location = new Point(10, 51);
            searchMatchChoiceBox.Name = "searchMatchChoiceBox";
            searchMatchChoiceBox.Size = new Size(303, 47);
            searchMatchChoiceBox.TabIndex = 1;
            searchMatchChoiceBox.TabStop = false;
            searchMatchChoiceBox.Text = "Search Match Mode";
            // 
            // employeeGrpBox
            // 
            employeeGrpBox.Controls.Add(employeeNameTxt);
            employeeGrpBox.Controls.Add(searchMatchChoiceBox);
            employeeGrpBox.Controls.Add(searchBtn);
            employeeGrpBox.Location = new Point(12, 288);
            employeeGrpBox.Name = "employeeGrpBox";
            employeeGrpBox.Size = new Size(322, 102);
            employeeGrpBox.TabIndex = 2;
            employeeGrpBox.TabStop = false;
            // 
            // modeGrpBox
            // 
            modeGrpBox.Controls.Add(searchRad);
            modeGrpBox.Controls.Add(addEmployeeRad);
            modeGrpBox.Location = new Point(12, 392);
            modeGrpBox.Name = "modeGrpBox";
            modeGrpBox.Size = new Size(322, 51);
            modeGrpBox.TabIndex = 3;
            modeGrpBox.TabStop = false;
            // 
            // positionList
            // 
            positionList.Location = new Point(6, 21);
            positionList.Name = "positionList";
            positionList.Size = new Size(121, 23);
            positionList.TabIndex = 0;
            // 
            // payrollTypeList
            // 
            payrollTypeList.Location = new Point(6, 21);
            payrollTypeList.Name = "payrollTypeList";
            payrollTypeList.Size = new Size(121, 23);
            payrollTypeList.TabIndex = 0;
            // 
            // payRateTxt
            // 
            payRateTxt.Location = new Point(15, 22);
            payRateTxt.Name = "payRateTxt";
            payRateTxt.Size = new Size(100, 23);
            payRateTxt.TabIndex = 0;
            // 
            // positionGrpBox
            // 
            positionGrpBox.Controls.Add(positionList);
            positionGrpBox.Location = new Point(355, 288);
            positionGrpBox.Name = "positionGrpBox";
            positionGrpBox.Size = new Size(165, 62);
            positionGrpBox.TabIndex = 4;
            positionGrpBox.TabStop = false;
            positionGrpBox.Text = "Position";
            // 
            // payrollGrpBox
            // 
            payrollGrpBox.Controls.Add(payrollTypeList);
            payrollGrpBox.Location = new Point(355, 376);
            payrollGrpBox.Name = "payrollGrpBox";
            payrollGrpBox.Size = new Size(165, 62);
            payrollGrpBox.TabIndex = 5;
            payrollGrpBox.TabStop = false;
            payrollGrpBox.Text = "Payroll Type";
            // 
            // storeGrpBox
            // 
            storeGrpBox.Controls.Add(storeList);
            storeGrpBox.Location = new Point(533, 288);
            storeGrpBox.Name = "storeGrpBox";
            storeGrpBox.Size = new Size(165, 62);
            storeGrpBox.TabIndex = 6;
            storeGrpBox.TabStop = false;
            storeGrpBox.Text = "Store ID";
            // 
            // storeList
            // 
            storeList.FormattingEnabled = true;
            storeList.Location = new Point(9, 22);
            storeList.Name = "storeList";
            storeList.Size = new Size(121, 23);
            storeList.TabIndex = 1;
            // 
            // payRateGrpBox
            // 
            payRateGrpBox.Controls.Add(payRateTxt);
            payRateGrpBox.Location = new Point(533, 376);
            payRateGrpBox.Name = "payRateGrpBox";
            payRateGrpBox.Size = new Size(165, 62);
            payRateGrpBox.TabIndex = 7;
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
            Controls.Add(modeGrpBox);
            Controls.Add(positionGrpBox);
            Controls.Add(payrollGrpBox);
            Controls.Add(storeGrpBox);
            Controls.Add(payRateGrpBox);
            Name = "Employee_Manager";
            Text = "Employee Manager";
            FormClosing += Employee_Manager_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            searchMatchChoiceBox.ResumeLayout(false);
            searchMatchChoiceBox.PerformLayout();
            employeeGrpBox.ResumeLayout(false);
            employeeGrpBox.PerformLayout();
            modeGrpBox.ResumeLayout(false);
            modeGrpBox.PerformLayout();
            positionGrpBox.ResumeLayout(false);
            payrollGrpBox.ResumeLayout(false);
            storeGrpBox.ResumeLayout(false);
            payRateGrpBox.ResumeLayout(false);
            payRateGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox storeList;
    }
}
