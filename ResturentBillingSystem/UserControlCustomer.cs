using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFADBG;

namespace ResturentBillingSystem
{
    public partial class UserControlCustomer : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlCustomer()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGidView();
        }

        public void PopulateGidView(string sql = "select * from Customer;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.DataSource = ds.Tables[0];
        }

        private void txtSearchByCustomer_TextChanged(object sender, EventArgs e)
        {
            var sql = "select *  from Customer where CustomerName like '" + this.txtSearchByCustomer.Text + "%';";
            this.PopulateGidView(sql);
        }
    }
}
