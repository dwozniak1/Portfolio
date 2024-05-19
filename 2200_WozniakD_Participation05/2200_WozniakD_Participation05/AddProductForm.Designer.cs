namespace _2200_WozniakD_Participation05
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblNewCategory = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtBoxProdNum = new System.Windows.Forms.TextBox();
            this.TxtBoxDesc = new System.Windows.Forms.TextBox();
            this.TxtBoxUnits = new System.Windows.Forms.TextBox();
            this.TxtBoxPrice = new System.Windows.Forms.TextBox();
            this.TxtBoxNew = new System.Windows.Forms.TextBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Units On Hand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category";
            // 
            // LblNewCategory
            // 
            this.LblNewCategory.AutoSize = true;
            this.LblNewCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblNewCategory.Location = new System.Drawing.Point(624, 441);
            this.LblNewCategory.Name = "LblNewCategory";
            this.LblNewCategory.Size = new System.Drawing.Size(78, 32);
            this.LblNewCategory.TabIndex = 0;
            this.LblNewCategory.Text = "New:";
            this.LblNewCategory.Visible = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(302, 542);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(672, 63);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(861, 688);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(303, 63);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtBoxProdNum
            // 
            this.TxtBoxProdNum.Location = new System.Drawing.Point(302, 46);
            this.TxtBoxProdNum.Name = "TxtBoxProdNum";
            this.TxtBoxProdNum.Size = new System.Drawing.Size(672, 39);
            this.TxtBoxProdNum.TabIndex = 2;
            // 
            // TxtBoxDesc
            // 
            this.TxtBoxDesc.Location = new System.Drawing.Point(302, 145);
            this.TxtBoxDesc.Name = "TxtBoxDesc";
            this.TxtBoxDesc.Size = new System.Drawing.Size(672, 39);
            this.TxtBoxDesc.TabIndex = 2;
            // 
            // TxtBoxUnits
            // 
            this.TxtBoxUnits.Location = new System.Drawing.Point(302, 243);
            this.TxtBoxUnits.Name = "TxtBoxUnits";
            this.TxtBoxUnits.Size = new System.Drawing.Size(672, 39);
            this.TxtBoxUnits.TabIndex = 2;
            // 
            // TxtBoxPrice
            // 
            this.TxtBoxPrice.Location = new System.Drawing.Point(302, 334);
            this.TxtBoxPrice.Name = "TxtBoxPrice";
            this.TxtBoxPrice.Size = new System.Drawing.Size(672, 39);
            this.TxtBoxPrice.TabIndex = 2;
            // 
            // TxtBoxNew
            // 
            this.TxtBoxNew.Location = new System.Drawing.Point(708, 441);
            this.TxtBoxNew.Name = "TxtBoxNew";
            this.TxtBoxNew.Size = new System.Drawing.Size(266, 39);
            this.TxtBoxNew.TabIndex = 2;
            this.TxtBoxNew.Visible = false;
            // 
            // CbCategory
            // 
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(302, 444);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(302, 40);
            this.CbCategory.TabIndex = 3;
            this.CbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 779);
            this.Controls.Add(this.CbCategory);
            this.Controls.Add(this.TxtBoxNew);
            this.Controls.Add(this.TxtBoxPrice);
            this.Controls.Add(this.TxtBoxUnits);
            this.Controls.Add(this.TxtBoxDesc);
            this.Controls.Add(this.TxtBoxProdNum);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblNewCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddProductForm";
            this.Text = "Add Product Form";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblNewCategory;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtBoxProdNum;
        private System.Windows.Forms.TextBox TxtBoxDesc;
        private System.Windows.Forms.TextBox TxtBoxUnits;
        private System.Windows.Forms.TextBox TxtBoxPrice;
        private System.Windows.Forms.TextBox TxtBoxNew;
        private System.Windows.Forms.ComboBox CbCategory;
    }
}