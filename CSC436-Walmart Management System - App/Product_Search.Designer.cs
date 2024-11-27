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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            prodNameTxt = new TextBox();
            searchBtn = new Button();
            exactlyRad = new RadioButton();
            anyRad = new RadioButton();
            allRad = new RadioButton();
            searchMatchChoiceBox = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            add_prod_rad = new RadioButton();
            prod_search_rad = new RadioButton();
            databaseHelperBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            maxLbl = new Label();
            minLbl = new Label();
            maxTxt = new TextBox();
            minTxt = new TextBox();
            groupBox3 = new GroupBox();
            storeList = new ComboBox();
            groupBox5 = new GroupBox();
            skuTxt = new TextBox();
            groupBox6 = new GroupBox();
            brandList = new ComboBox();
            unitGrpBox = new GroupBox();
            sizeTxt = new TextBox();
            unitList = new ComboBox();
            groupBox8 = new GroupBox();
            deptList = new ComboBox();
            prodErr = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            searchMatchChoiceBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            unitGrpBox.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prodErr).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 270);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // prodNameTxt
            // 
            prodNameTxt.Location = new Point(6, 22);
            prodNameTxt.Name = "prodNameTxt";
            prodNameTxt.Size = new Size(212, 23);
            prodNameTxt.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(238, 21);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
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
            searchMatchChoiceBox.Location = new Point(10, 51);
            searchMatchChoiceBox.Name = "searchMatchChoiceBox";
            searchMatchChoiceBox.Size = new Size(303, 47);
            searchMatchChoiceBox.TabIndex = 6;
            searchMatchChoiceBox.TabStop = false;
            searchMatchChoiceBox.Text = "Match:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(prodNameTxt);
            groupBox1.Controls.Add(searchMatchChoiceBox);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Location = new Point(12, 288);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 102);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product name";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(add_prod_rad);
            groupBox4.Controls.Add(prod_search_rad);
            groupBox4.Location = new Point(12, 396);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(323, 42);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Inventory Mode";
            // 
            // add_prod_rad
            // 
            add_prod_rad.AutoSize = true;
            add_prod_rad.Location = new Point(186, 16);
            add_prod_rad.Name = "add_prod_rad";
            add_prod_rad.Size = new Size(92, 19);
            add_prod_rad.TabIndex = 1;
            add_prod_rad.TabStop = true;
            add_prod_rad.Text = "Add Product";
            add_prod_rad.UseVisualStyleBackColor = true;
            // 
            // prod_search_rad
            // 
            prod_search_rad.AutoSize = true;
            prod_search_rad.Checked = true;
            prod_search_rad.Location = new Point(37, 17);
            prod_search_rad.Name = "prod_search_rad";
            prod_search_rad.Size = new Size(105, 19);
            prod_search_rad.TabIndex = 0;
            prod_search_rad.TabStop = true;
            prod_search_rad.Text = "Product Search";
            prod_search_rad.UseVisualStyleBackColor = true;
            // 
            // databaseHelperBindingSource
            // 
            databaseHelperBindingSource.DataSource = typeof(DatabaseHelper);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(maxLbl);
            groupBox2.Controls.Add(minLbl);
            groupBox2.Controls.Add(maxTxt);
            groupBox2.Controls.Add(minTxt);
            groupBox2.Location = new Point(347, 288);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 67);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Price";
            // 
            // maxLbl
            // 
            maxLbl.AutoSize = true;
            maxLbl.Location = new Point(135, 48);
            maxLbl.Name = "maxLbl";
            maxLbl.Size = new Size(30, 15);
            maxLbl.TabIndex = 3;
            maxLbl.Text = "Max";
            // 
            // minLbl
            // 
            minLbl.AutoSize = true;
            minLbl.Location = new Point(6, 48);
            minLbl.Name = "minLbl";
            minLbl.Size = new Size(28, 15);
            minLbl.TabIndex = 2;
            minLbl.Text = "Min";
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
            groupBox3.Location = new Point(531, 288);
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
            groupBox5.Controls.Add(skuTxt);
            groupBox5.Location = new Point(347, 361);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(172, 77);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "SKU";
            // 
            // skuTxt
            // 
            skuTxt.Location = new Point(7, 35);
            skuTxt.Name = "skuTxt";
            skuTxt.Size = new Size(159, 23);
            skuTxt.TabIndex = 0;
            skuTxt.KeyPress += validateNumericKeypress;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(brandList);
            groupBox6.Location = new Point(678, 288);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(110, 67);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "Brand";
            // 
            // brandList
            // 
            brandList.DropDownStyle = ComboBoxStyle.DropDownList;
            brandList.FormattingEnabled = true;
            brandList.Location = new Point(7, 22);
            brandList.Name = "brandList";
            brandList.Size = new Size(96, 23);
            brandList.TabIndex = 0;
            // 
            // unitGrpBox
            // 
            unitGrpBox.Controls.Add(sizeTxt);
            unitGrpBox.Controls.Add(unitList);
            unitGrpBox.Enabled = false;
            unitGrpBox.Location = new Point(531, 361);
            unitGrpBox.Name = "unitGrpBox";
            unitGrpBox.Size = new Size(135, 77);
            unitGrpBox.TabIndex = 13;
            unitGrpBox.TabStop = false;
            unitGrpBox.Text = "Unit";
            // 
            // sizeTxt
            // 
            sizeTxt.Location = new Point(6, 18);
            sizeTxt.Name = "sizeTxt";
            sizeTxt.Size = new Size(121, 23);
            sizeTxt.TabIndex = 1;
            sizeTxt.KeyPress += validateNumericKeypress;
            // 
            // unitList
            // 
            unitList.DropDownStyle = ComboBoxStyle.DropDownList;
            unitList.FormattingEnabled = true;
            unitList.Location = new Point(6, 47);
            unitList.Name = "unitList";
            unitList.Size = new Size(121, 23);
            unitList.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(deptList);
            groupBox8.Location = new Point(678, 361);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(110, 77);
            groupBox8.TabIndex = 14;
            groupBox8.TabStop = false;
            groupBox8.Text = "Department";
            // 
            // deptList
            // 
            deptList.DropDownStyle = ComboBoxStyle.DropDownList;
            deptList.FormattingEnabled = true;
            deptList.Location = new Point(4, 35);
            deptList.Name = "deptList";
            deptList.Size = new Size(95, 23);
            deptList.TabIndex = 0;
            // 
            // prodErr
            // 
            prodErr.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            prodErr.ContainerControl = this;
            // 
            // Product_Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox8);
            Controls.Add(unitGrpBox);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
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
            unitGrpBox.ResumeLayout(false);
            unitGrpBox.PerformLayout();
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)prodErr).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox prodNameTxt;
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
        private Label maxLbl;
        private Label minLbl;
        private GroupBox groupBox3;
        private ComboBox storeList;
        private GroupBox groupBox4;
        private RadioButton add_prod_rad;
        private RadioButton prod_search_rad;
        private GroupBox groupBox5;
        private TextBox skuTxt;
        private GroupBox groupBox6;
        private ComboBox brandList;
        private GroupBox unitGrpBox;
        private TextBox sizeTxt;
        private ComboBox unitList;
        private GroupBox groupBox8;
        private ComboBox deptList;
        private ErrorProvider prodErr;
    }
}