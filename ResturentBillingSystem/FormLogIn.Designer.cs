namespace ResturentBillingSystem
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.mtxtUserName = new MaterialSkin.Controls.MaterialTextBox();
            this.mtxtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-5, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 766);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.btnLogIn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnLogIn);
            this.panel2.Controls.Add(this.mtxtUserName);
            this.panel2.Controls.Add(this.mtxtPassword);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(222, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 466);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "User Name";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Crimson;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(47, 274);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(373, 50);
            this.btnLogIn.TabIndex = 9;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click_1);
            // 
            // mtxtUserName
            // 
            this.mtxtUserName.AnimateReadOnly = false;
            this.mtxtUserName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mtxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtUserName.Depth = 0;
            this.mtxtUserName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtUserName.LeadingIcon = null;
            this.mtxtUserName.Location = new System.Drawing.Point(184, 130);
            this.mtxtUserName.MaxLength = 50;
            this.mtxtUserName.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtUserName.Multiline = false;
            this.mtxtUserName.Name = "mtxtUserName";
            this.mtxtUserName.Size = new System.Drawing.Size(236, 50);
            this.mtxtUserName.TabIndex = 4;
            this.mtxtUserName.Text = "";
            this.mtxtUserName.TrailingIcon = null;
            // 
            // mtxtPassword
            // 
            this.mtxtPassword.AnimateReadOnly = false;
            this.mtxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtPassword.Depth = 0;
            this.mtxtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtPassword.LeadingIcon = null;
            this.mtxtPassword.Location = new System.Drawing.Point(184, 201);
            this.mtxtPassword.MaxLength = 50;
            this.mtxtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtPassword.Multiline = false;
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.Password = true;
            this.mtxtPassword.Size = new System.Drawing.Size(236, 50);
            this.mtxtPassword.TabIndex = 5;
            this.mtxtPassword.Text = "";
            this.mtxtPassword.TrailingIcon = null;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(466, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 470);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(97, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "User Your User Id and Password to Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 313);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to LogIn";
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1360, 830);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogIn;
        private MaterialSkin.Controls.MaterialTextBox mtxtUserName;
        private MaterialSkin.Controls.MaterialTextBox mtxtPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

