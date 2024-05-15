namespace ResturentBillingSystem
{
    partial class FormManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSells = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlCustomer1 = new ResturentBillingSystem.UserControlCustomer();
            this.userControlSell1 = new ResturentBillingSystem.UserControlSell();
            this.userControlFood1 = new ResturentBillingSystem.UserControlFood();
            this.userControlEmp1 = new ResturentBillingSystem.UserControlEmp();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnSells);
            this.panel1.Controls.Add(this.btnFood);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Location = new System.Drawing.Point(-7, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 768);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Location = new System.Drawing.Point(4, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 222);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Myanmar Text", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(121, 188);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(62, 30);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "label3";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(73, 603);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(188, 80);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer Info";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSells
            // 
            this.btnSells.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSells.Location = new System.Drawing.Point(73, 487);
            this.btnSells.Name = "btnSells";
            this.btnSells.Size = new System.Drawing.Size(188, 80);
            this.btnSells.TabIndex = 0;
            this.btnSells.Text = "Sells";
            this.btnSells.UseVisualStyleBackColor = true;
            this.btnSells.Click += new System.EventHandler(this.btnSells_Click);
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(73, 375);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(188, 80);
            this.btnFood.TabIndex = 0;
            this.btnFood.Text = "Food Items";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(73, 264);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(188, 80);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee Details";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControlCustomer1);
            this.panel2.Controls.Add(this.userControlSell1);
            this.panel2.Controls.Add(this.userControlFood1);
            this.panel2.Controls.Add(this.userControlEmp1);
            this.panel2.Location = new System.Drawing.Point(336, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 768);
            this.panel2.TabIndex = 1;
            // 
            // userControlCustomer1
            // 
            this.userControlCustomer1.Location = new System.Drawing.Point(0, -3);
            this.userControlCustomer1.Name = "userControlCustomer1";
            this.userControlCustomer1.Size = new System.Drawing.Size(1030, 768);
            this.userControlCustomer1.TabIndex = 3;
            // 
            // userControlSell1
            // 
            this.userControlSell1.Location = new System.Drawing.Point(-3, 0);
            this.userControlSell1.Name = "userControlSell1";
            this.userControlSell1.Size = new System.Drawing.Size(1030, 768);
            this.userControlSell1.TabIndex = 2;
            // 
            // userControlFood1
            // 
            this.userControlFood1.Location = new System.Drawing.Point(0, 0);
            this.userControlFood1.Name = "userControlFood1";
            this.userControlFood1.Size = new System.Drawing.Size(1030, 768);
            this.userControlFood1.TabIndex = 1;
            // 
            // userControlEmp1
            // 
            this.userControlEmp1.Location = new System.Drawing.Point(0, -3);
            this.userControlEmp1.Name = "userControlEmp1";
            this.userControlEmp1.Size = new System.Drawing.Size(1030, 768);
            this.userControlEmp1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(505, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(110, 707);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(104, 37);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 830);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Dashboard";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSells;
        private System.Windows.Forms.Panel panel2;
        private UserControlEmp userControl11;
        private UserControlCustomer userControlCustomer1;
        private UserControlSell userControlSell1;
        private UserControlFood userControlFood1;
        private UserControlEmp userControlEmp1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogOut;
    }
}