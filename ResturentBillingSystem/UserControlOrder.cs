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
using static System.Net.Mime.MediaTypeNames;

namespace ResturentBillingSystem
{
    public partial class UserControlOrder : UserControl
    {
        double GrandPrice = 0;
        double priceTotal = 0;
        double price = 0;
        double quantity = 0;
        public string Seller = null;

        DateTime DateTime = DateTime.Now;


        private DataAccess Da { get; set; }
        public UserControlOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGidView();
        }

        public UserControlOrder(string text) : this() 
        {
            Seller = text;
        }

        public void PopulateGidView(string sql = "select *  from FoodItem ;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgbFood.AutoGenerateColumns = false;
            this.dgbFood.DataSource = ds.Tables[0];

        }

        private void dgbFood_DoubleClick(object sender, EventArgs e)
        {
            this.mtxtFoodID.Text = dgbFood.CurrentRow.Cells["FoodID"].Value.ToString();
            this.mtxtItemName.Text = dgbFood.CurrentRow.Cells["FoodName"].Value.ToString();
            this.mtxtPrice.Text = dgbFood.CurrentRow.Cells["Price"].Value.ToString();
            
        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.mtxtFoodID.Text) || String.IsNullOrEmpty(this.mtxtItemName.Text)
            || String.IsNullOrEmpty(this.mtxtPrice.Text) || String.IsNullOrEmpty(this.mcmbQuantity.Text))
                return false;
            else
                return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }
                var qt = this.mcmbQuantity.Text;
                quantity = Convert.ToDouble(qt);
                var pp = this.mtxtPrice.Text;
                price = Convert.ToDouble(pp);

                this.CalculatePrice(quantity, price);

                dgvCart.Rows.Add(this.mtxtItemName.Text, priceTotal);
                GrandPrice += priceTotal;
                lblTotalBill.Text = GrandPrice.ToString();
                this.clearAll();
            }

            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void CalculatePrice(double quantity, double price)
        {
            priceTotal = quantity * price;
        }


        private void clearAll()
        {
            this.mtxtFoodID.Clear();
            this.mtxtItemName.Clear();
            this.mtxtPrice.Clear();
            this.mcmbQuantity.SelectedIndex = -1;
            this.dgbFood.ClearSelection();
        }


        private bool IsValidToOrder()
        {
            if (String.IsNullOrEmpty(this.txtCustomerName.Text) || String.IsNullOrEmpty(this.cmbPaymentMathod.Text) )
                return false;
            else
                return true;
        }
        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToOrder())
                {
                    MessageBox.Show("Please Give Customer Name and Select Payment Mathod");
                    return;
                }
                var query1 = "insert into Bills values(" + this.lblTotalBill.Text + ",'" + Seller + "', '" + this.cmbPaymentMathod.Text + "','" + DateTime + "');";
                var query2 = "insert into Customer values('" + this.txtCustomerName.Text + "'," + this.lblTotalBill.Text + ", '" + this.cmbPaymentMathod.Text + "','" + DateTime + "');";
                
                var count = this.Da.ExecuteDMLQuery(query1);
                this.Da.ExecuteDMLQuery(query2);

                if (count == 1)
                {
                    MessageBox.Show("Order Completed \nCustomer Name :" + this.txtCustomerName.Text + "\nTotal Amount :" + this.lblTotalBill.Text + "\nPayment Mathod: " + this.cmbPaymentMathod.Text + "\nPurchase :"+ DateTime + " ");
                    GrandPrice = 0;
                    this.lblTotalBill.Text = " ";
                    this.dgvCart.Rows.Clear();
                    this.cmbPaymentMathod.SelectedIndex = -1;
                }
                else
                    MessageBox.Show("Order failed");


            }

            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            var sql = "select *  from FoodItem where FoodName like '%" + this.txtSearchFood.Text + "%';";
            this.PopulateGidView(sql);
        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            var sql = "select *  from FoodItem where FoodName like '" + this.txtSearchFood.Text + "%';";
            this.PopulateGidView(sql);
        }


    }

}
