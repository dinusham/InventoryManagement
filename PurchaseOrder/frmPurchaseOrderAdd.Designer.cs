using System;

namespace PurchaseOrder
{
    partial class frmPurchaseOrderAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPname = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.radioBtnCash = new System.Windows.Forms.RadioButton();
            this.radioBtnOther = new System.Windows.Forms.RadioButton();
            this.radioBtnInstalment = new System.Windows.Forms.RadioButton();
            this.radioBtnCredit = new System.Windows.Forms.RadioButton();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.radioBtnFinish = new System.Windows.Forms.RadioButton();
            this.radioBtnAvailable = new System.Windows.Forms.RadioButton();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.datePaid = new System.Windows.Forms.DateTimePicker();
            this.lblPaidDate = new System.Windows.Forms.Label();
            this.grpPayType = new System.Windows.Forms.GroupBox();
            this.grpStockStatus = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPayType.SuspendLayout();
            this.grpStockStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPaid
            // 
            this.chkPaid.AutoSize = true;
            this.chkPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkPaid.Location = new System.Drawing.Point(243, 390);
            this.chkPaid.Margin = new System.Windows.Forms.Padding(4);
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.Size = new System.Drawing.Size(82, 24);
            this.chkPaid.TabIndex = 28;
            this.chkPaid.Text = "Is Paid";
            this.chkPaid.UseVisualStyleBackColor = true;
            this.chkPaid.CheckedChanged += new System.EventHandler(this.chkPaid_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(480, 486);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 39);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(243, 190);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(345, 22);
            this.txtDiscount.TabIndex = 26;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDiscount.Location = new System.Drawing.Point(43, 192);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(76, 20);
            this.lblDiscount.TabIndex = 25;
            this.lblDiscount.Text = "Discount";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(243, 138);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(345, 22);
            this.txtPrice.TabIndex = 24;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrice.Location = new System.Drawing.Point(43, 140);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(243, 86);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(345, 22);
            this.txtDescription.TabIndex = 22;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPname.Location = new System.Drawing.Point(43, 88);
            this.lblPname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(95, 20);
            this.lblPname.TabIndex = 21;
            this.lblPname.Text = "Description";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(243, 41);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(345, 24);
            this.cmbSupplier.TabIndex = 20;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSupplier.Location = new System.Drawing.Point(43, 45);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(70, 20);
            this.lblSupplier.TabIndex = 19;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.Location = new System.Drawing.Point(43, 301);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(78, 20);
            this.lblType.TabIndex = 29;
            this.lblType.Text = "Pay Type";
            // 
            // radioBtnCash
            // 
            this.radioBtnCash.AutoSize = true;
            this.radioBtnCash.Checked = true;
            this.radioBtnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnCash.Location = new System.Drawing.Point(16, 12);
            this.radioBtnCash.Name = "radioBtnCash";
            this.radioBtnCash.Size = new System.Drawing.Size(69, 24);
            this.radioBtnCash.TabIndex = 30;
            this.radioBtnCash.TabStop = true;
            this.radioBtnCash.Text = "Cash";
            this.radioBtnCash.UseVisualStyleBackColor = true;
            // 
            // radioBtnOther
            // 
            this.radioBtnOther.AutoSize = true;
            this.radioBtnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnOther.Location = new System.Drawing.Point(316, 14);
            this.radioBtnOther.Name = "radioBtnOther";
            this.radioBtnOther.Size = new System.Drawing.Size(72, 24);
            this.radioBtnOther.TabIndex = 31;
            this.radioBtnOther.Text = "Other";
            this.radioBtnOther.UseVisualStyleBackColor = true;
            // 
            // radioBtnInstalment
            // 
            this.radioBtnInstalment.AutoSize = true;
            this.radioBtnInstalment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnInstalment.Location = new System.Drawing.Point(193, 14);
            this.radioBtnInstalment.Name = "radioBtnInstalment";
            this.radioBtnInstalment.Size = new System.Drawing.Size(107, 24);
            this.radioBtnInstalment.TabIndex = 32;
            this.radioBtnInstalment.Text = "Instalment";
            this.radioBtnInstalment.UseVisualStyleBackColor = true;
            // 
            // radioBtnCredit
            // 
            this.radioBtnCredit.AutoSize = true;
            this.radioBtnCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnCredit.Location = new System.Drawing.Point(101, 14);
            this.radioBtnCredit.Name = "radioBtnCredit";
            this.radioBtnCredit.Size = new System.Drawing.Size(75, 24);
            this.radioBtnCredit.TabIndex = 33;
            this.radioBtnCredit.Text = "Credit";
            this.radioBtnCredit.UseVisualStyleBackColor = true;
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStockStatus.Location = new System.Drawing.Point(43, 344);
            this.lblStockStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(104, 20);
            this.lblStockStatus.TabIndex = 34;
            this.lblStockStatus.Text = "Stock Status";
            // 
            // radioBtnFinish
            // 
            this.radioBtnFinish.AutoSize = true;
            this.radioBtnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnFinish.Location = new System.Drawing.Point(122, 13);
            this.radioBtnFinish.Name = "radioBtnFinish";
            this.radioBtnFinish.Size = new System.Drawing.Size(75, 24);
            this.radioBtnFinish.TabIndex = 36;
            this.radioBtnFinish.TabStop = true;
            this.radioBtnFinish.Text = "Finish";
            this.radioBtnFinish.UseVisualStyleBackColor = true;
            // 
            // radioBtnAvailable
            // 
            this.radioBtnAvailable.AutoSize = true;
            this.radioBtnAvailable.Checked = true;
            this.radioBtnAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnAvailable.Location = new System.Drawing.Point(16, 11);
            this.radioBtnAvailable.Name = "radioBtnAvailable";
            this.radioBtnAvailable.Size = new System.Drawing.Size(97, 24);
            this.radioBtnAvailable.TabIndex = 35;
            this.radioBtnAvailable.TabStop = true;
            this.radioBtnAvailable.Text = "Available";
            this.radioBtnAvailable.UseVisualStyleBackColor = true;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrderDate.Location = new System.Drawing.Point(43, 242);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(93, 20);
            this.lblOrderDate.TabIndex = 37;
            this.lblOrderDate.Text = "Order Date";
            // 
            // dateOrder
            // 
            this.dateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOrder.Location = new System.Drawing.Point(243, 240);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateOrder.Size = new System.Drawing.Size(120, 26);
            this.dateOrder.TabIndex = 38;
            this.dateOrder.Value = new System.DateTime(2020, 2, 16, 0, 0, 0, 0);
            // 
            // datePaid
            // 
            this.datePaid.CustomFormat = " ";
            this.datePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePaid.Location = new System.Drawing.Point(243, 430);
            this.datePaid.Name = "datePaid";
            this.datePaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePaid.Size = new System.Drawing.Size(120, 26);
            this.datePaid.TabIndex = 40;
            this.datePaid.Value = new System.DateTime(2020, 2, 15, 22, 15, 20, 0);
            this.datePaid.ValueChanged += new System.EventHandler(this.datePaid_ValueChanged);
            // 
            // lblPaidDate
            // 
            this.lblPaidDate.AutoSize = true;
            this.lblPaidDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaidDate.Location = new System.Drawing.Point(43, 436);
            this.lblPaidDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaidDate.Name = "lblPaidDate";
            this.lblPaidDate.Size = new System.Drawing.Size(83, 20);
            this.lblPaidDate.TabIndex = 39;
            this.lblPaidDate.Text = "Paid Date";
            // 
            // grpPayType
            // 
            this.grpPayType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpPayType.Controls.Add(this.radioBtnInstalment);
            this.grpPayType.Controls.Add(this.radioBtnCash);
            this.grpPayType.Controls.Add(this.radioBtnOther);
            this.grpPayType.Controls.Add(this.radioBtnCredit);
            this.grpPayType.Location = new System.Drawing.Point(227, 285);
            this.grpPayType.Name = "grpPayType";
            this.grpPayType.Size = new System.Drawing.Size(408, 42);
            this.grpPayType.TabIndex = 41;
            this.grpPayType.TabStop = false;
            // 
            // grpStockStatus
            // 
            this.grpStockStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpStockStatus.Controls.Add(this.radioBtnFinish);
            this.grpStockStatus.Controls.Add(this.radioBtnAvailable);
            this.grpStockStatus.Location = new System.Drawing.Point(227, 329);
            this.grpStockStatus.Name = "grpStockStatus";
            this.grpStockStatus.Size = new System.Drawing.Size(200, 49);
            this.grpStockStatus.TabIndex = 42;
            this.grpStockStatus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(591, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "%";
            // 
            // frmPurchaseOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(647, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpStockStatus);
            this.Controls.Add(this.grpPayType);
            this.Controls.Add(this.datePaid);
            this.Controls.Add(this.lblPaidDate);
            this.Controls.Add(this.dateOrder);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblStockStatus);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.chkPaid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPurchaseOrderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPurchaseOrderAdd";
            this.Closed += new System.EventHandler(this.frmPurchaseOrderAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmPurchaseOrderAdd_Load);
            this.grpPayType.ResumeLayout(false);
            this.grpPayType.PerformLayout();
            this.grpStockStatus.ResumeLayout(false);
            this.grpStockStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPaid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton radioBtnCash;
        private System.Windows.Forms.RadioButton radioBtnOther;
        private System.Windows.Forms.RadioButton radioBtnInstalment;
        private System.Windows.Forms.RadioButton radioBtnCredit;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.RadioButton radioBtnFinish;
        private System.Windows.Forms.RadioButton radioBtnAvailable;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.DateTimePicker datePaid;
        private System.Windows.Forms.Label lblPaidDate;
        private System.Windows.Forms.GroupBox grpPayType;
        private System.Windows.Forms.GroupBox grpStockStatus;
        private System.Windows.Forms.Label label1;
    }
}