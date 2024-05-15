namespace ResturentBillingSystem
{
    partial class UserControlOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mcmbQuantity = new MaterialSkin.Controls.MaterialComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtItemName = new MaterialSkin.Controls.MaterialTextBox2();
            this.mtxtPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.mtxtFoodID = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPaymentMathod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbFood = new System.Windows.Forms.DataGridView();
            this.FoodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(147)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnSearchFood);
            this.panel1.Controls.Add(this.txtSearchFood);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgbFood);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 764);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFood.Location = new System.Drawing.Point(168, 361);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(135, 28);
            this.btnSearchFood.TabIndex = 7;
            this.btnSearchFood.Text = "Search Food";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFood.Location = new System.Drawing.Point(9, 363);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(153, 24);
            this.txtSearchFood.TabIndex = 6;
            this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(214)))), ((int)(((byte)(5)))));
            this.label10.Location = new System.Drawing.Point(12, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(268, 68);
            this.label10.TabIndex = 5;
            this.label10.Text = "Order Food";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.mcmbQuantity);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.mtxtItemName);
            this.panel3.Controls.Add(this.mtxtPrice);
            this.panel3.Controls.Add(this.mtxtFoodID);
            this.panel3.Location = new System.Drawing.Point(309, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 379);
            this.panel3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Then Select quantity and Add to Cart";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Double Click from the table to to select Item";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(120)))), ((int)(((byte)(63)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(275, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mcmbQuantity
            // 
            this.mcmbQuantity.AutoResize = false;
            this.mcmbQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcmbQuantity.Depth = 0;
            this.mcmbQuantity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcmbQuantity.DropDownHeight = 174;
            this.mcmbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcmbQuantity.DropDownWidth = 121;
            this.mcmbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcmbQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcmbQuantity.FormattingEnabled = true;
            this.mcmbQuantity.IntegralHeight = false;
            this.mcmbQuantity.ItemHeight = 43;
            this.mcmbQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.mcmbQuantity.Location = new System.Drawing.Point(135, 271);
            this.mcmbQuantity.MaxDropDownItems = 4;
            this.mcmbQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.mcmbQuantity.Name = "mcmbQuantity";
            this.mcmbQuantity.Size = new System.Drawing.Size(158, 49);
            this.mcmbQuantity.StartIndex = 0;
            this.mcmbQuantity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food ID";
            // 
            // mtxtItemName
            // 
            this.mtxtItemName.AnimateReadOnly = false;
            this.mtxtItemName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtxtItemName.Depth = 0;
            this.mtxtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtItemName.HideSelection = true;
            this.mtxtItemName.LeadingIcon = null;
            this.mtxtItemName.Location = new System.Drawing.Point(135, 136);
            this.mtxtItemName.MaxLength = 32767;
            this.mtxtItemName.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtItemName.Name = "mtxtItemName";
            this.mtxtItemName.PasswordChar = '\0';
            this.mtxtItemName.PrefixSuffixText = null;
            this.mtxtItemName.ReadOnly = false;
            this.mtxtItemName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtItemName.SelectedText = "";
            this.mtxtItemName.SelectionLength = 0;
            this.mtxtItemName.SelectionStart = 0;
            this.mtxtItemName.ShortcutsEnabled = true;
            this.mtxtItemName.Size = new System.Drawing.Size(158, 48);
            this.mtxtItemName.TabIndex = 1;
            this.mtxtItemName.TabStop = false;
            this.mtxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtItemName.TrailingIcon = null;
            this.mtxtItemName.UseSystemPasswordChar = false;
            // 
            // mtxtPrice
            // 
            this.mtxtPrice.AnimateReadOnly = false;
            this.mtxtPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtxtPrice.Depth = 0;
            this.mtxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtPrice.HideSelection = true;
            this.mtxtPrice.LeadingIcon = null;
            this.mtxtPrice.Location = new System.Drawing.Point(135, 205);
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
            this.mtxtPrice.Size = new System.Drawing.Size(158, 48);
            this.mtxtPrice.TabIndex = 1;
            this.mtxtPrice.TabStop = false;
            this.mtxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtPrice.TrailingIcon = null;
            this.mtxtPrice.UseSystemPasswordChar = false;
            // 
            // mtxtFoodID
            // 
            this.mtxtFoodID.AnimateReadOnly = false;
            this.mtxtFoodID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtFoodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtxtFoodID.Depth = 0;
            this.mtxtFoodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtFoodID.HideSelection = true;
            this.mtxtFoodID.LeadingIcon = null;
            this.mtxtFoodID.Location = new System.Drawing.Point(135, 69);
            this.mtxtFoodID.MaxLength = 32767;
            this.mtxtFoodID.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtFoodID.Name = "mtxtFoodID";
            this.mtxtFoodID.PasswordChar = '\0';
            this.mtxtFoodID.PrefixSuffixText = null;
            this.mtxtFoodID.ReadOnly = true;
            this.mtxtFoodID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtFoodID.SelectedText = "";
            this.mtxtFoodID.SelectionLength = 0;
            this.mtxtFoodID.SelectionStart = 0;
            this.mtxtFoodID.ShortcutsEnabled = true;
            this.mtxtFoodID.Size = new System.Drawing.Size(158, 48);
            this.mtxtFoodID.TabIndex = 1;
            this.mtxtFoodID.TabStop = false;
            this.mtxtFoodID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtFoodID.TrailingIcon = null;
            this.mtxtFoodID.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(120)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.btnConfirmOrder);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmbPaymentMathod);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblTotalBill);
            this.panel2.Controls.Add(this.dgvCart);
            this.panel2.Location = new System.Drawing.Point(635, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 758);
            this.panel2.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(214, 593);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(147, 30);
            this.txtCustomerName.TabIndex = 7;
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(92, 695);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(185, 48);
            this.btnConfirmOrder.TabIndex = 6;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(22, 591);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Customer Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(22, 645);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Payment Mathod";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(317, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "BDT";
            // 
            // cmbPaymentMathod
            // 
            this.cmbPaymentMathod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMathod.FormattingEnabled = true;
            this.cmbPaymentMathod.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Mobile Banking"});
            this.cmbPaymentMathod.Location = new System.Drawing.Point(214, 645);
            this.cmbPaymentMathod.Name = "cmbPaymentMathod";
            this.cmbPaymentMathod.Size = new System.Drawing.Size(147, 33);
            this.cmbPaymentMathod.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(22, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Bill :";
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalBill.Location = new System.Drawing.Point(238, 540);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(64, 25);
            this.lblTotalBill.TabIndex = 1;
            this.lblTotalBill.Text = "label5";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(120)))), ((int)(((byte)(63)))));
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemPrice});
            this.dgvCart.Location = new System.Drawing.Point(3, 3);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(376, 508);
            this.dgvCart.TabIndex = 0;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "Item Total price";
            this.ItemPrice.MinimumWidth = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // dgbFood
            // 
            this.dgbFood.AllowUserToAddRows = false;
            this.dgbFood.AllowUserToDeleteRows = false;
            this.dgbFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbFood.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgbFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodID,
            this.FoodName,
            this.Price});
            this.dgbFood.Location = new System.Drawing.Point(9, 391);
            this.dgbFood.Name = "dgbFood";
            this.dgbFood.ReadOnly = true;
            this.dgbFood.RowHeadersWidth = 51;
            this.dgbFood.RowTemplate.Height = 24;
            this.dgbFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbFood.Size = new System.Drawing.Size(620, 369);
            this.dgbFood.TabIndex = 1;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "label12";
            // 
            // UserControlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlOrder";
            this.Size = new System.Drawing.Size(1027, 768);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridView dgbFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtItemName;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtPrice;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtFoodID;
        private MaterialSkin.Controls.MaterialComboBox mcmbQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPaymentMathod;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label12;
    }
}
