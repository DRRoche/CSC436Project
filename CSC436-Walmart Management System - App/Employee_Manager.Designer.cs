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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            employeeNameTxt = new System.Windows.Forms.TextBox();
            searchBtn = new System.Windows.Forms.Button();
            exactlyRad = new System.Windows.Forms.RadioButton();
            anyRad = new System.Windows.Forms.RadioButton();
            searchRad = new System.Windows.Forms.RadioButton();
            addEmployeeRad = new System.Windows.Forms.RadioButton();
            searchMatchChoiceBox = new System.Windows.Forms.GroupBox();
            employeeGrpBox = new System.Windows.Forms.GroupBox();
            modeGrpBox = new System.Windows.Forms.GroupBox();
            positionList = new System.Windows.Forms.ComboBox();
            payrollTypeList = new System.Windows.Forms.ComboBox();
            storeIdTxt = new System.Windows.Forms.TextBox();
            payRateTxt = new System.Windows.Forms.TextBox();
            positionGrpBox = new System.Windows.Forms.GroupBox();
            payrollGrpBox = new System.Windows.Forms.GroupBox();
            storeGrpBox = new System.Windows.Forms.GroupBox();
            payRateGrpBox = new System.Windows.Forms.GroupBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);

            // dataGridView1
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(776, 270);
            dataGridView1.TabIndex = 0;

            // employeeNameTxt
            employeeNameTxt.Location = new System.Drawing.Point(6, 22);
            employeeNameTxt.Name = "employeeNameTxt";
            employeeNameTxt.Size = new System.Drawing.Size(212, 23);
            employeeNameTxt.TabIndex = 0;

            // searchBtn
            searchBtn.Location = new System.Drawing.Point(238, 21);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new System.Drawing.Size(75, 23);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.Click += new System.EventHandler(searchBtn_Click);

            // exactlyRad
            exactlyRad.AutoSize = true;
            exactlyRad.Location = new System.Drawing.Point(6, 22);
            exactlyRad.Name = "exactlyRad";
            exactlyRad.Size = new System.Drawing.Size(63, 19);
            exactlyRad.TabIndex = 0;
            exactlyRad.Text = "Exactly";
            exactlyRad.UseVisualStyleBackColor = true;

            // anyRad
            anyRad.AutoSize = true;
            anyRad.Location = new System.Drawing.Point(75, 22);
            anyRad.Name = "anyRad";
            anyRad.Size = new System.Drawing.Size(45, 19);
            anyRad.TabIndex = 1;
            anyRad.Text = "Any";
            anyRad.UseVisualStyleBackColor = true;

            // searchMatchChoiceBox
            searchMatchChoiceBox.Controls.Add(exactlyRad);
            searchMatchChoiceBox.Controls.Add(anyRad);
            searchMatchChoiceBox.Location = new System.Drawing.Point(10, 51);
            searchMatchChoiceBox.Name = "searchMatchChoiceBox";
            searchMatchChoiceBox.Size = new System.Drawing.Size(303, 47);
            searchMatchChoiceBox.TabIndex = 1;
            searchMatchChoiceBox.TabStop = false;
            searchMatchChoiceBox.Text = "Search Match Mode";

            // employeeGrpBox
            employeeGrpBox.Controls.Add(employeeNameTxt);
            employeeGrpBox.Controls.Add(searchMatchChoiceBox);
            employeeGrpBox.Controls.Add(searchBtn);
            employeeGrpBox.Location = new System.Drawing.Point(12, 288);
            employeeGrpBox.Name = "employeeGrpBox";
            employeeGrpBox.Size = new System.Drawing.Size(322, 102);
            employeeGrpBox.TabIndex = 2;

            // modeGrpBox
            modeGrpBox.Controls.Add(searchRad);
            modeGrpBox.Controls.Add(addEmployeeRad);
            modeGrpBox.Location = new System.Drawing.Point(12, 396);
            modeGrpBox.Name = "modeGrpBox";
            modeGrpBox.Size = new System.Drawing.Size(322, 42);
            modeGrpBox.TabIndex = 3;

            // searchRad
            searchRad.AutoSize = true;
            searchRad.Location = new System.Drawing.Point(6, 22);
            searchRad.Name = "searchRad";
            searchRad.Size = new System.Drawing.Size(59, 19);
            searchRad.TabIndex = 0;
            searchRad.Text = "Search";
            searchRad.UseVisualStyleBackColor = true;

            // addEmployeeRad
            addEmployeeRad.AutoSize = true;
            addEmployeeRad.Location = new System.Drawing.Point(75, 22);
            addEmployeeRad.Name = "addEmployeeRad";
            addEmployeeRad.Size = new System.Drawing.Size(99, 19);
            addEmployeeRad.TabIndex = 1;
            addEmployeeRad.Text = "Add Employee";
            addEmployeeRad.UseVisualStyleBackColor = true;
            searchRad.CheckedChanged += new System.EventHandler(this.ToggleMode);
            addEmployeeRad.CheckedChanged += new System.EventHandler(this.ToggleMode);
            // positionGrpBox
            positionGrpBox.Controls.Add(positionList);
            positionGrpBox.Location = new System.Drawing.Point(340, 288);
            positionGrpBox.Name = "positionGrpBox";
            positionGrpBox.Size = new System.Drawing.Size(150, 50);

            // payrollGrpBox
            payrollGrpBox.Controls.Add(payrollTypeList);
            payrollGrpBox.Location = new System.Drawing.Point(340, 340);

            // storeGrpBox
            storeGrpBox.Controls.Add(storeIdTxt);
            storeGrpBox.Location = new System.Drawing.Point(500, 288);

            // payRateGrpBox
            payRateGrpBox.Controls.Add(payRateTxt);
            payRateGrpBox.Location = new System.Drawing.Point(500, 340);

            // Employee_Manager
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(employeeGrpBox);
            Controls.Add(modeGrpBox);
            Controls.Add(positionGrpBox);
            Controls.Add(payrollGrpBox);
            Controls.Add(storeGrpBox);
            Controls.Add(payRateGrpBox);
            Text = "Employee Manager";

        }

        #endregion
    }
}
