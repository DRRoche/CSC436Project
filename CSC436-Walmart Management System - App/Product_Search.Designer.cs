namespace CSC436_Walmart_Management_System___App
{
    partial class Product_Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            searchTxt = new TextBox();
            searchBtn = new Button();
            exactlyRad = new RadioButton();
            anyRad = new RadioButton();
            allRad = new RadioButton();
            searchMatchChoiceBox = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            databaseHelperBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            maxTxt = new TextBox();
            minTxt = new TextBox();
            groupBox3 = new GroupBox();
            storeList = new ComboBox();
            groupBox5 = new GroupBox();
            textBox1 = new TextBox();
            groupBox6 = new GroupBox();
            brandList = new ComboBox();
            groupBox7 = new GroupBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            groupBox8 = new GroupBox();
            deptList = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            searchMatchChoiceBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(764, 270);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(6, 22);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(212, 23);
            searchTxt.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(224, 21);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += button1_Click;
            // 
            // exactlyRad
            // 
            exactlyRad.AutoSize = true;
            exactlyRad.Checked = true;
            exactlyRad.Location = new Point(6, 22);
            exactlyRad.Name = "exactlyRad";
            exactlyRad.Size = new Size(62, 19);
            exactlyRad.TabIndex = 3;
            exactlyRad.TabStop = true;
            exactlyRad.Text = "Exactly";
            exactlyRad.UseVisualStyleBackColor = true;
            // 
            // anyRad
            // 
            anyRad.AutoSize = true;
            anyRad.Location = new Point(106, 22);
            anyRad.Name = "anyRad";
            anyRad.Size = new Size(46, 19);
            anyRad.TabIndex = 4;
            anyRad.Text = "Any";
            anyRad.UseVisualStyleBackColor = true;
            // 
            // allRad
            // 
            allRad.AutoSize = true;
            allRad.Location = new Point(203, 22);
            allRad.Name = "allRad";
            allRad.Size = new Size(39, 19);
            allRad.TabIndex = 5;
            allRad.Text = "All";
            allRad.UseVisualStyleBackColor = true;
            // 
            // searchMatchChoiceBox
            // 
            searchMatchChoiceBox.Controls.Add(exactlyRad);
            searchMatchChoiceBox.Controls.Add(allRad);
            searchMatchChoiceBox.Controls.Add(anyRad);
            searchMatchChoiceBox.Location = new Point(7, 51);
            searchMatchChoiceBox.Name = "searchMatchChoiceBox";
            searchMatchChoiceBox.Size = new Size(303, 47);
            searchMatchChoiceBox.TabIndex = 6;
            searchMatchChoiceBox.TabStop = false;
            searchMatchChoiceBox.Text = "Match:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchTxt);
            groupBox1.Controls.Add(searchMatchChoiceBox);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Location = new Point(24, 288);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 102);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product name";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Location = new Point(23, 396);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(323, 42);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Inventory Mode";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(146, 18);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(92, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Add Product";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(19, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(105, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Product Search";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // databaseHelperBindingSource
            // 
            databaseHelperBindingSource.DataSource = typeof(DatabaseHelper);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(maxTxt);
            groupBox2.Controls.Add(minTxt);
            groupBox2.Location = new Point(361, 288);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 67);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 48);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Max";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "Min";
            // 
            // maxTxt
            // 
            maxTxt.Location = new Point(88, 22);
            maxTxt.Name = "maxTxt";
            maxTxt.Size = new Size(77, 23);
            maxTxt.TabIndex = 1;
            maxTxt.KeyPress += validateNumericKeypress;
            // 
            // minTxt
            // 
            minTxt.Location = new Point(6, 22);
            minTxt.Name = "minTxt";
            minTxt.Size = new Size(77, 23);
            minTxt.TabIndex = 0;
            minTxt.KeyPress += validateNumericKeypress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(storeList);
            groupBox3.Location = new Point(538, 288);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(135, 67);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Store";
            // 
            // storeList
            // 
            storeList.DropDownStyle = ComboBoxStyle.DropDownList;
            storeList.FormattingEnabled = true;
            storeList.Location = new Point(8, 23);
            storeList.Name = "storeList";
            storeList.Size = new Size(121, 23);
            storeList.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox1);
            groupBox5.Location = new Point(360, 361);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(172, 77);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "SKU";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(brandList);
            groupBox6.Location = new Point(679, 288);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(109, 67);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "Brand";
            // 
            // brandList
            // 
            brandList.FormattingEnabled = true;
            brandList.Location = new Point(7, 22);
            brandList.Name = "brandList";
            brandList.Size = new Size(96, 23);
            brandList.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(textBox2);
            groupBox7.Controls.Add(comboBox2);
            groupBox7.Location = new Point(538, 361);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(135, 77);
            groupBox7.TabIndex = 13;
            groupBox7.TabStop = false;
            groupBox7.Text = "Unit";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 47);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(deptList);
            groupBox8.Location = new Point(683, 361);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(105, 77);
            groupBox8.TabIndex = 14;
            groupBox8.TabStop = false;
            groupBox8.Text = "Department";
            // 
            // deptList
            // 
            deptList.FormattingEnabled = true;
            deptList.Location = new Point(4, 35);
            deptList.Name = "deptList";
            deptList.Size = new Size(95, 23);
            deptList.TabIndex = 0;
            // 
            // Product_Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Product_Search";
            Text = "Walmart Management System - Product Search";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            searchMatchChoiceBox.ResumeLayout(false);
            searchMatchChoiceBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox searchTxt;
        private Button searchBtn;
        private RadioButton exactlyRad;
        private RadioButton anyRad;
        private RadioButton allRad;
        private GroupBox searchMatchChoiceBox;
        private GroupBox groupBox1;
        private BindingSource databaseHelperBindingSource;
        private GroupBox groupBox2;
        private TextBox maxTxt;
        private TextBox minTxt;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private ComboBox storeList;
        private GroupBox groupBox4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox5;
        private TextBox textBox1;
        private GroupBox groupBox6;
        private ComboBox brandList;
        private GroupBox groupBox7;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private GroupBox groupBox8;
        private ComboBox deptList;
    }
}