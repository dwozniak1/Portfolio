namespace _2200_WozniakD_Participation05
{
    partial class ProductSearchForm
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
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxProductDesc = new System.Windows.Forms.TextBox();
            this.BtnAddNewProd = new System.Windows.Forms.Button();
            this.BtnDeleteProd = new System.Windows.Forms.Button();
            this.CbProdId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProducts
            // 
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Location = new System.Drawing.Point(12, 12);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.RowHeadersWidth = 62;
            this.DgvProducts.RowTemplate.Height = 28;
            this.DgvProducts.Size = new System.Drawing.Size(958, 326);
            this.DgvProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Id";
            // 
            // TxtBoxProductDesc
            // 
            this.TxtBoxProductDesc.Location = new System.Drawing.Point(166, 371);
            this.TxtBoxProductDesc.Name = "TxtBoxProductDesc";
            this.TxtBoxProductDesc.Size = new System.Drawing.Size(410, 26);
            this.TxtBoxProductDesc.TabIndex = 2;
            this.TxtBoxProductDesc.TextChanged += new System.EventHandler(this.TxtBoxProductDesc_TextChanged);
            // 
            // BtnAddNewProd
            // 
            this.BtnAddNewProd.Location = new System.Drawing.Point(741, 361);
            this.BtnAddNewProd.Name = "BtnAddNewProd";
            this.BtnAddNewProd.Size = new System.Drawing.Size(229, 53);
            this.BtnAddNewProd.TabIndex = 3;
            this.BtnAddNewProd.Text = "Add New Product";
            this.BtnAddNewProd.UseVisualStyleBackColor = true;
            this.BtnAddNewProd.Click += new System.EventHandler(this.BtnAddNewProd_Click);
            // 
            // BtnDeleteProd
            // 
            this.BtnDeleteProd.Location = new System.Drawing.Point(741, 449);
            this.BtnDeleteProd.Name = "BtnDeleteProd";
            this.BtnDeleteProd.Size = new System.Drawing.Size(229, 53);
            this.BtnDeleteProd.TabIndex = 3;
            this.BtnDeleteProd.Text = "Delete Product";
            this.BtnDeleteProd.UseVisualStyleBackColor = true;
            this.BtnDeleteProd.Click += new System.EventHandler(this.BtnDeleteProd_Click);
            // 
            // CbProdId
            // 
            this.CbProdId.FormattingEnabled = true;
            this.CbProdId.Location = new System.Drawing.Point(476, 465);
            this.CbProdId.Name = "CbProdId";
            this.CbProdId.Size = new System.Drawing.Size(241, 28);
            this.CbProdId.TabIndex = 4;
            // 
            // ProductSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 545);
            this.Controls.Add(this.CbProdId);
            this.Controls.Add(this.BtnDeleteProd);
            this.Controls.Add(this.BtnAddNewProd);
            this.Controls.Add(this.TxtBoxProductDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvProducts);
            this.Name = "ProductSearchForm";
            this.Text = "Product Search Form";
            this.Load += new System.EventHandler(this.ProductSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxProductDesc;
        private System.Windows.Forms.Button BtnAddNewProd;
        private System.Windows.Forms.Button BtnDeleteProd;
        private System.Windows.Forms.ComboBox CbProdId;
    }
}