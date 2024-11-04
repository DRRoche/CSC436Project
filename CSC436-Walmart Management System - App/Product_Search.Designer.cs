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
            dataGridView1 = new DataGridView();
            searchBox = new TextBox();
            button1 = new Button();
            exactlyRad = new RadioButton();
            anyRad = new RadioButton();
            allRad = new RadioButton();
            searchMatchChoiceBox = new GroupBox();
            radioButton4 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            searchMatchChoiceBox.SuspendLayout();
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
            searchBox.Location = new Point(24, 301);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(618, 23);
            searchBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(687, 301);
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
            searchMatchChoiceBox.Location = new Point(24, 330);
            searchMatchChoiceBox.Name = "searchMatchChoiceBox";
            searchMatchChoiceBox.Size = new Size(303, 47);
            searchMatchChoiceBox.TabIndex = 6;
            searchMatchChoiceBox.TabStop = false;
            searchMatchChoiceBox.Text = "Match:";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(351, 342);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Product_Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton4);
            Controls.Add(searchMatchChoiceBox);
            Controls.Add(button1);
            Controls.Add(searchBox);
            Controls.Add(dataGridView1);
            Name = "Product_Search";
            Text = "Product_Search";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            searchMatchChoiceBox.ResumeLayout(false);
            searchMatchChoiceBox.PerformLayout();
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
        private RadioButton radioButton4;
    }
}