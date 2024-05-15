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
    public partial class FormManager : MaterialForm
    {
        private FormLogIn Fl { get; set; }
        public FormManager()
        {
            InitializeComponent();
        }

        public FormManager(string text, FormLogIn fl) : this()
        {
            this.Fl = fl;
            this.lblUser.Text =text;
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            userControlEmp1.Hide();
            userControlFood1.Hide();
            userControlSell1.Hide();
            userControlCustomer1.Hide();
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            userControlEmp1.Show();
            userControlEmp1.BringToFront();

            this.pictureBox1.Hide();
            userControlFood1.Hide();
            userControlSell1.Hide();
            userControlCustomer1.Hide();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            userControlFood1.Show();
            userControlFood1.BringToFront();

            this.pictureBox1.Hide();
            userControlEmp1.Hide();
            userControlSell1.Hide();
            userControlCustomer1.Hide();
        }

        private void btnSells_Click(object sender, EventArgs e)
        {
            userControlSell1.Show();
            userControlSell1.BringToFront();

            this.pictureBox1.Hide();
            userControlEmp1.Hide();
            userControlFood1.Hide();
            userControlCustomer1.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            userControlCustomer1.Show();
            userControlCustomer1.BringToFront();

            this.pictureBox1.Hide();
            userControlEmp1.Hide();
            userControlFood1.Hide();
            userControlSell1.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Fl.Show();
            this.Close();
        }
    }
}
