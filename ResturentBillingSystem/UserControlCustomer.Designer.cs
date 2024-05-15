namespace ResturentBillingSystem
{
    partial class UserControlCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchByCustomer = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPurchaseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMathod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTimeAndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.txtSearchByCustomer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvCustomer);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 768);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(679, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Info";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.TotalPurchaseAmount,
            this.PaymentMathod,
            this.PurchaseTimeAndDate});
            this.dgvCustomer.Location = new System.Drawing.Point(69, 278);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(892, 440);
            this.dgvCustomer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(65, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Specific Customer";
            // 
            // txtSearchByCustomer
            // 
            this.txtSearchByCustomer.Location = new System.Drawing.Point(337, 250);
            this.txtSearchByCustomer.Name = "txtSearchByCustomer";
            this.txtSearchByCustomer.Size = new System.Drawing.Size(221, 22);
            this.txtSearchByCustomer.TabIndex = 4;
            this.txtSearchByCustomer.TextChanged += new System.EventHandler(this.txtSearchByCustomer_TextChanged);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // TotalPurchaseAmount
            // 
            this.TotalPurchaseAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPurchaseAmount.DataPropertyName = "TotalPurchaseAmount";
            this.TotalPurchaseAmount.HeaderText = "Total Purchase Amount";
            this.TotalPurchaseAmount.MinimumWidth = 6;
            this.TotalPurchaseAmount.Name = "TotalPurchaseAmount";
            this.TotalPurchaseAmount.ReadOnly = true;
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
            // UserControlCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlCustomer";
            this.Size = new System.Drawing.Size(1030, 768);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchByCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPurchaseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMathod;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTimeAndDate;
    }
}
