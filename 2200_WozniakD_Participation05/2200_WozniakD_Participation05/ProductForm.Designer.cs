namespace _2200_WozniakD_Participation05
{
    partial class ProductForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnGroupCat = new System.Windows.Forms.Button();
            this.BtnProdSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2200_WozniakD_Participation05.Properties.Resources.before1;
            this.pictureBox1.Location = new System.Drawing.Point(-38, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 785);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnGroupCat
            // 
            this.BtnGroupCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnGroupCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGroupCat.Location = new System.Drawing.Point(305, 548);
            this.BtnGroupCat.Name = "BtnGroupCat";
            this.BtnGroupCat.Size = new System.Drawing.Size(235, 66);
            this.BtnGroupCat.TabIndex = 1;
            this.BtnGroupCat.Text = "Group By Category";
            this.BtnGroupCat.UseVisualStyleBackColor = false;
            this.BtnGroupCat.Click += new System.EventHandler(this.BtnGroupCat_Click);
            // 
            // BtnProdSearch
            // 
            this.BtnProdSearch.BackColor = System.Drawing.Color.Gray;
            this.BtnProdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdSearch.ForeColor = System.Drawing.Color.White;
            this.BtnProdSearch.Location = new System.Drawing.Point(12, 548);
            this.BtnProdSearch.Name = "BtnProdSearch";
            this.BtnProdSearch.Size = new System.Drawing.Size(235, 66);
            this.BtnProdSearch.TabIndex = 1;
            this.BtnProdSearch.Text = "Product Search";
            this.BtnProdSearch.UseVisualStyleBackColor = false;
            this.BtnProdSearch.Click += new System.EventHandler(this.BtnProdSearch_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 642);
            this.Controls.Add(this.BtnProdSearch);
            this.Controls.Add(this.BtnGroupCat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductForm";
            this.Text = "Delaney\'s Clothes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnGroupCat;
        private System.Windows.Forms.Button BtnProdSearch;
    }
}

