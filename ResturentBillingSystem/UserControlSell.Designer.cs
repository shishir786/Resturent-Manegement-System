namespace ResturentBillingSystem
{
    partial class UserControlSell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSell));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSells = new System.Windows.Forms.DataGridView();
            this.BillingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMathod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTimeAndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBySeller = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSells)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.txtSearchBySeller);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvSells);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 765);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(503, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sells Info";
            // 
            // dgvSells
            // 
            this.dgvSells.AllowUserToAddRows = false;
            this.dgvSells.AllowUserToDeleteRows = false;
            this.dgvSells.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSells.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvSells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillingID,
            this.TotalBill,
            this.Seller,
            this.PaymentMathod,
            this.PurchaseTimeAndDate});
            this.dgvSells.Location = new System.Drawing.Point(73, 293);
            this.dgvSells.Name = "dgvSells";
            this.dgvSells.ReadOnly = true;
            this.dgvSells.RowHeadersWidth = 51;
            this.dgvSells.RowTemplate.Height = 24;
            this.dgvSells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSells.Size = new System.Drawing.Size(878, 440);
            this.dgvSells.TabIndex = 0;
            // 
            // BillingID
            // 
            this.BillingID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillingID.DataPropertyName = "BillingID";
            this.BillingID.HeaderText = "Billing Id";
            this.BillingID.MinimumWidth = 6;
            this.BillingID.Name = "BillingID";
            this.BillingID.ReadOnly = true;
            // 
            // TotalBill
            // 
            this.TotalBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalBill.DataPropertyName = "TotalBill";
            this.TotalBill.HeaderText = "Total Bill";
            this.TotalBill.MinimumWidth = 6;
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.ReadOnly = true;
            // 
            // Seller
            // 
            this.Seller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seller.DataPropertyName = "Seller";
            this.Seller.HeaderText = "Seller Name";
            this.Seller.MinimumWidth = 6;
            this.Seller.Name = "Seller";
            this.Seller.ReadOnly = true;
            // 
            // PaymentMathod
            // 
            this.PaymentMathod.DataPropertyName = "PaymentMathod";
            this.PaymentMathod.HeaderText = "Payment Mathod";
            this.PaymentMathod.MinimumWidth = 6;
            this.PaymentMathod.Name = "PaymentMathod";
            this.PaymentMathod.ReadOnly = true;
            // 
            // PurchaseTimeAndDate
            // 
            this.PurchaseTimeAndDate.DataPropertyName = "PurchaseTimeAndDate";
            this.PurchaseTimeAndDate.HeaderText = "Purchase Time & Date";
            this.PurchaseTimeAndDate.MinimumWidth = 6;
            this.PurchaseTimeAndDate.Name = "PurchaseTimeAndDate";
            this.PurchaseTimeAndDate.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by Seller Name";
            // 
            // txtSearchBySeller
            // 
            this.txtSearchBySeller.Location = new System.Drawing.Point(282, 259);
            this.txtSearchBySeller.Name = "txtSearchBySeller";
            this.txtSearchBySeller.Size = new System.Drawing.Size(190, 22);
            this.txtSearchBySeller.TabIndex = 4;
            this.txtSearchBySeller.TextChanged += new System.EventHandler(this.txtSearchBySeller_TextChanged);
            // 
            // UserControlSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlSell";
            this.Size = new System.Drawing.Size(1030, 768);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSells)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSells;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMathod;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTimeAndDate;
        private System.Windows.Forms.TextBox txtSearchBySeller;
        private System.Windows.Forms.Label label2;
    }
}
