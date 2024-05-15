using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ResturentBillingSystem
{
    public partial class FormSeller : MaterialForm
    {
        public string Seller = null;
        private FormLogIn Fl { get; set; }
        public FormSeller()
        {
            InitializeComponent();
        }

        public FormSeller(string text, FormLogIn fl) : this()
        {
            this.Fl = fl;
            this.lblUser.Text = text;
            Seller = text;
        }

        

        private void FormSeller_Load(object sender, EventArgs e)
        {
            this.userControlFood1.Hide();
            this.userControlOrder1.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //this.userControlOrder1.Show();
            userControlOrder1 = new UserControlOrder(Seller);
            panel2.Controls.Add(userControlOrder1);
            //userControlOrder1.Show();
            this.userControlOrder1.BringToFront();

            this.userControlFood1.Hide();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            //this.userControlFood1.Show();

            userControlFood1 = new UserControlFood();
            panel2.Controls.Add(userControlFood1);
            this.userControlFood1.BringToFront();

            this.userControlOrder1.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fl.Show();
            this.Close();
        }
    }
}
