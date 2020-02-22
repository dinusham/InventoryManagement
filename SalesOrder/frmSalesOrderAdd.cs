﻿using InventoryDataAccess;
using System;
using System.Collections.Generic;
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
                dateSalesOrder.Value = salesOrder.Date.Date;
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
                    radioBtnAvailable.Checked = true;
                    break;
                case SalesStatus.Delivered:
                    radioBtnFinish.Checked = true;
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
