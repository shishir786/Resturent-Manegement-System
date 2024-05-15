using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MaterialSkin;
using MaterialSkin.Controls;
using WFADBG;

namespace ResturentBillingSystem
{
    public partial class FormLogIn : MaterialForm
    {
        private DataAccess Da { get; set; }

        public FormLogIn()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private bool IsValid()
        {
            if (String.IsNullOrEmpty(this.mtxtUserName.Text) || String.IsNullOrEmpty(this.mtxtPassword.Text))
                return false;
            else
                return true;
        }


        private void btnLogIn_Click_1(object sender, EventArgs e)
        {

            if (!this.IsValid())
            {
                MessageBox.Show("Please Give User Name and Password Both");
                return;
            }
            string query = "select * from Employee e,  Roles r where e.RoleID=r.RoleID and UserName='" + this.mtxtUserName.Text + "'and Password = '" + this.mtxtPassword.Text + "'";
            var dx = this.Da.ExecuteQuery(query);
            if (dx.Tables[0].Rows.Count == 1)
            {
                var name = dx.Tables[0].Rows[0][3].ToString();
                var role = dx.Tables[0].Rows[0][6].ToString();
                MessageBox.Show("User Name and Password matched \nValid User: " + name);
                if (role == "Manager")
                {
                    this.Hide();
                    new FormManager(name, this).Show();

                }
                else if (role == "Seller")
                {
                    this.Hide();
                    new FormSeller(name, this).ShowDialog();
                }
            }

            else
                MessageBox.Show("User Name and Password doesnot match \n Invalied User");
        }
    }
}
