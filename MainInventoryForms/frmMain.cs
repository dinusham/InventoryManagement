using AdminForms;
using CategoryForms;
using Brand;
using InventoryDataAccess;
using System;
using System.Windows.Forms;
using Product;
using Customer;
using Supplier;
using System.Drawing;
using System.Collections.Generic;
using PurchaseOrder;
using System.Linq;
using System.Data;
using SalesOrder;

namespace MainInventoryForms
{
    public partial class frmMain : Form
    {
        private AdminDTO adminDto;
        private List<ToolStripMenuItem> menuItems;
        private List<Panel> panels;

        public frmMain(AdminDTO adminDto)
        {
            this.adminDto = adminDto;
            InitializeComponent();

            menuItems = new List<ToolStripMenuItem>()
            {
                dashboardTool, usersTool, brandsTool, categoryTool, settingsTool, productTool, customersTool,
                suppliersTool, dashboardTool, purchaseOrderTool
            };
            panels = new List<Panel>()
            {
                panelUsers, panelBrand, panelCategory, panelSettings, panelProduct, panelCustomer,
                panelSupplier, panelPurchaseOrder
            };

            ManageComponents();
        }

        private void ManageComponents()
        {
            if (!adminDto.IsAdmin)
                usersTool.Visible = false;
            //else
            //    settingsTool.Visible = false;
        }

        private void usersTool_Click(object sender, EventArgs e)
        {
            ManagefrmView(usersTool, panelUsers);

            var frmAdminList = new frmAdminList(adminDto.Id);
            frmAdminList.TopLevel = false;
            frmAdminList.AutoScroll = true;
            frmAdminList.FormBorderStyle = FormBorderStyle.None;
            panelUsers.Controls.Add(frmAdminList);

            frmAdminList.Show();
        }

        private void settingsTool_Click(object sender, EventArgs e)
        {
            ManagefrmView(settingsTool, panelSettings);

            var frmSettings = new frmSettings(adminDto.Id, adminDto.UserName);
            frmSettings.TopLevel = false;
            frmSettings.AutoScroll = true;
            frmSettings.FormBorderStyle = FormBorderStyle.None;
            panelSettings.Controls.Add(frmSettings);

            frmSettings.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //panelUsers.Visible = false;
            //panelSettings.Visible = false;
            //panelMain.Visible = true;
            //label1.Visible = true;
            ManagefrmView(dashboardTool, null);
            ViewTypeSummary();
            ViewProductStockSummary();
            ViewPaymentSummary();
        }

        private void ViewPaymentSummary()
        {
            var paymentSummaryDto = DashboardSummaryDataAccess.GetPaymentSummary();
            if (paymentSummaryDto != null)
            {
                lblPay.Text = paymentSummaryDto.Pay;
                lblIncome.Text = paymentSummaryDto.Income;
            }
        }

        private void ViewProductStockSummary()
        {
            DataTable stockTable = DashboardSummaryDataAccess.GetProductStockSummary();
            if (stockTable != null && stockTable.Rows.Count > 0)
            {
                this.stockSummaryGridView.DataSource = stockTable;
                FormatGrid(ref this.stockSummaryGridView);
            }
            else
            {
                lblstockSummaryNull.Text = "Nothing to view";
            }
        }

