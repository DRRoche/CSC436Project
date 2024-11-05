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
            searchBox = new TextBox();
            button1 = new Button();
            exactlyRad = new RadioButton();
            anyRad = new RadioButton();
            allRad = new RadioButton();
            searchMatchChoiceBox = new GroupBox();
            groupBox1 = new GroupBox();
            prodNameSearchRad = new RadioButton();
            databaseHelperBindingSource = new BindingSource(components);
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            searchMatchChoiceBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(764, 270);
            dataGridView1.TabIndex = 0;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(6, 22);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(205, 23);
            searchBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(235, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            groupBox1.Controls.Add(searchBox);
            groupBox1.Controls.Add(searchMatchChoiceBox);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(49, 288);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 112);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product name";
            // 
            // prodNameSearchRad
            // 
            prodNameSearchRad.AutoSize = true;
            prodNameSearchRad.Checked = true;
            prodNameSearchRad.Location = new Point(24, 300);
            prodNameSearchRad.Name = "prodNameSearchRad";
            prodNameSearchRad.Size = new Size(14, 13);
            prodNameSearchRad.TabIndex = 8;
            prodNameSearchRad.TabStop = true;
            prodNameSearchRad.UseVisualStyleBackColor = true;
            // 
            // databaseHelperBindingSource
            // 
            databaseHelperBindingSource.DataSource = typeof(DatabaseHelper);
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(376, 298);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Product_Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton1);
            Controls.Add(prodNameSearchRad);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Product_Search";
            Text = "Product_Search";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            searchMatchChoiceBox.ResumeLayout(false);
            searchMatchChoiceBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox searchBox;
        private Button button1;
        private RadioButton exactlyRad;
        private RadioButton anyRad;
        private RadioButton allRad;
        private GroupBox searchMatchChoiceBox;
        private GroupBox groupBox1;
        private RadioButton prodNameSearchRad;
        private BindingSource databaseHelperBindingSource;
        private RadioButton radioButton1;
    }
}