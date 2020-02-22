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
            this.dateSalesOrder = new System.Windows.Forms.DateTimePicker();
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
            this.label1.Location = new System.Drawing.Point(440, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "%";
            // 
            // grpStockStatus
            // 
            this.grpStockStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpStockStatus.Controls.Add(this.radioBtnFinish);
            this.grpStockStatus.Controls.Add(this.radioBtnAvailable);
            this.grpStockStatus.Location = new System.Drawing.Point(166, 269);
            this.grpStockStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpStockStatus.Name = "grpStockStatus";
            this.grpStockStatus.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpStockStatus.Size = new System.Drawing.Size(188, 40);
            this.grpStockStatus.TabIndex = 61;
            this.grpStockStatus.TabStop = false;
            // 
            // radioBtnFinish
            // 
            this.radioBtnFinish.AutoSize = true;
            this.radioBtnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnFinish.Location = new System.Drawing.Point(92, 11);
            this.radioBtnFinish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnFinish.Name = "radioBtnFinish";
            this.radioBtnFinish.Size = new System.Drawing.Size(86, 21);
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
            this.radioBtnAvailable.Location = new System.Drawing.Point(12, 9);
            this.radioBtnAvailable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnAvailable.Name = "radioBtnAvailable";
            this.radioBtnAvailable.Size = new System.Drawing.Size(78, 21);
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
            this.grpPayType.Location = new System.Drawing.Point(166, 233);
            this.grpPayType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPayType.Name = "grpPayType";
            this.grpPayType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPayType.Size = new System.Drawing.Size(306, 34);
            this.grpPayType.TabIndex = 60;
            this.grpPayType.TabStop = false;
            // 
            // radioBtnInstalment
            // 
            this.radioBtnInstalment.AutoSize = true;
            this.radioBtnInstalment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnInstalment.Location = new System.Drawing.Point(145, 11);
            this.radioBtnInstalment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnInstalment.Name = "radioBtnInstalment";
            this.radioBtnInstalment.Size = new System.Drawing.Size(90, 21);
            this.radioBtnInstalment.TabIndex = 32;
            this.radioBtnInstalment.Text = "Instalment";
            this.radioBtnInstalment.UseVisualStyleBackColor = true;
            // 
            // radioBtnCash
            // 
            this.radioBtnCash.AutoSize = true;
            this.radioBtnCash.Checked = true;
            this.radioBtnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnCash.Location = new System.Drawing.Point(12, 10);
            this.radioBtnCash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnCash.Name = "radioBtnCash";
            this.radioBtnCash.Size = new System.Drawing.Size(58, 21);
            this.radioBtnCash.TabIndex = 30;
            this.radioBtnCash.TabStop = true;
            this.radioBtnCash.Text = "Cash";
            this.radioBtnCash.UseVisualStyleBackColor = true;
            // 
            // radioBtnOther
            // 
            this.radioBtnOther.AutoSize = true;
            this.radioBtnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnOther.Location = new System.Drawing.Point(237, 11);
            this.radioBtnOther.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnOther.Name = "radioBtnOther";
            this.radioBtnOther.Size = new System.Drawing.Size(62, 21);
            this.radioBtnOther.TabIndex = 31;
            this.radioBtnOther.Text = "Other";
            this.radioBtnOther.UseVisualStyleBackColor = true;
            // 
            // radioBtnCredit
            // 
            this.radioBtnCredit.AutoSize = true;
            this.radioBtnCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBtnCredit.Location = new System.Drawing.Point(76, 11);
            this.radioBtnCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnCredit.Name = "radioBtnCredit";
            this.radioBtnCredit.Size = new System.Drawing.Size(63, 21);
            this.radioBtnCredit.TabIndex = 33;
            this.radioBtnCredit.Text = "Credit";
            this.radioBtnCredit.UseVisualStyleBackColor = true;
            // 
            // datePaid
            // 
            //this.datePaid.CustomFormat = " ";
            this.datePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePaid.Location = new System.Drawing.Point(178, 351);
            this.datePaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePaid.Name = "datePaid";
            this.datePaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePaid.Size = new System.Drawing.Size(91, 23);
            this.datePaid.TabIndex = 59;
            this.datePaid.Value = new System.DateTime(2020, 2, 16, 0, 0, 0, 0);
            // 
            // lblPaidDate
            // 
            this.lblPaidDate.AutoSize = true;
            this.lblPaidDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPaidDate.Location = new System.Drawing.Point(28, 356);
            this.lblPaidDate.Name = "lblPaidDate";
            this.lblPaidDate.Size = new System.Drawing.Size(70, 17);
            this.lblPaidDate.TabIndex = 58;
            this.lblPaidDate.Text = "Paid Date";
            // 
            // dateSalesOrder
            // 
            this.dateSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateSalesOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSalesOrder.Location = new System.Drawing.Point(178, 197);
            this.dateSalesOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateSalesOrder.Name = "dateSalesOrder";
            this.dateSalesOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateSalesOrder.Size = new System.Drawing.Size(91, 23);
            this.dateSalesOrder.TabIndex = 57;
            this.dateSalesOrder.Value = new System.DateTime(2020, 2, 16, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(28, 198);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 56;
            this.lblDate.Text = "Date";
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStockStatus.Location = new System.Drawing.Point(28, 281);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(87, 17);
            this.lblStockStatus.TabIndex = 55;
            this.lblStockStatus.Text = "Sales Status";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.Location = new System.Drawing.Point(28, 246);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(68, 17);
            this.lblType.TabIndex = 54;
            this.lblType.Text = "Pay Type";
            // 
            // chkPaid
            // 
            this.chkPaid.AutoSize = true;
            this.chkPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkPaid.Location = new System.Drawing.Point(178, 318);
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.Size = new System.Drawing.Size(69, 21);
            this.chkPaid.TabIndex = 53;
            this.chkPaid.Text = "Is Paid";
            this.chkPaid.UseVisualStyleBackColor = true;
            this.chkPaid.CheckedChanged += new System.EventHandler(this.chkPaid_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(356, 396);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 32);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(178, 156);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(260, 20);
            this.txtDiscount.TabIndex = 51;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDiscount.Location = new System.Drawing.Point(28, 158);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(63, 17);
            this.lblDiscount.TabIndex = 50;
            this.lblDiscount.Text = "Discount";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(178, 114);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(260, 20);
            this.txtPrice.TabIndex = 49;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrice.Location = new System.Drawing.Point(28, 115);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 48;
            this.lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(178, 72);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 20);
            this.txtDescription.TabIndex = 47;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPname.Location = new System.Drawing.Point(28, 73);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(79, 17);
            this.lblPname.TabIndex = 46;
            this.lblPname.Text = "Description";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(178, 35);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(260, 21);
            this.cmbCustomer.TabIndex = 45;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomer.Location = new System.Drawing.Point(28, 38);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(68, 17);
            this.lblCustomer.TabIndex = 44;
            this.lblCustomer.Text = "Customer";
            // 
            // frmSalesOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(484, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpStockStatus);
            this.Controls.Add(this.grpPayType);
            this.Controls.Add(this.datePaid);
            this.Controls.Add(this.lblPaidDate);
            this.Controls.Add(this.dateSalesOrder);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "frmSalesOrderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalesOrderAdd";
            this.Closed += new System.EventHandler(this.frmPurchaseOrderAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmSalesOrderAdd_Load);
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
        private System.Windows.Forms.DateTimePicker dateSalesOrder;
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