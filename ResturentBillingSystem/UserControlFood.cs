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
    public partial class UserControlFood : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlFood()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGidView();
        }

        public void PopulateGidView(string sql = "select * from FoodItem;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgbFood.AutoGenerateColumns = false;
            this.dgbFood.DataSource = ds.Tables[0];
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.mtxtFoodName.Text) || String.IsNullOrEmpty(this.mtxtPrice.Text)
            )
                return false;
            else
                return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string query = null;
                var sql = "select * from FoodItem where FoodID = '" + this.mtxFoodID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    // update Database
                    query = @"update Fooditem
                            set FoodName = '" + this.mtxtFoodName.Text + @"',
                            Price = '" + this.mtxtPrice.Text + @"'
                            where FoodID = '" + this.mtxFoodID.Text + "'; ";
           

                    var count = this.Da.ExecuteDMLQuery(query);


                    if (count == 1)
                        MessageBox.Show("Food Item data has been updated properly");
                    else
                        MessageBox.Show("Food Item data upgradation failed");
                }
                else
                {
                    // insert Database
                    query = "insert into FoodItem(FoodName,Price) values('" + this.mtxtFoodName.Text + "', '" + this.mtxtPrice.Text + "' );";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Food Item data has been added properly");
                    else
                        MessageBox.Show("Food Item data saving failed");
                }

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void dgbFood_DoubleClick(object sender, EventArgs e)
        {
            this.mtxFoodID.Text = dgbFood.CurrentRow.Cells["FoodID"].Value.ToString();
            this.mtxtFoodName.Text = dgbFood.CurrentRow.Cells["FoodName"].Value.ToString();
            this.mtxtPrice.Text = dgbFood.CurrentRow.Cells["Price"].Value.ToString();
        }

        private void ClearAll()
        {
            this.mtxFoodID.Clear();
            this.mtxtFoodName.Clear();
            this.mtxtPrice.Clear();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }


        // delete operation
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgbFood.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgbFood.CurrentRow.Cells[0].Value.ToString();;
                var title = this.dgbFood.CurrentRow.Cells["FoodName"].Value.ToString();
                var query = "delete from FoodItem where FoodID = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(" Food Item " + title + " has been removed from the list.");
                else
                    MessageBox.Show("Food Item data remove failed");

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            var sql = "select *  from FoodItem where FoodName like '" + this.txtSearchFood.Text + "%';";
            this.PopulateGidView(sql);
        }
    }
}
