namespace CSC436_Walmart_Management_System___App
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            prod_search_btn = new Button();
            prod_man_btn = new Button();
            emp_search_btn = new Button();
            emp_man_btn = new Button();
            SuspendLayout();
            // 
            // prod_search_btn
            // 
            prod_search_btn.Location = new Point(319, 76);
            prod_search_btn.Name = "prod_search_btn";
            prod_search_btn.Size = new Size(148, 44);
            prod_search_btn.TabIndex = 0;
            prod_search_btn.Text = "Product Search";
            prod_search_btn.UseVisualStyleBackColor = true;
            prod_search_btn.Click += ProdSearchButton;
            // 
            // prod_man_btn
            // 
            prod_man_btn.Location = new Point(319, 156);
            prod_man_btn.Name = "prod_man_btn";
            prod_man_btn.Size = new Size(148, 44);
            prod_man_btn.TabIndex = 1;
            prod_man_btn.Text = "Product Manager";
            prod_man_btn.UseVisualStyleBackColor = true;
            prod_man_btn.Click += ProdManagerButton;
            // 
            // emp_search_btn
            // 
            emp_search_btn.Location = new Point(319, 233);
            emp_search_btn.Name = "emp_search_btn";
            emp_search_btn.Size = new Size(148, 44);
            emp_search_btn.TabIndex = 2;
            emp_search_btn.Text = "Employee Lookup";
            emp_search_btn.UseVisualStyleBackColor = true;
            emp_search_btn.Click += EmpLookupButton;
            // 
            // emp_man_btn
            // 
            emp_man_btn.Location = new Point(333, 305);
            emp_man_btn.Name = "emp_man_btn";
            emp_man_btn.Size = new Size(148, 44);
            emp_man_btn.TabIndex = 3;
            emp_man_btn.Text = "Employee Manager";
            emp_man_btn.UseVisualStyleBackColor = true;
            emp_man_btn.Click += EmpManButton;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(emp_man_btn);
            Controls.Add(emp_search_btn);
            Controls.Add(prod_man_btn);
            Controls.Add(prod_search_btn);
            Name = "MainMenu";
            Text = "Walmart Management System - Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button prod_search_btn;
        private Button prod_man_btn;
        private Button emp_search_btn;
        private Button emp_man_btn;
    }
}