        private void FormatGrid(ref DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                string colunmName = dataGridView.Columns[i].Name;
                switch (colunmName)
                {
                    case "product_id":
                        dataGridView.Columns[i].Width = 82;
                        dataGridView.Columns[i].HeaderText = "Product Id";
                        dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        break;
                    case "product":
                        dataGridView.Columns[i].Width = 182;
                        dataGridView.Columns[i].HeaderText = "Product";
                        dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        break;
                    case "purchase_item":
                        dataGridView.Columns[i].Width = 80;
                        dataGridView.Columns[i].HeaderText = "Purchase Item";
                        dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        break;
                    case "sale_item":
                        dataGridView.Columns[i].HeaderText = "Sale Item";
                        dataGridView.Columns[i].Width = 80;
                        dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        break;
                    case "available_item":
                        dataGridView.Columns[i].HeaderText = "Available Item";
                        dataGridView.Columns[i].Width = 80;
                        dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        break;
                    default:
                        break;
                }
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = 30;
                if (row.Index % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void ViewTypeSummary()
        {
            var summaryDtos = DashboardSummaryDataAccess.GetDashboardSummaryList();
            if (summaryDtos != null && summaryDtos.Any())
            {
                foreach (var summaryDto in summaryDtos)
                {
                    string type = summaryDto.Type;
                    switch (type)
                    {
                        case "Brand":
                            lblBrandA.Text = summaryDto.ActiveCount.ToString();
                            lblBrandInA.Text = summaryDto.InActiveCount.ToString();
                            break;
                        case "Category":
                            lblCaA.Text = summaryDto.ActiveCount.ToString();
                            lblCaInA.Text = summaryDto.InActiveCount.ToString();
                            break;
                        case "Customer":
                            lblCuA.Text = summaryDto.ActiveCount.ToString();
                            lblCuInA.Text = summaryDto.InActiveCount.ToString();
                            break;
                        case "Supplier":
                            lblSA.Text = summaryDto.ActiveCount.ToString();
                            lblSInA.Text = summaryDto.InActiveCount.ToString();
                            break;
                        case "Product":
                            lblPA.Text = summaryDto.ActiveCount.ToString();
                            lblPInA.Text = summaryDto.InActiveCount.ToString();
                            break;
                    }
                }
            }
        }

        private void categoryTool_Click(object sender, EventArgs e)
        {
            ManagefrmView(categoryTool, panelCategory);

            var frmCategory = new frmCategory(adminDto.Id);
            frmCategory.TopLevel = false;
            frmCategory.AutoScroll = true;
            frmCategory.FormBorderStyle = FormBorderStyle.None;
            panelCategory.Controls.Add(frmCategory);

            frmCategory.Show();
        }

        private void brandsTool_Click(object sender, EventArgs e)
        {
            ManagefrmView(brandsTool, panelBrand);

            var frmBrand = new frmBrands(adminDto.Id);
            frmBrand.TopLevel = false;
            frmBrand.AutoScroll = true;
            frmBrand.FormBorderStyle = FormBorderStyle.None;
            panelBrand.Controls.Add(frmBrand);

            frmBrand.Show();
        }

        private void productTool_Click(object sender, EventArgs e)
        {
            ManagefrmView(productTool, panelProduct);

            var frmProduct = new frmProducts(adminDto.Id);
            frmProduct.TopLevel = false;
            frmProduct.AutoScroll = true;
            frmProduct.FormBorderStyle = FormBorderStyle.None;
            panelProduct.Controls.Add(frmProduct);

            frmProduct.Show();
        }

        private void customersTool_Click(object sender, EventArgs e)
        {
            ManagefrmView(customersTool, panelCustomer);

            var frmCustomers = new frmCustomers(adminDto.Id);
            frmCustomers.TopLevel = false;
            frmCustomers.AutoScroll = true;
            frmCustomers.FormBorderStyle = FormBorderStyle.None;
            panelCustomer.Controls.Add(frmCustomers);

            frmCustomers.Show();
        }

        private void suppliersTool_Click(object sender, EventArgs e)
        {
            ManagefrmView(suppliersTool, panelSupplier);

            var frmSuppliers = new frmSuppliers(adminDto.Id);
            frmSuppliers.TopLevel = false;
            frmSuppliers.AutoScroll = true;
            frmSuppliers.FormBorderStyle = FormBorderStyle.None;
            panelSupplier.Controls.Add(frmSuppliers);

            frmSuppliers.Show();
        }

        private void dashboardTool_Click(object sender, EventArgs e)
        {
            ManagefrmView(dashboardTool, null);
        }

        private void purchaseOrderTool_Click(object sender, EventArgs e)
        {
            ManagefrmView(purchaseOrderTool, panelPurchaseOrder);

            var frmPurchaseOrder = new frmPurchaseOrders(adminDto.Id);
            frmPurchaseOrder.TopLevel = false;
            frmPurchaseOrder.AutoScroll = true;
            frmPurchaseOrder.FormBorderStyle = FormBorderStyle.None;
            panelPurchaseOrder.Controls.Add(frmPurchaseOrder);

            frmPurchaseOrder.Show();
        }

        private void salesOrderTool_Click(object sender, EventArgs e)
        {
            ManagefrmView(salesOrderTool, panelSalesOrder);

            var frmSalesOrder = new frmSalesOrders(adminDto.Id);
            frmSalesOrder.TopLevel = false;
            frmSalesOrder.AutoScroll = true;
            frmSalesOrder.FormBorderStyle = FormBorderStyle.None;
            panelSalesOrder.Controls.Add(frmSalesOrder);

            frmSalesOrder.Show();
        }

        private void ManagefrmView(ToolStripMenuItem selectedMenuItem, Panel selectedPanel)
        {
            selectedMenuItem.BackColor = Color.RoyalBlue;

            foreach (var menuItem in menuItems)
            {
                if (menuItem != selectedMenuItem)
                    menuItem.BackColor = Color.FromArgb(10, 1, 67);
            }

            if (selectedPanel != null)
                selectedPanel.Visible = true;
            foreach (var panel in panels)
            {
                if (panel != selectedPanel)
                    panel.Visible = false;
            }
        }
    }
}
