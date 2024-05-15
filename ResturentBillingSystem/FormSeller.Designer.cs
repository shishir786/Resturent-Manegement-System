namespace ResturentBillingSystem
{
    partial class FormSeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeller));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlOrder1 = new ResturentBillingSystem.UserControlOrder();
            this.userControlFood1 = new ResturentBillingSystem.UserControlFood();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnFood);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(70, 388);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(188, 80);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(70, 528);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(188, 80);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "Food Items";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(91)))), ((int)(((byte)(4)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 248);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Welcome ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Myanmar Text", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(115, 216);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(62, 30);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControlOrder1);
            this.panel2.Controls.Add(this.userControlFood1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(347, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 767);
            this.panel2.TabIndex = 1;
            // 
            // userControlOrder1
            // 
            this.userControlOrder1.Location = new System.Drawing.Point(0, -4);
            this.userControlOrder1.Name = "userControlOrder1";
            this.userControlOrder1.Size = new System.Drawing.Size(1027, 768);
            this.userControlOrder1.TabIndex = 7;
            // 
            // userControlFood1
            // 
            this.userControlFood1.Location = new System.Drawing.Point(0, 3);
            this.userControlFood1.Name = "userControlFood1";
            this.userControlFood1.Size = new System.Drawing.Size(1030, 768);
            this.userControlFood1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(194, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(625, 565);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(105, 683);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(104, 37);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // FormSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 830);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeller";
            this.Load += new System.EventHandler(this.FormSeller_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnFood;
        private UserControlFood userControlFood1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UserControlOrder userControlOrder1;
        private System.Windows.Forms.Button btnLogOut;
    }
}