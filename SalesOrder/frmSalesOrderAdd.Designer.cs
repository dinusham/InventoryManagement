namespace SalesOrder
{
    partial class frmSalesOrderAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpStockStatus = new System.Windows.Forms.GroupBox();
            this.radioBtnFinish = new System.Windows.Forms.RadioButton();
            this.radioBtnAvailable = new System.Windows.Forms.RadioButton();
            this.grpPayType = new System.Windows.Forms.GroupBox();
            this.radioBtnInstalment = new System.Windows.Forms.RadioButton();
            this.radioBtnCash = new System.Windows.Forms.RadioButton();
            this.radioBtnOther = new System.Windows.Forms.RadioButton();
            this.radioBtnCredit = new System.Windows.Forms.RadioButton();
            this.datePaid = new System.Windows.Forms.DateTimePicker();
            this.lblPaidDate = new System.Windows.Forms.Label();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPname = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.grpStockStatus.SuspendLayout();
            this.grpPayType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(586, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "%";
            // 
            // grpStockStatus
            // 
            this.grpStockStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpStockStatus.Controls.Add(this.radioBtnFinish);
            this.grpStockStatus.Controls.Add(this.radioBtnAvailable);
            this.grpStockStatus.Location = new System.Drawing.Point(222, 331);
            this.grpStockStatus.Name = "grpStockStatus";
            this.grpStockStatus.Size = new System.Drawing.Size(251, 49);
            this.grpStockStatus.TabIndex = 61;
            this.grpStockStatus.TabStop = false;
            // 
            // radioBtnFinish
            // 
            this.radioBtnFinish.AutoSize = true;
            this.radioBtnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnFinish.Location = new System.Drawing.Point(122, 13);
            this.radioBtnFinish.Name = "radioBtnFinish";
            this.radioBtnFinish.Size = new System.Drawing.Size(101, 24);
            this.radioBtnFinish.TabIndex = 36;
            this.radioBtnFinish.TabStop = true;
            this.radioBtnFinish.Text = "Delivered";
            this.radioBtnFinish.UseVisualStyleBackColor = true;
            // 
            // radioBtnAvailable
            // 
            this.radioBtnAvailable.AutoSize = true;
            this.radioBtnAvailable.Checked = true;
            this.radioBtnAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnAvailable.Location = new System.Drawing.Point(16, 11);
            this.radioBtnAvailable.Name = "radioBtnAvailable";
            this.radioBtnAvailable.Size = new System.Drawing.Size(90, 24);
            this.radioBtnAvailable.TabIndex = 35;
            this.radioBtnAvailable.TabStop = true;
            this.radioBtnAvailable.Text = "Pending";
            this.radioBtnAvailable.UseVisualStyleBackColor = true;
            // 
            // grpPayType
            // 
            this.grpPayType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpPayType.Controls.Add(this.radioBtnInstalment);
            this.grpPayType.Controls.Add(this.radioBtnCash);
            this.grpPayType.Controls.Add(this.radioBtnOther);
            this.grpPayType.Controls.Add(this.radioBtnCredit);
            this.grpPayType.Location = new System.Drawing.Point(222, 287);
            this.grpPayType.Name = "grpPayType";
            this.grpPayType.Size = new System.Drawing.Size(408, 42);
            this.grpPayType.TabIndex = 60;
            this.grpPayType.TabStop = false;
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
            // datePaid
            // 
            this.datePaid.CustomFormat = " ";
            this.datePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePaid.Location = new System.Drawing.Point(238, 432);
            this.datePaid.Name = "datePaid";
            this.datePaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePaid.Size = new System.Drawing.Size(120, 26);
            this.datePaid.TabIndex = 59;
            this.datePaid.Value = new System.DateTime(2020, 2, 15, 22, 15, 20, 0);
            // 
            // lblPaidDate
            // 
            this.lblPaidDate.AutoSize = true;
            this.lblPaidDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaidDate.Location = new System.Drawing.Point(38, 438);
            this.lblPaidDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaidDate.Name = "lblPaidDate";
            this.lblPaidDate.Size = new System.Drawing.Size(83, 20);
            this.lblPaidDate.TabIndex = 58;
            this.lblPaidDate.Text = "Paid Date";
            // 
            // dateOrder
            // 
            this.dateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOrder.Location = new System.Drawing.Point(238, 242);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateOrder.Size = new System.Drawing.Size(120, 26);
            this.dateOrder.TabIndex = 57;
            this.dateOrder.Value = new System.DateTime(2020, 2, 16, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(38, 244);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 20);
            this.lblDate.TabIndex = 56;
            this.lblDate.Text = "Date";
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStockStatus.Location = new System.Drawing.Point(38, 346);
            this.lblStockStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(104, 20);
            this.lblStockStatus.TabIndex = 55;
            this.lblStockStatus.Text = "Sales Status";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.Location = new System.Drawing.Point(38, 303);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(78, 20);
            this.lblType.TabIndex = 54;
            this.lblType.Text = "Pay Type";
            // 
            // chkPaid
            // 
            this.chkPaid.AutoSize = true;
            this.chkPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkPaid.Location = new System.Drawing.Point(238, 392);
            this.chkPaid.Margin = new System.Windows.Forms.Padding(4);
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.Size = new System.Drawing.Size(82, 24);
            this.chkPaid.TabIndex = 53;
            this.chkPaid.Text = "Is Paid";
            this.chkPaid.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(475, 488);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 39);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(238, 192);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(345, 22);
            this.txtDiscount.TabIndex = 51;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDiscount.Location = new System.Drawing.Point(38, 194);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(76, 20);
            this.lblDiscount.TabIndex = 50;
            this.lblDiscount.Text = "Discount";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(238, 140);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(345, 22);
            this.txtPrice.TabIndex = 49;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrice.Location = new System.Drawing.Point(38, 142);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 48;
            this.lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(238, 88);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(345, 22);
            this.txtDescription.TabIndex = 47;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPname.Location = new System.Drawing.Point(38, 90);
            this.lblPname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(95, 20);
            this.lblPname.TabIndex = 46;
            this.lblPname.Text = "Description";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(238, 43);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(345, 24);
            this.cmbCustomer.TabIndex = 45;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomer.Location = new System.Drawing.Point(38, 47);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 20);
            this.lblCustomer.TabIndex = 44;
            this.lblCustomer.Text = "Customer";
            // 
            // frmSalesOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(646, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpStockStatus);
            this.Controls.Add(this.grpPayType);
            this.Controls.Add(this.datePaid);
            this.Controls.Add(this.lblPaidDate);
            this.Controls.Add(this.dateOrder);
            this.Controls.Add(this.lblDate);
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
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmSalesOrderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalesOrderAdd";
            this.Load += new System.EventHandler(this.frmSalesOrderAdd_Load);
            this.Closed += new System.EventHandler(this.frmPurchaseOrderAdd_FormClosing);
            this.grpStockStatus.ResumeLayout(false);
            this.grpStockStatus.PerformLayout();
            this.grpPayType.ResumeLayout(false);
            this.grpPayType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpStockStatus;
        private System.Windows.Forms.RadioButton radioBtnFinish;
        private System.Windows.Forms.RadioButton radioBtnAvailable;
        private System.Windows.Forms.GroupBox grpPayType;
        private System.Windows.Forms.RadioButton radioBtnInstalment;
        private System.Windows.Forms.RadioButton radioBtnCash;
        private System.Windows.Forms.RadioButton radioBtnOther;
        private System.Windows.Forms.RadioButton radioBtnCredit;
        private System.Windows.Forms.DateTimePicker datePaid;
        private System.Windows.Forms.Label lblPaidDate;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.CheckBox chkPaid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCustomer;
    }
}