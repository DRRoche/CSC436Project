namespace CSC436_Walmart_Management_System___App
{
    partial class ProductDetailsForm
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
            skuLbl = new Label();
            prodNameLbl = new Label();
            priceLbl = new Label();
            skuTxt = new TextBox();
            prodNameTxt = new TextBox();
            priceTxt = new TextBox();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // skuLbl
            // 
            skuLbl.AutoSize = true;
            skuLbl.Location = new Point(50, 30);
            skuLbl.Name = "skuLbl";
            skuLbl.Size = new Size(31, 15);
            skuLbl.TabIndex = 0;
            skuLbl.Text = "SKU:";
            // 
            // prodNameLbl
            // 
            prodNameLbl.AutoSize = true;
            prodNameLbl.Location = new Point(50, 68);
            prodNameLbl.Name = "prodNameLbl";
            prodNameLbl.Size = new Size(87, 15);
            prodNameLbl.TabIndex = 1;
            prodNameLbl.Text = "Product Name:";
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(50, 110);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(36, 15);
            priceLbl.TabIndex = 2;
            priceLbl.Text = "Price:";
            // 
            // skuTxt
            // 
            skuTxt.Location = new Point(87, 27);
            skuTxt.Name = "skuTxt";
            skuTxt.ReadOnly = true;
            skuTxt.Size = new Size(250, 23);
            skuTxt.TabIndex = 3;
            // 
            // prodNameTxt
            // 
            prodNameTxt.Location = new Point(143, 60);
            prodNameTxt.Name = "prodNameTxt";
            prodNameTxt.Size = new Size(194, 23);
            prodNameTxt.TabIndex = 4;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(92, 107);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(55, 23);
            priceTxt.TabIndex = 5;
            priceTxt.KeyPress += validateNumericKeypress;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(132, 177);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(131, 23);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "Update Product";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 247);
            Controls.Add(updateBtn);
            Controls.Add(priceTxt);
            Controls.Add(prodNameTxt);
            Controls.Add(skuTxt);
            Controls.Add(priceLbl);
            Controls.Add(prodNameLbl);
            Controls.Add(skuLbl);
            Name = "ProductDetailsForm";
            Text = "ProductDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label skuLbl;
        private Label prodNameLbl;
        private Label priceLbl;
        private TextBox skuTxt;
        private TextBox prodNameTxt;
        private TextBox priceTxt;
        private Button updateBtn;
    }
}