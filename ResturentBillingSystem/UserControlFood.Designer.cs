namespace ResturentBillingSystem
{
    partial class UserControlFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlFood));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.mtxtPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.mtxFoodID = new MaterialSkin.Controls.MaterialTextBox2();
            this.mtxtFoodName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.dgbFood = new System.Windows.Forms.DataGridView();
            this.FoodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.txtSearchFood);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgbFood);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 765);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.mtxtPrice);
            this.panel2.Controls.Add(this.mtxFoodID);
            this.panel2.Controls.Add(this.mtxtFoodName);
            this.panel2.Location = new System.Drawing.Point(527, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 327);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(18, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "* for Edit any info double click on the item in table then Edit and Save";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "* for Removing a item, please select and then press Delete button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add or Remove Item";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(273, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 51);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(273, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 51);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(273, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 51);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mtxtPrice
            // 
            this.mtxtPrice.AnimateReadOnly = false;
            this.mtxtPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtxtPrice.Depth = 0;
            this.mtxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtPrice.HideSelection = true;
            this.mtxtPrice.Hint = "Price";
            this.mtxtPrice.LeadingIcon = null;
            this.mtxtPrice.Location = new System.Drawing.Point(24, 256);
            this.mtxtPrice.MaxLength = 32767;
            this.mtxtPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtPrice.Name = "mtxtPrice";
            this.mtxtPrice.PasswordChar = '\0';
            this.mtxtPrice.PrefixSuffixText = null;
            this.mtxtPrice.ReadOnly = false;
            this.mtxtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtPrice.SelectedText = "";
            this.mtxtPrice.SelectionLength = 0;
            this.mtxtPrice.SelectionStart = 0;
            this.mtxtPrice.ShortcutsEnabled = true;
            this.mtxtPrice.Size = new System.Drawing.Size(192, 48);
            this.mtxtPrice.TabIndex = 1;
            this.mtxtPrice.TabStop = false;
            this.mtxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtPrice.TrailingIcon = null;
            this.mtxtPrice.UseSystemPasswordChar = false;
            // 
            // mtxFoodID
            // 
            this.mtxFoodID.AnimateReadOnly = false;
            this.mtxFoodID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxFoodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtxFoodID.Depth = 0;
            this.mtxFoodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxFoodID.HideSelection = true;
            this.mtxFoodID.Hint = "Food ID";
            this.mtxFoodID.LeadingIcon = null;
            this.mtxFoodID.Location = new System.Drawing.Point(24, 129);
            this.mtxFoodID.MaxLength = 32767;
            this.mtxFoodID.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxFoodID.Name = "mtxFoodID";
            this.mtxFoodID.PasswordChar = '\0';
            this.mtxFoodID.PrefixSuffixText = null;
            this.mtxFoodID.ReadOnly = true;
            this.mtxFoodID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxFoodID.SelectedText = "";
            this.mtxFoodID.SelectionLength = 0;
            this.mtxFoodID.SelectionStart = 0;
            this.mtxFoodID.ShortcutsEnabled = true;
            this.mtxFoodID.Size = new System.Drawing.Size(192, 48);
            this.mtxFoodID.TabIndex = 0;
            this.mtxFoodID.TabStop = false;
            this.mtxFoodID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxFoodID.TrailingIcon = null;
            this.mtxFoodID.UseSystemPasswordChar = false;
            // 
            // mtxtFoodName
            // 
            this.mtxtFoodName.AnimateReadOnly = false;
            this.mtxtFoodName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtFoodName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtxtFoodName.Depth = 0;
            this.mtxtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtFoodName.HideSelection = true;
            this.mtxtFoodName.Hint = "Food Item";
            this.mtxtFoodName.LeadingIcon = null;
            this.mtxtFoodName.Location = new System.Drawing.Point(24, 192);
            this.mtxtFoodName.MaxLength = 32767;
            this.mtxtFoodName.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtFoodName.Name = "mtxtFoodName";
            this.mtxtFoodName.PasswordChar = '\0';
            this.mtxtFoodName.PrefixSuffixText = null;
            this.mtxtFoodName.ReadOnly = false;
            this.mtxtFoodName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtFoodName.SelectedText = "";
            this.mtxtFoodName.SelectionLength = 0;
            this.mtxtFoodName.SelectionStart = 0;
            this.mtxtFoodName.ShortcutsEnabled = true;
            this.mtxtFoodName.Size = new System.Drawing.Size(192, 48);
            this.mtxtFoodName.TabIndex = 0;
            this.mtxtFoodName.TabStop = false;
            this.mtxtFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtFoodName.TrailingIcon = null;
            this.mtxtFoodName.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Items";
            // 
            // dgbFood
            // 
            this.dgbFood.AllowUserToAddRows = false;
            this.dgbFood.AllowUserToDeleteRows = false;
            this.dgbFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodID,
            this.FoodName,
            this.Price});
            this.dgbFood.Location = new System.Drawing.Point(30, 408);
            this.dgbFood.Name = "dgbFood";
            this.dgbFood.ReadOnly = true;
            this.dgbFood.RowHeadersWidth = 51;
            this.dgbFood.RowTemplate.Height = 24;
            this.dgbFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbFood.Size = new System.Drawing.Size(954, 322);
            this.dgbFood.TabIndex = 0;
            this.dgbFood.DoubleClick += new System.EventHandler(this.dgbFood_DoubleClick);
            // 
            // FoodID
            // 
            this.FoodID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodID.DataPropertyName = "FoodID";
            this.FoodID.HeaderText = "Food ID";
            this.FoodID.MinimumWidth = 6;
            this.FoodID.Name = "FoodID";
            this.FoodID.ReadOnly = true;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "Food Item Name";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price ";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(195, 380);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(190, 22);
            this.txtSearchFood.TabIndex = 6;
            this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Search Food Item";
            // 
            // UserControlFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlFood";
            this.Size = new System.Drawing.Size(1030, 768);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtFoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgbFood;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox2 mtxFoodID;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Label label5;
    }
}
