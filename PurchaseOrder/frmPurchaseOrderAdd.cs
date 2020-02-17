using InventoryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static PurchaseOrder.PurchaseOrderInfo;

namespace PurchaseOrder
{
    public partial class frmPurchaseOrderAdd : Form
    {
        private Form frmPurchaseOrder;
        private int orderId;
        private int userId;
        private PurchaseOrderDTO purchaseOrder;
        private IDictionary<int, string> keyValues;
        private List<int> supplierIds = new List<int>();

        public frmPurchaseOrderAdd(Form frmPurchaseOrder, int userId)
        {
            this.frmPurchaseOrder = frmPurchaseOrder;
            this.userId = userId;
            InitializeComponent();
        }

        public frmPurchaseOrderAdd(Form frmPurchaseOrder, int userId, int orderId)
        {
            this.frmPurchaseOrder = frmPurchaseOrder;
            this.userId = userId;
            this.orderId = orderId;
            InitializeComponent();

            keyValues = SupplierDataAccess.GetSuppliersForOrder();
            if (keyValues != null && cmbSupplier.Items.Count < 1)
            {
                foreach (var item in keyValues)
                {
                    cmbSupplier.Items.Add(item.Value);
                    supplierIds.Add(item.Key);
                }
            }

            ViewOrderInfo();
        }

        private void ViewOrderInfo()
        {
            purchaseOrder = PurchaseOrderDataAccess.GetOrderById(orderId);
            if (purchaseOrder != null)
            {
                cmbSupplier.Text = keyValues[purchaseOrder.Supplier].ToString();
                txtDescription.Text = purchaseOrder.Description;
                txtPrice.Text = string.Format("{0: 0.00}", purchaseOrder.Price);
                txtDiscount.Text = string.Format("{0: 0.00}", purchaseOrder.Discount * 100);
                dateOrder.Value = purchaseOrder.OrderDate;
                chkPaid.Checked = purchaseOrder.IsPaid;

                if (chkPaid.Checked && purchaseOrder.PaidDate != null)
                {
                    datePaid.Value = purchaseOrder.PaidDate.Value;
                }
                else
                {
                    datePaid.Format = DateTimePickerFormat.Custom;
                    datePaid.CustomFormat = " ";
                }
                setPayType(purchaseOrder.PayType);
                setStockStatus(purchaseOrder.StockStatus);
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
            var payType = (StockStatus)type;
            switch (payType)
            {
                case StockStatus.Available:
                    radioBtnAvailable.Checked = true;
                    break;
                case StockStatus.Finish:
                    radioBtnFinish.Checked = true;
                    break;
            }
        }

        private void frmPurchaseOrderAdd_Load(object sender, EventArgs e)
        {
            keyValues = SupplierDataAccess.GetSuppliersForOrder();
            if (keyValues != null && cmbSupplier.Items.Count < 1)
            {
                foreach (var item in keyValues)
                {
                    cmbSupplier.Items.Add(item.Value);
                    supplierIds.Add(item.Key);
                }
            }

            if (chkPaid.Checked)
                datePaid.Enabled = true;
            else
            {
                datePaid.Enabled = false;
                datePaid.Format = DateTimePickerFormat.Custom;
                datePaid.CustomFormat = " ";
            }
            if (orderId > 0)
                btnAdd.Text = "Update";
        }
        
        private void datePaid_ValueChanged(object sender, EventArgs e)
        {
            datePaid.CustomFormat = "yyyy-MM-dd";
        }

        private void chkPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaid.Checked)
                datePaid.Enabled = true;
            else
            {
                datePaid.Enabled = false;
                datePaid.Format = DateTimePickerFormat.Custom;
                datePaid.CustomFormat = " ";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtDiscount.Text) ||
                string.IsNullOrEmpty(dateOrder.Text) || (radioBtnCash.Checked == false && radioBtnCredit.Checked == false &&
                radioBtnInstalment.Checked == false && radioBtnOther.Checked == false) || (radioBtnAvailable.Checked = false &&
                radioBtnFinish.Checked == false))
            {
                MessageBox.Show("Values cannot be null");
                return;
            }
            int status = AddUpdateOrder();
            if (status > 0)
            {
                if (purchaseOrder != null && purchaseOrder.Id > 0)
                    MessageBox.Show("Successfully updated");
                else
                    MessageBox.Show("Successfully added");
                txtDescription.Text = "";
                txtDiscount.Text = "";
                txtPrice.Text = "0.00";
                cmbSupplier.SelectedIndex = -1;
                datePaid.Format = DateTimePickerFormat.Custom;
                datePaid.CustomFormat = " ";
                dateOrder.Value = DateTime.Now;
                chkPaid.Checked = false;
                radioBtnAvailable.Enabled = true;
                radioBtnCash.Enabled = true;
            }
            else
                MessageBox.Show("Order didn't add or update");
        }

        private int AddUpdateOrder()
        {
            var checkedStatus = grpStockStatus.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            int stockStatus = 1;
            if (checkedStatus != null)
                stockStatus = (int)(StockStatus)Enum.Parse(typeof(StockStatus), checkedStatus.Text);

            var checkedPayType = grpPayType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            int payType = (int)(PayType)Enum.Parse(typeof(PayType), checkedPayType.Text);

            if (purchaseOrder != null && purchaseOrder.Id > 0)
            {
                purchaseOrder.Id = orderId;
                purchaseOrder.Supplier = cmbSupplier.SelectedIndex+1;
                purchaseOrder.Description = txtDescription.Text;
                purchaseOrder.Price = Convert.ToDecimal(txtPrice.Text);
                purchaseOrder.Discount = Convert.ToDecimal(txtDiscount.Text);
                purchaseOrder.OrderDate = dateOrder.Value;
                purchaseOrder.IsPaid = chkPaid.Checked;
                purchaseOrder.PaidDate = datePaid.Value;
                purchaseOrder.UpdatedBy = userId;
                purchaseOrder.PayType = payType;
                purchaseOrder.StockStatus = stockStatus;

                return PurchaseOrderDataAccess.UpdateOrder(purchaseOrder);
            }
            else
            {
                var purchaseOrder = new PurchaseOrderDTO()
                {
                    Description = txtDescription.Text,
                    Supplier = cmbSupplier.SelectedIndex+1,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    Discount = Convert.ToDecimal(txtDiscount.Text),
                    OrderDate = dateOrder.Value,
                    IsPaid = chkPaid.Checked,
                    PaidDate = datePaid.Value,
                    PayType = payType,
                    StockStatus = stockStatus,
                    CreatedBy = userId
                };
                return PurchaseOrderDataAccess.AddOrder(purchaseOrder);
            }
        }

        private void frmPurchaseOrderAdd_FormClosing(object sender, EventArgs e)
        {
            var parent = (frmPurchaseOrders)frmPurchaseOrder;
            parent.frmPurchaseOrders_Load(sender, e);
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
    }
}
