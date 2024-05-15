using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ResturentBillingSystem
{
    public partial class FormHome : MaterialForm
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }


        private void btnStart_Click_1(object sender, EventArgs e)
        {
            this.btnStart.Visible = false;
            this.panel3.Visible = true;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.panelProgress.Width += 30;

            if (this.panelProgress.Width >= this.panel2.Width)
            {
                timer1.Stop();
                this.Hide();
                new FormLogIn().Show();
            }
        }
    }
}
