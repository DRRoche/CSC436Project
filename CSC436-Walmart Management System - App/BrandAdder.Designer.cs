namespace CSC436_Walmart_Management_System___App
{
    partial class BrandAdder
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
            brandNameTxt = new TextBox();
            brandIdTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addBrandBtn = new Button();
            chainExclusiveChk = new CheckBox();
            SuspendLayout();
            // 
            // brandNameTxt
            // 
            brandNameTxt.Location = new Point(98, 33);
            brandNameTxt.Name = "brandNameTxt";
            brandNameTxt.Size = new Size(100, 23);
            brandNameTxt.TabIndex = 0;
            // 
            // brandIdTxt
            // 
            brandIdTxt.Location = new Point(98, 77);
            brandIdTxt.Name = "brandIdTxt";
            brandIdTxt.Size = new Size(100, 23);
            brandIdTxt.TabIndex = 1;
            brandIdTxt.KeyPress += brandIdTxt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Brand Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 80);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Brand ID:";
            // 
            // addBrandBtn
            // 
            addBrandBtn.Location = new Point(69, 147);
            addBrandBtn.Name = "addBrandBtn";
            addBrandBtn.Size = new Size(75, 23);
            addBrandBtn.TabIndex = 4;
            addBrandBtn.Text = "Add Brand";
            addBrandBtn.UseVisualStyleBackColor = true;
            addBrandBtn.Click += addBrandBtn_Click;
            // 
            // chainExclusiveChk
            // 
            chainExclusiveChk.AutoSize = true;
            chainExclusiveChk.Location = new Point(69, 122);
            chainExclusiveChk.Name = "chainExclusiveChk";
            chainExclusiveChk.Size = new Size(87, 19);
            chainExclusiveChk.TabIndex = 5;
            chainExclusiveChk.Text = "Store Brand";
            chainExclusiveChk.UseVisualStyleBackColor = true;
            // 
            // BrandAdder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 206);
            Controls.Add(chainExclusiveChk);
            Controls.Add(addBrandBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(brandIdTxt);
            Controls.Add(brandNameTxt);
            Name = "BrandAdder";
            Text = "BrandAdder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox brandNameTxt;
        private TextBox brandIdTxt;
        private Label label1;
        private Label label2;
        private Button addBrandBtn;
        private CheckBox chainExclusiveChk;
    }
}