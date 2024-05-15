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
    public partial class UserControlSell : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlSell()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGidView();
        }

        public void PopulateGidView(string sql = "select * from Bills;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSells.AutoGenerateColumns = false;
            this.dgvSells.DataSource = ds.Tables[0];
        }

        private void txtSearchBySeller_TextChanged(object sender, EventArgs e)
        {
            var sql = "select *  from Bills where Seller like '" + this.txtSearchBySeller.Text + "%';";
            this.PopulateGidView(sql);
        }
    }
}
