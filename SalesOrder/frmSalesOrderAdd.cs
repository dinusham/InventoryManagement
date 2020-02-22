using InventoryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Common.OrderInfo;
using static Common.SalesInfo;

namespace SalesOrder
{
    public partial class frmSalesOrderAdd : Form
    {
        private Form frmSalesOrder;
        private int orderId;
        private int userId;
        private SalesOrderDTO salesOrder;
        private IDictionary<int, string> keyValues;
        private List<int> customerIds = new List<int>();

        public frmSalesOrderAdd(Form frmSaleOrder, int userId)
        {
            this.frmSalesOrder = frmSaleOrder;
            this.userId = userId;
            InitializeComponent();
        }

        public frmSalesOrderAdd(Form frmSaleOrder, int userId, int orderId)
        {
            this.frmSalesOrder = frmSaleOrder;
            this.userId = userId;
            this.orderId = orderId;
            InitializeComponent();

            keyValues = CustomerDataAccess.GetCustomersForSalesOrder();
            if (keyValues != null && cmbCustomer.Items.Count < 1)
            {
                foreach (var item in keyValues)
                {
                    cmbCustomer.Items.Add(item.Value);
                    customerIds.Add(item.Key);
                }
            }

            ViewOrderInfo();
        }

        private void ViewOrderInfo()
        {
            salesOrder = SalesOrderDataAccess.GetSalesOrderById(orderId);
            if (salesOrder != null)
            {
                cmbCustomer.Text = keyValues[salesOrder.Customer].ToString();
                txtDescription.Text = salesOrder.Description;
                txtPrice.Text = string.Format("{0: 0.00}", salesOrder.Price).Trim();
                txtDiscount.Text = string.Format("{0: 0.00}", salesOrder.Discount * 100).Trim();
                dateSalesOrder.Value = salesOrder.SalesOrderDate.Date;
                chkPaid.Checked = salesOrder.IsPaid;

                if (chkPaid.Checked && salesOrder.PaidDate != null)
                {
                    datePaid.Value = salesOrder.PaidDate.Value;
                }
                else
                {
                    datePaid.Format = DateTimePickerFormat.Custom;
                    datePaid.CustomFormat = " ";
                }
                setPayType(salesOrder.PayType);
                setStockStatus(salesOrder.SalesStatus);
            }
        }

        private void setPayType(int type)
        {
            var payType = (PayType)type;
            switch (payType)
            {
                case PayType.Cash:
                    radioBtnCash.Checked = true;
                    break;
                case PayType.Credit:
                    radioBtnCredit.Checked = true;
                    break;
                case PayType.Instalment:
                    radioBtnInstalment.Checked = true;
                    break;
                case PayType.Other:
                    radioBtnOther.Checked = true;
                    break;
            }
        }

        private void setStockStatus(int type)
        {
            var payType = (SalesStatus)type;
            switch (payType)
            {
                case SalesStatus.Pending:
                    radioBtnPending.Checked = true;
                    break;
                case SalesStatus.Delivered:
                    radioBtnDelivered.Checked = true;
                    break;
            }
        }

        private void frmSalesOrderAdd_Load(object sender, System.EventArgs e)
        {
            keyValues = CustomerDataAccess.GetCustomersForSalesOrder();
            if (keyValues != null && cmbCustomer.Items.Count < 1)
            {
                foreach (var item in keyValues)
                {
                    cmbCustomer.Items.Add(item.Value);
                    customerIds.Add(item.Key);
                }
            }

            if (chkPaid.Checked)
                datePaid.Enabled = true;
            else
            {
                datePaid.Enabled = false;
                datePaid.Format = DateTimePickerFormat.Custom;
                datePaid.CustomFormat = "";
                datePaid.Value = DateTime.Now.Date;
            }
            if (orderId > 0)
                btnAdd.Text = "Update";
            else
                dateSalesOrder.Value = DateTime.Now.Date;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtDiscount.Text) ||
                string.IsNullOrEmpty(dateSalesOrder.Text) || (radioBtnCash.Checked == false && radioBtnCredit.Checked == false &&
                radioBtnInstalment.Checked == false && radioBtnOther.Checked == false) || (radioBtnPending.Checked = false &&
                radioBtnDelivered.Checked == false))
            {
                MessageBox.Show("Values cannot be null");
                return;
            }
            int status = AddUpdateOrder();
            if (status > 0)
            {
                if (salesOrder != null && salesOrder.Id > 0)
                    MessageBox.Show("Successfully updated");
                else
                    MessageBox.Show("Successfully added");
                txtDescription.Text = "";
                txtDiscount.Text = "";
                txtPrice.Text = "0.00";
                cmbCustomer.SelectedIndex = -1;
                datePaid.Format = DateTimePickerFormat.Custom;
                datePaid.CustomFormat = " ";
                dateSalesOrder.Value = DateTime.Now;
                chkPaid.Checked = false;
                radioBtnPending.Checked = true;
                radioBtnCash.Checked = true;
            }
            else
                MessageBox.Show("Order didn't add or update");
        }

        private int AddUpdateOrder()
        {
            var checkedSalesStatus = grpSalesStatus.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            int stockStatus = (int)(SalesStatus)Enum.Parse(typeof(SalesStatus), checkedSalesStatus.Text);

            var checkedPayType = grpPayType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            int payType = (int)(PayType)Enum.Parse(typeof(PayType), checkedPayType.Text);

            if (salesOrder != null && salesOrder.Id > 0)
            {
                salesOrder.Id = orderId;
                salesOrder.Customer = cmbCustomer.SelectedIndex + 1;
                salesOrder.Description = txtDescription.Text;
                salesOrder.Price = Convert.ToDecimal(txtPrice.Text);
                salesOrder.Discount = Convert.ToDecimal(txtDiscount.Text);
                salesOrder.SalesOrderDate = dateSalesOrder.Value;
                salesOrder.IsPaid = chkPaid.Checked;
                salesOrder.UpdatedBy = userId;
                salesOrder.PayType = payType;
                salesOrder.SalesStatus = stockStatus;

                if (chkPaid.Checked)
                    salesOrder.PaidDate = datePaid.Value;
                else
                    salesOrder.PaidDate = null;

                return SalesOrderDataAccess.UpdateSalesOrder(salesOrder);
            }
            else
            {
                var salesOrder = new SalesOrderDTO()
                {
                    Description = txtDescription.Text,
                    Customer = cmbCustomer.SelectedIndex + 1,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    Discount = Convert.ToDecimal(txtDiscount.Text),
                    SalesOrderDate = dateSalesOrder.Value,
                    IsPaid = chkPaid.Checked,
                    PayType = payType,
                    SalesStatus = stockStatus,
                    CreatedBy = userId
                };

                if (chkPaid.Checked)
                    salesOrder.PaidDate = datePaid.Value;
                else
                    salesOrder.PaidDate = null;

                return SalesOrderDataAccess.AddSalesOrder(salesOrder);
            }
        }

        private void frmPurchaseOrderAdd_FormClosing(object sender, EventArgs e)
        {
            var parent = (frmSalesOrders)frmSalesOrder;
            parent.frmSalesOrders_Load(sender, e);
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaid.Checked)
            {
                datePaid.Enabled = true;
                datePaid.Format = DateTimePickerFormat.Custom;
                datePaid.CustomFormat = "";
                datePaid.Value = DateTime.Now.Date;
            }
            else
            {
                datePaid.Enabled = true;
            }
        }
    }
}
