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
    public partial class UserControlEmp : UserControl
    {
        private DataAccess Da { get; set; }
        string NewRoleId = null;
        int OldRollID = 0;
        public UserControlEmp()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGidView();
            this.AutoIdGenerate();
            this.AutoRoleIdGenerate();
        }

        public void PopulateGidView(string sql = "select *  from Employee e,  Roles r where e.RoleID=r.RoleID ;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = ds.Tables[0];
        }


        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtUserName.Text)
            || String.IsNullOrEmpty(this.txtPassword.Text) || String.IsNullOrEmpty(this.txtEmpName.Text)
            || String.IsNullOrEmpty(this.cmbRoll.Text))
                return false;
            else
                return true;
        }





        private void ClearAll()
        {
            this.txtUserId.Clear();
            this.txtUserName.Clear();
            this.txtPassword.Clear();
            this.txtEmpName.Clear();
            this.cmbRoll.SelectedIndex = -1;
            this.txtSearch.Clear();
            this.dgvEmployee.ClearSelection();
            this.AutoIdGenerate();
            this.AutoRoleIdGenerate();
        }


        private void AutoRoleIdGenerate()
        {
            var sql = "select RoleID from Employee order by RoleID desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldRoleId = dt.Rows[0][0].ToString();
            int num = Convert.ToInt32(oldRoleId);
            OldRollID = num;
            string newRoleId = (++num).ToString();
            NewRoleId = newRoleId;

        }

        private void AutoIdGenerate()
        {
            var sql = "select UserId from Employee order by UserId desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "s-" + (++num).ToString("d3");
            this.txtUserId.Text = newId;
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserId.Text = dgvEmployee.CurrentRow.Cells["UserID"].Value.ToString();
            this.txtUserName.Text = dgvEmployee.CurrentRow.Cells["userName"].Value.ToString();
            this.txtPassword.Text = dgvEmployee.CurrentRow.Cells["Password"].Value.ToString();
            this.txtEmpName.Text = dgvEmployee.CurrentRow.Cells["EmpName"].Value.ToString();
            this.cmbRoll.Text = dgvEmployee.CurrentRow.Cells["Role"].Value.ToString();
        }


        // Save operation 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string query1 = null;
                string query2 = null;
                var sql = "select * from Employee where UserID = '" + this.txtUserId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    // update Database
                    query1 = @"update Employee
                            set UserName = '" + this.txtUserName.Text + @"',
                            Password = '" + this.txtPassword.Text + @"',
                            EmpName = '" + this.txtEmpName.Text + @"',
                            RoleID = " + OldRollID + @"
                            where UserID = '" + this.txtUserId.Text + "'; ";
                    query2 = @"update Roles
                            set Role = '" + this.cmbRoll.Text + @"'
                            where RoleID =" + OldRollID + ";";

                    var count = this.Da.ExecuteDMLQuery(query1);
                    this.Da.ExecuteDMLQuery(query2);

                    if (count == 1)
                        MessageBox.Show("Employee data has been updated properly");
                    else
                        MessageBox.Show("Employee data upgradation failed");
                }
                else
                {
                    // insert Database
                    query1 = "insert into Employee values('" + this.txtUserId.Text + "','" + this.txtUserName.Text + "', '" + this.txtPassword.Text + "', '" + this.txtEmpName.Text + "', '" + NewRoleId + "' );";
                    query2 = "insert into Roles  values('" + NewRoleId + "','" + this.cmbRoll.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query1);
                    this.Da.ExecuteDMLQuery(query2);

                    if (count == 1)
                        MessageBox.Show("Employee data has been added properly");
                    else
                        MessageBox.Show("Employee data saving failed");
                }

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        // clear operation
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.AutoIdGenerate();
            this.AutoRoleIdGenerate();
        }

        // delete operation
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmployee.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvEmployee.CurrentRow.Cells[0].Value.ToString();
                var rID = this.dgvEmployee.CurrentRow.Cells["RoleID"].Value.ToString();
                var title = this.dgvEmployee.CurrentRow.Cells["EmpName"].Value.ToString();
                var query1 = "delete from Employee where UserID = '" + id + "';";
                var query2 = "delete from Roles where RoleID = '" + rID + "';";
                var count = this.Da.ExecuteDMLQuery(query1);
                this.Da.ExecuteDMLQuery(query2);

                if (count == 1)
                    MessageBox.Show(" Employee"+ title + " has been removed from the list.");
                else
                    MessageBox.Show("Employee data remove failed");

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sql = "select *  from Employee e,  Roles r where e.RoleID=r.RoleID and EmpName like '%" + this.txtSearch.Text + "%';";
            this.PopulateGidView(sql);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select *  from Employee e,  Roles r where e.RoleID=r.RoleID and EmpName like '" + this.txtSearch.Text + "%';";
            this.PopulateGidView(sql);
        }
    }
}
