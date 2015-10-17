namespace Account_Management
{
    partial class Form1
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
            this.chkPaymentTerms = new System.Windows.Forms.CheckBox();
            this.ddlRecievableStatus = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.pkrInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.chkPaidReports = new System.Windows.Forms.CheckBox();
            this.chkPartiallyPaidReportsOnly = new System.Windows.Forms.CheckBox();
            this.chkUnpaidReports = new System.Windows.Forms.CheckBox();
            this.PrintReportsPDF = new System.Windows.Forms.Button();
            this.chkDueDatePkr = new System.Windows.Forms.CheckBox();
            this.chkInvoiceDatePkr = new System.Windows.Forms.CheckBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.chkDueDate = new System.Windows.Forms.CheckBox();
            this.chkReceivableStatus = new System.Windows.Forms.CheckBox();
            this.chkItem = new System.Windows.Forms.CheckBox();
            this.chkAmount = new System.Windows.Forms.CheckBox();
            this.chkBranch = new System.Windows.Forms.CheckBox();
            this.chkCustomerName = new System.Windows.Forms.CheckBox();
            this.chkInvoiceNumber = new System.Windows.Forms.CheckBox();
            this.pkrReportInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.Label25 = new System.Windows.Forms.Label();
            this.btnResetReports = new System.Windows.Forms.Button();
            this.btnSearchReport = new System.Windows.Forms.Button();
            this.txtReportSalesRep = new System.Windows.Forms.TextBox();
            this.txtReportBranch = new System.Windows.Forms.TextBox();
            this.dgvReportTable = new System.Windows.Forms.DataGridView();
            this.pkrReportDueDate = new System.Windows.Forms.DateTimePicker();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Add_Rec = new System.Windows.Forms.TabControl();
            this.tabInsertInvoice = new System.Windows.Forms.TabPage();
            this.AddInvoiceItemRow = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPaymentTerms = new System.Windows.Forms.NumericUpDown();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtInvoiceDiscount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pkrEntryDate = new System.Windows.Forms.DateTimePicker();
            this.Label9 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.ResetAddInvoice = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtSalesRepresentative = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.InvoiceItems = new System.Windows.Forms.DataGridView();
            this.RemoveRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabSearchInvoice = new System.Windows.Forms.TabPage();
            this.chkPartiallyPaid = new System.Windows.Forms.CheckBox();
            this.chkUnpaidInvoice = new System.Windows.Forms.CheckBox();
            this.PrintSearchInvoice = new System.Windows.Forms.Button();
            this.chkDueToday = new System.Windows.Forms.CheckBox();
            this.chkDueTo = new System.Windows.Forms.CheckBox();
            this.chkDueFrom = new System.Windows.Forms.CheckBox();
            this.chkEntryTo = new System.Windows.Forms.CheckBox();
            this.chkEntryFrom = new System.Windows.Forms.CheckBox();
            this.pkrInvoiceDueTo = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.pkrInvoiceDueFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvSearchInvoice = new System.Windows.Forms.DataGridView();
            this.SearchInvoiceNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchCustomerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchSalesRep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchEntryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchDueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchEditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditRec_Reset = new System.Windows.Forms.Button();
            this.EditRec_Search = new System.Windows.Forms.Button();
            this.pkrSearchInvoiceTo = new System.Windows.Forms.DateTimePicker();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtSearchCustomerName = new System.Windows.Forms.TextBox();
            this.txtSearchPersonnel = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtSearchInvoiceNumber = new System.Windows.Forms.TextBox();
            this.pkrSearchInvoiceFrom = new System.Windows.Forms.DateTimePicker();
            this.Label13 = new System.Windows.Forms.Label();
            this.tabTableViewer = new System.Windows.Forms.TabPage();
            this.btnRefreshTables = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvRecievables = new System.Windows.Forms.DataGridView();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.label26 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.ddlUserList = new System.Windows.Forms.ComboBox();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportTable)).BeginInit();
            this.Add_Rec.SuspendLayout();
            this.tabInsertInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItems)).BeginInit();
            this.tabSearchInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchInvoice)).BeginInit();
            this.tabTableViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecievables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPaymentTerms
            // 
            this.chkPaymentTerms.AutoSize = true;
            this.chkPaymentTerms.Location = new System.Drawing.Point(328, 95);
            this.chkPaymentTerms.Margin = new System.Windows.Forms.Padding(2);
            this.chkPaymentTerms.Name = "chkPaymentTerms";
            this.chkPaymentTerms.Size = new System.Drawing.Size(99, 17);
            this.chkPaymentTerms.TabIndex = 87;
            this.chkPaymentTerms.Text = "Payment Terms";
            this.chkPaymentTerms.UseVisualStyleBackColor = true;
            // 
            // ddlRecievableStatus
            // 
            this.ddlRecievableStatus.FormattingEnabled = true;
            this.ddlRecievableStatus.Items.AddRange(new object[] {
            "Unpaid",
            "Partially Paid",
            "Paid"});
            this.ddlRecievableStatus.Location = new System.Drawing.Point(515, 79);
            this.ddlRecievableStatus.Margin = new System.Windows.Forms.Padding(2);
            this.ddlRecievableStatus.Name = "ddlRecievableStatus";
            this.ddlRecievableStatus.Size = new System.Drawing.Size(245, 21);
            this.ddlRecievableStatus.TabIndex = 44;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label10.Location = new System.Drawing.Point(395, 82);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(97, 13);
            this.Label10.TabIndex = 43;
            this.Label10.Text = "Receivable Status:";
            // 
            // pkrInvoiceDate
            // 
            this.pkrInvoiceDate.CustomFormat = "MMMM dd, yyyy";
            this.pkrInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrInvoiceDate.Location = new System.Drawing.Point(515, 31);
            this.pkrInvoiceDate.Margin = new System.Windows.Forms.Padding(2);
            this.pkrInvoiceDate.Name = "pkrInvoiceDate";
            this.pkrInvoiceDate.Size = new System.Drawing.Size(245, 20);
            this.pkrInvoiceDate.TabIndex = 40;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(9, 37);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(111, 13);
            this.Label8.TabIndex = 38;
            this.Label8.Text = "Sales Representative:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(395, 58);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(116, 13);
            this.Label7.TabIndex = 37;
            this.Label7.Text = "Payment Terms (Days):";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(395, 37);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(71, 13);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "Invoice Date:";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.chkPaidReports);
            this.tabReports.Controls.Add(this.chkPartiallyPaidReportsOnly);
            this.tabReports.Controls.Add(this.chkUnpaidReports);
            this.tabReports.Controls.Add(this.PrintReportsPDF);
            this.tabReports.Controls.Add(this.chkDueDatePkr);
            this.tabReports.Controls.Add(this.chkInvoiceDatePkr);
            this.tabReports.Controls.Add(this.Label17);
            this.tabReports.Controls.Add(this.chkPaymentTerms);
            this.tabReports.Controls.Add(this.chkDueDate);
            this.tabReports.Controls.Add(this.chkReceivableStatus);
            this.tabReports.Controls.Add(this.chkItem);
            this.tabReports.Controls.Add(this.chkAmount);
            this.tabReports.Controls.Add(this.chkBranch);
            this.tabReports.Controls.Add(this.chkCustomerName);
            this.tabReports.Controls.Add(this.chkInvoiceNumber);
            this.tabReports.Controls.Add(this.pkrReportInvoiceDate);
            this.tabReports.Controls.Add(this.Label25);
            this.tabReports.Controls.Add(this.btnResetReports);
            this.tabReports.Controls.Add(this.btnSearchReport);
            this.tabReports.Controls.Add(this.txtReportSalesRep);
            this.tabReports.Controls.Add(this.txtReportBranch);
            this.tabReports.Controls.Add(this.dgvReportTable);
            this.tabReports.Controls.Add(this.pkrReportDueDate);
            this.tabReports.Controls.Add(this.Label19);
            this.tabReports.Controls.Add(this.Label21);
            this.tabReports.Controls.Add(this.Label23);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Margin = new System.Windows.Forms.Padding(2);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(2);
            this.tabReports.Size = new System.Drawing.Size(791, 607);
            this.tabReports.TabIndex = 2;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // chkPaidReports
            // 
            this.chkPaidReports.AutoSize = true;
            this.chkPaidReports.Location = new System.Drawing.Point(470, 95);
            this.chkPaidReports.Margin = new System.Windows.Forms.Padding(2);
            this.chkPaidReports.Name = "chkPaidReports";
            this.chkPaidReports.Size = new System.Drawing.Size(80, 17);
            this.chkPaidReports.TabIndex = 94;
            this.chkPaidReports.Text = "Paid Status";
            this.chkPaidReports.UseVisualStyleBackColor = true;
            this.chkPaidReports.CheckedChanged += new System.EventHandler(this.chkPaidReports_CheckedChanged);
            // 
            // chkPartiallyPaidReportsOnly
            // 
            this.chkPartiallyPaidReportsOnly.AutoSize = true;
            this.chkPartiallyPaidReportsOnly.Location = new System.Drawing.Point(470, 138);
            this.chkPartiallyPaidReportsOnly.Margin = new System.Windows.Forms.Padding(2);
            this.chkPartiallyPaidReportsOnly.Name = "chkPartiallyPaidReportsOnly";
            this.chkPartiallyPaidReportsOnly.Size = new System.Drawing.Size(119, 17);
            this.chkPartiallyPaidReportsOnly.TabIndex = 93;
            this.chkPartiallyPaidReportsOnly.Text = "Partially Paid Status";
            this.chkPartiallyPaidReportsOnly.UseVisualStyleBackColor = true;
            this.chkPartiallyPaidReportsOnly.CheckStateChanged += new System.EventHandler(this.chkPartiallyPaidReportsOnly_CheckStateChanged);
            // 
            // chkUnpaidReports
            // 
            this.chkUnpaidReports.AutoSize = true;
            this.chkUnpaidReports.Location = new System.Drawing.Point(470, 116);
            this.chkUnpaidReports.Margin = new System.Windows.Forms.Padding(2);
            this.chkUnpaidReports.Name = "chkUnpaidReports";
            this.chkUnpaidReports.Size = new System.Drawing.Size(93, 17);
            this.chkUnpaidReports.TabIndex = 92;
            this.chkUnpaidReports.Text = "Unpaid Status";
            this.chkUnpaidReports.UseVisualStyleBackColor = true;
            this.chkUnpaidReports.CheckStateChanged += new System.EventHandler(this.chkUnpaidReports_CheckStateChanged);
            // 
            // PrintReportsPDF
            // 
            this.PrintReportsPDF.Location = new System.Drawing.Point(711, 179);
            this.PrintReportsPDF.Name = "PrintReportsPDF";
            this.PrintReportsPDF.Size = new System.Drawing.Size(75, 30);
            this.PrintReportsPDF.TabIndex = 91;
            this.PrintReportsPDF.Text = "Print to PDF";
            this.PrintReportsPDF.UseVisualStyleBackColor = true;
            this.PrintReportsPDF.Click += new System.EventHandler(this.PrintReportsPDF_Click);
            // 
            // chkDueDatePkr
            // 
            this.chkDueDatePkr.AutoSize = true;
            this.chkDueDatePkr.Location = new System.Drawing.Point(345, 45);
            this.chkDueDatePkr.Name = "chkDueDatePkr";
            this.chkDueDatePkr.Size = new System.Drawing.Size(15, 14);
            this.chkDueDatePkr.TabIndex = 90;
            this.chkDueDatePkr.UseVisualStyleBackColor = true;
            this.chkDueDatePkr.CheckedChanged += new System.EventHandler(this.chkDueDatePkr_CheckedChanged);
            // 
            // chkInvoiceDatePkr
            // 
            this.chkInvoiceDatePkr.AutoSize = true;
            this.chkInvoiceDatePkr.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkInvoiceDatePkr.Location = new System.Drawing.Point(345, 22);
            this.chkInvoiceDatePkr.Name = "chkInvoiceDatePkr";
            this.chkInvoiceDatePkr.Size = new System.Drawing.Size(15, 14);
            this.chkInvoiceDatePkr.TabIndex = 89;
            this.chkInvoiceDatePkr.UseVisualStyleBackColor = true;
            this.chkInvoiceDatePkr.CheckedChanged += new System.EventHandler(this.chkInvoiceDatePkr_CheckedChanged);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(14, 76);
            this.Label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(77, 13);
            this.Label17.TabIndex = 88;
            this.Label17.Text = "Report Details:";
            // 
            // chkDueDate
            // 
            this.chkDueDate.AutoSize = true;
            this.chkDueDate.Location = new System.Drawing.Point(206, 138);
            this.chkDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.chkDueDate.Name = "chkDueDate";
            this.chkDueDate.Size = new System.Drawing.Size(72, 17);
            this.chkDueDate.TabIndex = 86;
            this.chkDueDate.Text = "Due Date";
            this.chkDueDate.UseVisualStyleBackColor = true;
            // 
            // chkReceivableStatus
            // 
            this.chkReceivableStatus.AutoSize = true;
            this.chkReceivableStatus.Checked = true;
            this.chkReceivableStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReceivableStatus.Enabled = false;
            this.chkReceivableStatus.Location = new System.Drawing.Point(328, 117);
            this.chkReceivableStatus.Margin = new System.Windows.Forms.Padding(2);
            this.chkReceivableStatus.Name = "chkReceivableStatus";
            this.chkReceivableStatus.Size = new System.Drawing.Size(113, 17);
            this.chkReceivableStatus.TabIndex = 85;
            this.chkReceivableStatus.Text = "Receivable Status";
            this.chkReceivableStatus.UseVisualStyleBackColor = true;
            // 
            // chkItem
            // 
            this.chkItem.AutoSize = true;
            this.chkItem.Location = new System.Drawing.Point(206, 117);
            this.chkItem.Margin = new System.Windows.Forms.Padding(2);
            this.chkItem.Name = "chkItem";
            this.chkItem.Size = new System.Drawing.Size(46, 17);
            this.chkItem.TabIndex = 84;
            this.chkItem.Text = "Item";
            this.chkItem.UseVisualStyleBackColor = true;
            // 
            // chkAmount
            // 
            this.chkAmount.AutoSize = true;
            this.chkAmount.Location = new System.Drawing.Point(206, 95);
            this.chkAmount.Margin = new System.Windows.Forms.Padding(2);
            this.chkAmount.Name = "chkAmount";
            this.chkAmount.Size = new System.Drawing.Size(62, 17);
            this.chkAmount.TabIndex = 83;
            this.chkAmount.Text = "Amount";
            this.chkAmount.UseVisualStyleBackColor = true;
            // 
            // chkBranch
            // 
            this.chkBranch.AutoSize = true;
            this.chkBranch.Location = new System.Drawing.Point(67, 138);
            this.chkBranch.Margin = new System.Windows.Forms.Padding(2);
            this.chkBranch.Name = "chkBranch";
            this.chkBranch.Size = new System.Drawing.Size(60, 17);
            this.chkBranch.TabIndex = 82;
            this.chkBranch.Text = "Branch";
            this.chkBranch.UseVisualStyleBackColor = true;
            // 
            // chkCustomerName
            // 
            this.chkCustomerName.AutoSize = true;
            this.chkCustomerName.Location = new System.Drawing.Point(67, 117);
            this.chkCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.chkCustomerName.Name = "chkCustomerName";
            this.chkCustomerName.Size = new System.Drawing.Size(101, 17);
            this.chkCustomerName.TabIndex = 81;
            this.chkCustomerName.Text = "Customer Name";
            this.chkCustomerName.UseVisualStyleBackColor = true;
            // 
            // chkInvoiceNumber
            // 
            this.chkInvoiceNumber.AutoSize = true;
            this.chkInvoiceNumber.Location = new System.Drawing.Point(67, 95);
            this.chkInvoiceNumber.Margin = new System.Windows.Forms.Padding(2);
            this.chkInvoiceNumber.Name = "chkInvoiceNumber";
            this.chkInvoiceNumber.Size = new System.Drawing.Size(101, 17);
            this.chkInvoiceNumber.TabIndex = 80;
            this.chkInvoiceNumber.Text = "Invoice Number";
            this.chkInvoiceNumber.UseVisualStyleBackColor = true;
            // 
            // pkrReportInvoiceDate
            // 
            this.pkrReportInvoiceDate.CustomFormat = "MMMM dd, yyyy";
            this.pkrReportInvoiceDate.Enabled = false;
            this.pkrReportInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrReportInvoiceDate.Location = new System.Drawing.Point(440, 19);
            this.pkrReportInvoiceDate.Margin = new System.Windows.Forms.Padding(2);
            this.pkrReportInvoiceDate.Name = "pkrReportInvoiceDate";
            this.pkrReportInvoiceDate.Size = new System.Drawing.Size(175, 20);
            this.pkrReportInvoiceDate.TabIndex = 79;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(380, 45);
            this.Label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(56, 13);
            this.Label25.TabIndex = 77;
            this.Label25.Text = "Due Date:";
            // 
            // btnResetReports
            // 
            this.btnResetReports.Location = new System.Drawing.Point(327, 177);
            this.btnResetReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetReports.Name = "btnResetReports";
            this.btnResetReports.Size = new System.Drawing.Size(66, 32);
            this.btnResetReports.TabIndex = 74;
            this.btnResetReports.Text = "Reset";
            this.btnResetReports.UseVisualStyleBackColor = true;
            this.btnResetReports.Click += new System.EventHandler(this.btnResetReports_Click);
            // 
            // btnSearchReport
            // 
            this.btnSearchReport.Location = new System.Drawing.Point(414, 177);
            this.btnSearchReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchReport.Name = "btnSearchReport";
            this.btnSearchReport.Size = new System.Drawing.Size(66, 32);
            this.btnSearchReport.TabIndex = 73;
            this.btnSearchReport.Text = "Search";
            this.btnSearchReport.UseVisualStyleBackColor = true;
            this.btnSearchReport.Click += new System.EventHandler(this.btnSearchReport_Click);
            // 
            // txtReportSalesRep
            // 
            this.txtReportSalesRep.Location = new System.Drawing.Point(131, 45);
            this.txtReportSalesRep.Margin = new System.Windows.Forms.Padding(2);
            this.txtReportSalesRep.Name = "txtReportSalesRep";
            this.txtReportSalesRep.Size = new System.Drawing.Size(182, 20);
            this.txtReportSalesRep.TabIndex = 65;
            // 
            // txtReportBranch
            // 
            this.txtReportBranch.Location = new System.Drawing.Point(131, 22);
            this.txtReportBranch.Margin = new System.Windows.Forms.Padding(2);
            this.txtReportBranch.Name = "txtReportBranch";
            this.txtReportBranch.Size = new System.Drawing.Size(182, 20);
            this.txtReportBranch.TabIndex = 63;
            // 
            // dgvReportTable
            // 
            this.dgvReportTable.AllowUserToAddRows = false;
            this.dgvReportTable.AllowUserToDeleteRows = false;
            this.dgvReportTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportTable.Location = new System.Drawing.Point(12, 214);
            this.dgvReportTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReportTable.Name = "dgvReportTable";
            this.dgvReportTable.ReadOnly = true;
            this.dgvReportTable.RowHeadersVisible = false;
            this.dgvReportTable.RowTemplate.Height = 24;
            this.dgvReportTable.Size = new System.Drawing.Size(775, 369);
            this.dgvReportTable.TabIndex = 70;
            // 
            // pkrReportDueDate
            // 
            this.pkrReportDueDate.CustomFormat = "MMMM dd, yyyy";
            this.pkrReportDueDate.Enabled = false;
            this.pkrReportDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrReportDueDate.Location = new System.Drawing.Point(441, 43);
            this.pkrReportDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.pkrReportDueDate.Name = "pkrReportDueDate";
            this.pkrReportDueDate.Size = new System.Drawing.Size(175, 20);
            this.pkrReportDueDate.TabIndex = 64;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(10, 42);
            this.Label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(111, 13);
            this.Label19.TabIndex = 62;
            this.Label19.Text = "Sales Representative:";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(365, 22);
            this.Label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(71, 13);
            this.Label21.TabIndex = 60;
            this.Label21.Text = "Invoice Date:";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(10, 20);
            this.Label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(44, 13);
            this.Label23.TabIndex = 58;
            this.Label23.Text = "Branch:";
            // 
            // Add_Rec
            // 
            this.Add_Rec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Rec.Controls.Add(this.tabInsertInvoice);
            this.Add_Rec.Controls.Add(this.tabSearchInvoice);
            this.Add_Rec.Controls.Add(this.tabReports);
            this.Add_Rec.Controls.Add(this.tabTableViewer);
            this.Add_Rec.Enabled = false;
            this.Add_Rec.Location = new System.Drawing.Point(9, 42);
            this.Add_Rec.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Rec.Name = "Add_Rec";
            this.Add_Rec.SelectedIndex = 0;
            this.Add_Rec.Size = new System.Drawing.Size(799, 633);
            this.Add_Rec.TabIndex = 30;
            // 
            // tabInsertInvoice
            // 
            this.tabInsertInvoice.Controls.Add(this.AddInvoiceItemRow);
            this.tabInsertInvoice.Controls.Add(this.label27);
            this.tabInsertInvoice.Controls.Add(this.label24);
            this.tabInsertInvoice.Controls.Add(this.txtAddress);
            this.tabInsertInvoice.Controls.Add(this.txtPaymentTerms);
            this.tabInsertInvoice.Controls.Add(this.txtInvoiceTotal);
            this.tabInsertInvoice.Controls.Add(this.label22);
            this.tabInsertInvoice.Controls.Add(this.txtInvoiceNumber);
            this.tabInsertInvoice.Controls.Add(this.Label3);
            this.tabInsertInvoice.Controls.Add(this.txtInvoiceDiscount);
            this.tabInsertInvoice.Controls.Add(this.label20);
            this.tabInsertInvoice.Controls.Add(this.txtContactNumber);
            this.tabInsertInvoice.Controls.Add(this.label18);
            this.tabInsertInvoice.Controls.Add(this.pkrEntryDate);
            this.tabInsertInvoice.Controls.Add(this.Label9);
            this.tabInsertInvoice.Controls.Add(this.Button3);
            this.tabInsertInvoice.Controls.Add(this.ResetAddInvoice);
            this.tabInsertInvoice.Controls.Add(this.Add);
            this.tabInsertInvoice.Controls.Add(this.txtRemarks);
            this.tabInsertInvoice.Controls.Add(this.txtCustomerName);
            this.tabInsertInvoice.Controls.Add(this.txtSalesRepresentative);
            this.tabInsertInvoice.Controls.Add(this.txtBranch);
            this.tabInsertInvoice.Controls.Add(this.InvoiceItems);
            this.tabInsertInvoice.Controls.Add(this.ddlRecievableStatus);
            this.tabInsertInvoice.Controls.Add(this.Label10);
            this.tabInsertInvoice.Controls.Add(this.pkrInvoiceDate);
            this.tabInsertInvoice.Controls.Add(this.Label8);
            this.tabInsertInvoice.Controls.Add(this.Label7);
            this.tabInsertInvoice.Controls.Add(this.Label6);
            this.tabInsertInvoice.Controls.Add(this.Label5);
            this.tabInsertInvoice.Controls.Add(this.Label4);
            this.tabInsertInvoice.Controls.Add(this.Label2);
            this.tabInsertInvoice.Controls.Add(this.Label1);
            this.tabInsertInvoice.Location = new System.Drawing.Point(4, 22);
            this.tabInsertInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.tabInsertInvoice.Name = "tabInsertInvoice";
            this.tabInsertInvoice.Padding = new System.Windows.Forms.Padding(2);
            this.tabInsertInvoice.Size = new System.Drawing.Size(791, 607);
            this.tabInsertInvoice.TabIndex = 0;
            this.tabInsertInvoice.Text = "Add Invoice";
            this.tabInsertInvoice.UseVisualStyleBackColor = true;
            // 
            // AddInvoiceItemRow
            // 
            this.AddInvoiceItemRow.Location = new System.Drawing.Point(12, 156);
            this.AddInvoiceItemRow.Name = "AddInvoiceItemRow";
            this.AddInvoiceItemRow.Size = new System.Drawing.Size(75, 23);
            this.AddInvoiceItemRow.TabIndex = 65;
            this.AddInvoiceItemRow.Text = "ADD ROW";
            this.AddInvoiceItemRow.UseVisualStyleBackColor = true;
            this.AddInvoiceItemRow.Click += new System.EventHandler(this.AddInvoiceItemRow_Click);
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Maroon;
            this.label27.Location = new System.Drawing.Point(69, 490);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 9);
            this.label27.TabIndex = 64;
            this.label27.Text = "optional";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Maroon;
            this.label24.Location = new System.Drawing.Point(450, 106);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 9);
            this.label24.TabIndex = 63;
            this.label24.Text = "optional";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(122, 132);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(638, 20);
            this.txtAddress.TabIndex = 62;
            // 
            // txtPaymentTerms
            // 
            this.txtPaymentTerms.Location = new System.Drawing.Point(515, 55);
            this.txtPaymentTerms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPaymentTerms.Name = "txtPaymentTerms";
            this.txtPaymentTerms.Size = new System.Drawing.Size(245, 20);
            this.txtPaymentTerms.TabIndex = 61;
            this.txtPaymentTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaymentTerms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceTotal.Location = new System.Drawing.Point(116, 444);
            this.txtInvoiceTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.ReadOnly = true;
            this.txtInvoiceTotal.Size = new System.Drawing.Size(671, 35);
            this.txtInvoiceTotal.TabIndex = 60;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 445);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 31);
            this.label22.TabIndex = 59;
            this.label22.Text = "TOTAL:";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(122, 10);
            this.txtInvoiceNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(214, 20);
            this.txtInvoiceNumber.TabIndex = 30;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 13);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(85, 13);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "Invoice Number:";
            // 
            // txtInvoiceDiscount
            // 
            this.txtInvoiceDiscount.Location = new System.Drawing.Point(515, 104);
            this.txtInvoiceDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceDiscount.Name = "txtInvoiceDiscount";
            this.txtInvoiceDiscount.Size = new System.Drawing.Size(245, 20);
            this.txtInvoiceDiscount.TabIndex = 58;
            this.txtInvoiceDiscount.TextChanged += new System.EventHandler(this.txtInvoiceDiscount_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(394, 106);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "Discount:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(122, 108);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(214, 20);
            this.txtContactNumber.TabIndex = 56;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 111);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Contact Number:";
            // 
            // pkrEntryDate
            // 
            this.pkrEntryDate.CustomFormat = "MMMM dd, yyyy";
            this.pkrEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrEntryDate.Location = new System.Drawing.Point(515, 7);
            this.pkrEntryDate.Margin = new System.Windows.Forms.Padding(2);
            this.pkrEntryDate.Name = "pkrEntryDate";
            this.pkrEntryDate.Size = new System.Drawing.Size(245, 20);
            this.pkrEntryDate.TabIndex = 53;
            // 
            // Label9
            // 
            this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(13, 490);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(52, 13);
            this.Label9.TabIndex = 52;
            this.Label9.Text = "Remarks:";
            // 
            // Button3
            // 
            this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button3.Location = new System.Drawing.Point(436, 569);
            this.Button3.Margin = new System.Windows.Forms.Padding(2);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(92, 34);
            this.Button3.TabIndex = 51;
            this.Button3.Text = "BACK TO MAIN";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // ResetAddInvoice
            // 
            this.ResetAddInvoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResetAddInvoice.Location = new System.Drawing.Point(244, 569);
            this.ResetAddInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.ResetAddInvoice.Name = "ResetAddInvoice";
            this.ResetAddInvoice.Size = new System.Drawing.Size(92, 34);
            this.ResetAddInvoice.TabIndex = 50;
            this.ResetAddInvoice.Text = "RESET";
            this.ResetAddInvoice.UseVisualStyleBackColor = true;
            this.ResetAddInvoice.Click += new System.EventHandler(this.ResetAddInvoice_Click);
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add.Location = new System.Drawing.Point(340, 569);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(92, 34);
            this.Add.TabIndex = 49;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Location = new System.Drawing.Point(15, 505);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(772, 60);
            this.txtRemarks.TabIndex = 48;
            this.txtRemarks.Text = "";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(122, 85);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(214, 20);
            this.txtCustomerName.TabIndex = 42;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // txtSalesRepresentative
            // 
            this.txtSalesRepresentative.Location = new System.Drawing.Point(122, 34);
            this.txtSalesRepresentative.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalesRepresentative.Name = "txtSalesRepresentative";
            this.txtSalesRepresentative.Size = new System.Drawing.Size(214, 20);
            this.txtSalesRepresentative.TabIndex = 41;
            this.txtSalesRepresentative.TextChanged += new System.EventHandler(this.txtSalesRepresentative_TextChanged);
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(122, 58);
            this.txtBranch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(214, 20);
            this.txtBranch.TabIndex = 39;
            // 
            // InvoiceItems
            // 
            this.InvoiceItems.AllowUserToAddRows = false;
            this.InvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RemoveRow,
            this.Qty,
            this.Item,
            this.Brand,
            this.Price,
            this.Discount,
            this.Amount});
            this.InvoiceItems.Location = new System.Drawing.Point(13, 184);
            this.InvoiceItems.Margin = new System.Windows.Forms.Padding(2);
            this.InvoiceItems.Name = "InvoiceItems";
            this.InvoiceItems.RowHeadersVisible = false;
            this.InvoiceItems.RowTemplate.Height = 24;
            this.InvoiceItems.Size = new System.Drawing.Size(774, 245);
            this.InvoiceItems.TabIndex = 46;
            this.InvoiceItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceItems_CellContentClick);
            this.InvoiceItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceItems_CellValueChanged);
            this.InvoiceItems.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.InvoiceItems_EditingControlShowing);
            // 
            // RemoveRow
            // 
            this.RemoveRow.HeaderText = "";
            this.RemoveRow.Name = "RemoveRow";
            this.RemoveRow.ReadOnly = true;
            this.RemoveRow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RemoveRow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RemoveRow.Text = "X";
            this.RemoveRow.UseColumnTextForButtonValue = true;
            this.RemoveRow.Width = 30;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Qty.Width = 80;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.FillWeight = 31.91489F;
            this.Item.HeaderText = "Item Code";
            this.Item.Name = "Item";
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            // 
            // Price
            // 
            this.Price.FillWeight = 236.1702F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Disc. (optional)";
            this.Discount.Name = "Discount";
            this.Discount.Width = 70;
            // 
            // Amount
            // 
            this.Amount.FillWeight = 31.91489F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(395, 13);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 13);
            this.Label5.TabIndex = 35;
            this.Label5.Text = "Entry Date:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 61);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(44, 13);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "Branch:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(10, 135);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Address:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(10, 85);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 13);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "Customer Name:";
            // 
            // tabSearchInvoice
            // 
            this.tabSearchInvoice.Controls.Add(this.chkPartiallyPaid);
            this.tabSearchInvoice.Controls.Add(this.chkUnpaidInvoice);
            this.tabSearchInvoice.Controls.Add(this.PrintSearchInvoice);
            this.tabSearchInvoice.Controls.Add(this.chkDueToday);
            this.tabSearchInvoice.Controls.Add(this.chkDueTo);
            this.tabSearchInvoice.Controls.Add(this.chkDueFrom);
            this.tabSearchInvoice.Controls.Add(this.chkEntryTo);
            this.tabSearchInvoice.Controls.Add(this.chkEntryFrom);
            this.tabSearchInvoice.Controls.Add(this.pkrInvoiceDueTo);
            this.tabSearchInvoice.Controls.Add(this.label28);
            this.tabSearchInvoice.Controls.Add(this.label29);
            this.tabSearchInvoice.Controls.Add(this.label30);
            this.tabSearchInvoice.Controls.Add(this.pkrInvoiceDueFrom);
            this.tabSearchInvoice.Controls.Add(this.dgvSearchInvoice);
            this.tabSearchInvoice.Controls.Add(this.EditRec_Reset);
            this.tabSearchInvoice.Controls.Add(this.EditRec_Search);
            this.tabSearchInvoice.Controls.Add(this.pkrSearchInvoiceTo);
            this.tabSearchInvoice.Controls.Add(this.Label16);
            this.tabSearchInvoice.Controls.Add(this.Label15);
            this.tabSearchInvoice.Controls.Add(this.txtSearchCustomerName);
            this.tabSearchInvoice.Controls.Add(this.txtSearchPersonnel);
            this.tabSearchInvoice.Controls.Add(this.Label11);
            this.tabSearchInvoice.Controls.Add(this.Label14);
            this.tabSearchInvoice.Controls.Add(this.Label12);
            this.tabSearchInvoice.Controls.Add(this.txtSearchInvoiceNumber);
            this.tabSearchInvoice.Controls.Add(this.pkrSearchInvoiceFrom);
            this.tabSearchInvoice.Controls.Add(this.Label13);
            this.tabSearchInvoice.Location = new System.Drawing.Point(4, 22);
            this.tabSearchInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.tabSearchInvoice.Name = "tabSearchInvoice";
            this.tabSearchInvoice.Padding = new System.Windows.Forms.Padding(2);
            this.tabSearchInvoice.Size = new System.Drawing.Size(791, 607);
            this.tabSearchInvoice.TabIndex = 1;
            this.tabSearchInvoice.Text = "Search Invoice";
            this.tabSearchInvoice.UseVisualStyleBackColor = true;
            // 
            // chkPartiallyPaid
            // 
            this.chkPartiallyPaid.AutoSize = true;
            this.chkPartiallyPaid.Location = new System.Drawing.Point(167, 140);
            this.chkPartiallyPaid.Name = "chkPartiallyPaid";
            this.chkPartiallyPaid.Size = new System.Drawing.Size(86, 17);
            this.chkPartiallyPaid.TabIndex = 79;
            this.chkPartiallyPaid.Text = "Partially Paid";
            this.chkPartiallyPaid.UseVisualStyleBackColor = true;
            // 
            // chkUnpaidInvoice
            // 
            this.chkUnpaidInvoice.AutoSize = true;
            this.chkUnpaidInvoice.Location = new System.Drawing.Point(101, 140);
            this.chkUnpaidInvoice.Name = "chkUnpaidInvoice";
            this.chkUnpaidInvoice.Size = new System.Drawing.Size(60, 17);
            this.chkUnpaidInvoice.TabIndex = 78;
            this.chkUnpaidInvoice.Text = "Unpaid";
            this.chkUnpaidInvoice.UseVisualStyleBackColor = true;
            // 
            // PrintSearchInvoice
            // 
            this.PrintSearchInvoice.Location = new System.Drawing.Point(701, 118);
            this.PrintSearchInvoice.Name = "PrintSearchInvoice";
            this.PrintSearchInvoice.Size = new System.Drawing.Size(75, 30);
            this.PrintSearchInvoice.TabIndex = 77;
            this.PrintSearchInvoice.Text = "Print to PDF";
            this.PrintSearchInvoice.UseVisualStyleBackColor = true;
            this.PrintSearchInvoice.Click += new System.EventHandler(this.PrintSearchInvoice_Click);
            // 
            // chkDueToday
            // 
            this.chkDueToday.AutoSize = true;
            this.chkDueToday.Location = new System.Drawing.Point(16, 140);
            this.chkDueToday.Name = "chkDueToday";
            this.chkDueToday.Size = new System.Drawing.Size(79, 17);
            this.chkDueToday.TabIndex = 76;
            this.chkDueToday.Text = "Due Today";
            this.chkDueToday.UseVisualStyleBackColor = true;
            this.chkDueToday.CheckedChanged += new System.EventHandler(this.chkDueToday_CheckedChanged);
            // 
            // chkDueTo
            // 
            this.chkDueTo.AutoSize = true;
            this.chkDueTo.Location = new System.Drawing.Point(551, 86);
            this.chkDueTo.Name = "chkDueTo";
            this.chkDueTo.Size = new System.Drawing.Size(15, 14);
            this.chkDueTo.TabIndex = 75;
            this.chkDueTo.UseVisualStyleBackColor = true;
            this.chkDueTo.CheckedChanged += new System.EventHandler(this.chkDueTo_CheckedChanged);
            // 
            // chkDueFrom
            // 
            this.chkDueFrom.AutoSize = true;
            this.chkDueFrom.Location = new System.Drawing.Point(342, 86);
            this.chkDueFrom.Name = "chkDueFrom";
            this.chkDueFrom.Size = new System.Drawing.Size(15, 14);
            this.chkDueFrom.TabIndex = 74;
            this.chkDueFrom.UseVisualStyleBackColor = true;
            this.chkDueFrom.CheckedChanged += new System.EventHandler(this.chkDueFrom_CheckedChanged);
            // 
            // chkEntryTo
            // 
            this.chkEntryTo.AutoSize = true;
            this.chkEntryTo.Location = new System.Drawing.Point(551, 40);
            this.chkEntryTo.Name = "chkEntryTo";
            this.chkEntryTo.Size = new System.Drawing.Size(15, 14);
            this.chkEntryTo.TabIndex = 73;
            this.chkEntryTo.UseVisualStyleBackColor = true;
            this.chkEntryTo.CheckedChanged += new System.EventHandler(this.chkEntryTo_CheckedChanged);
            // 
            // chkEntryFrom
            // 
            this.chkEntryFrom.AutoSize = true;
            this.chkEntryFrom.Location = new System.Drawing.Point(342, 40);
            this.chkEntryFrom.Name = "chkEntryFrom";
            this.chkEntryFrom.Size = new System.Drawing.Size(15, 14);
            this.chkEntryFrom.TabIndex = 72;
            this.chkEntryFrom.UseVisualStyleBackColor = true;
            this.chkEntryFrom.CheckedChanged += new System.EventHandler(this.chkEntryFrom_CheckedChanged);
            // 
            // pkrInvoiceDueTo
            // 
            this.pkrInvoiceDueTo.CustomFormat = "MMMM dd, yyyy";
            this.pkrInvoiceDueTo.Enabled = false;
            this.pkrInvoiceDueTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrInvoiceDueTo.Location = new System.Drawing.Point(598, 83);
            this.pkrInvoiceDueTo.Margin = new System.Windows.Forms.Padding(2);
            this.pkrInvoiceDueTo.Name = "pkrInvoiceDueTo";
            this.pkrInvoiceDueTo.Size = new System.Drawing.Size(138, 20);
            this.pkrInvoiceDueTo.TabIndex = 71;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(571, 87);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 13);
            this.label28.TabIndex = 70;
            this.label28.Text = "To:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(362, 86);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(33, 13);
            this.label29.TabIndex = 69;
            this.label29.Text = "From:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(339, 63);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(56, 13);
            this.label30.TabIndex = 68;
            this.label30.Text = "Due Date:";
            // 
            // pkrInvoiceDueFrom
            // 
            this.pkrInvoiceDueFrom.CustomFormat = "MMMM dd, yyyy";
            this.pkrInvoiceDueFrom.Enabled = false;
            this.pkrInvoiceDueFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrInvoiceDueFrom.Location = new System.Drawing.Point(399, 83);
            this.pkrInvoiceDueFrom.Margin = new System.Windows.Forms.Padding(2);
            this.pkrInvoiceDueFrom.Name = "pkrInvoiceDueFrom";
            this.pkrInvoiceDueFrom.Size = new System.Drawing.Size(138, 20);
            this.pkrInvoiceDueFrom.TabIndex = 67;
            // 
            // dgvSearchInvoice
            // 
            this.dgvSearchInvoice.AllowUserToAddRows = false;
            this.dgvSearchInvoice.AllowUserToDeleteRows = false;
            this.dgvSearchInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SearchInvoiceNumberColumn,
            this.SearchCustomerNameColumn,
            this.SearchSalesRep,
            this.SearchEntryDateColumn,
            this.SearchDueDateColumn,
            this.SearchEditColumn,
            this.InvoiceId});
            this.dgvSearchInvoice.Location = new System.Drawing.Point(16, 162);
            this.dgvSearchInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSearchInvoice.Name = "dgvSearchInvoice";
            this.dgvSearchInvoice.ReadOnly = true;
            this.dgvSearchInvoice.RowHeadersVisible = false;
            this.dgvSearchInvoice.RowTemplate.Height = 24;
            this.dgvSearchInvoice.Size = new System.Drawing.Size(760, 441);
            this.dgvSearchInvoice.TabIndex = 66;
            this.dgvSearchInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchInvoice_CellContentClick);
            // 
            // SearchInvoiceNumberColumn
            // 
            this.SearchInvoiceNumberColumn.HeaderText = "Invoice Number";
            this.SearchInvoiceNumberColumn.Name = "SearchInvoiceNumberColumn";
            this.SearchInvoiceNumberColumn.ReadOnly = true;
            // 
            // SearchCustomerNameColumn
            // 
            this.SearchCustomerNameColumn.HeaderText = "Customer Name";
            this.SearchCustomerNameColumn.Name = "SearchCustomerNameColumn";
            this.SearchCustomerNameColumn.ReadOnly = true;
            // 
            // SearchSalesRep
            // 
            this.SearchSalesRep.HeaderText = "Sales Rep.";
            this.SearchSalesRep.Name = "SearchSalesRep";
            this.SearchSalesRep.ReadOnly = true;
            // 
            // SearchEntryDateColumn
            // 
            this.SearchEntryDateColumn.HeaderText = "Entry Date";
            this.SearchEntryDateColumn.Name = "SearchEntryDateColumn";
            this.SearchEntryDateColumn.ReadOnly = true;
            // 
            // SearchDueDateColumn
            // 
            this.SearchDueDateColumn.HeaderText = "Due Date";
            this.SearchDueDateColumn.Name = "SearchDueDateColumn";
            this.SearchDueDateColumn.ReadOnly = true;
            // 
            // SearchEditColumn
            // 
            this.SearchEditColumn.HeaderText = "";
            this.SearchEditColumn.Name = "SearchEditColumn";
            this.SearchEditColumn.ReadOnly = true;
            this.SearchEditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchEditColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SearchEditColumn.Text = "EDIT / PAY";
            this.SearchEditColumn.UseColumnTextForButtonValue = true;
            // 
            // InvoiceId
            // 
            this.InvoiceId.HeaderText = "Invoice Id";
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.ReadOnly = true;
            this.InvoiceId.Visible = false;
            // 
            // EditRec_Reset
            // 
            this.EditRec_Reset.Location = new System.Drawing.Point(336, 118);
            this.EditRec_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.EditRec_Reset.Name = "EditRec_Reset";
            this.EditRec_Reset.Size = new System.Drawing.Size(71, 30);
            this.EditRec_Reset.TabIndex = 63;
            this.EditRec_Reset.Text = "Reset";
            this.EditRec_Reset.UseVisualStyleBackColor = true;
            this.EditRec_Reset.Click += new System.EventHandler(this.EditRec_Reset_Click);
            // 
            // EditRec_Search
            // 
            this.EditRec_Search.Location = new System.Drawing.Point(414, 118);
            this.EditRec_Search.Margin = new System.Windows.Forms.Padding(2);
            this.EditRec_Search.Name = "EditRec_Search";
            this.EditRec_Search.Size = new System.Drawing.Size(71, 30);
            this.EditRec_Search.TabIndex = 62;
            this.EditRec_Search.Text = "Search";
            this.EditRec_Search.UseVisualStyleBackColor = true;
            this.EditRec_Search.Click += new System.EventHandler(this.EditRec_Search_Click);
            // 
            // pkrSearchInvoiceTo
            // 
            this.pkrSearchInvoiceTo.CustomFormat = "MMMM dd, yyyy";
            this.pkrSearchInvoiceTo.Enabled = false;
            this.pkrSearchInvoiceTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrSearchInvoiceTo.Location = new System.Drawing.Point(598, 37);
            this.pkrSearchInvoiceTo.Margin = new System.Windows.Forms.Padding(2);
            this.pkrSearchInvoiceTo.Name = "pkrSearchInvoiceTo";
            this.pkrSearchInvoiceTo.Size = new System.Drawing.Size(138, 20);
            this.pkrSearchInvoiceTo.TabIndex = 61;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(571, 39);
            this.Label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(23, 13);
            this.Label16.TabIndex = 60;
            this.Label16.Text = "To:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(362, 40);
            this.Label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(33, 13);
            this.Label15.TabIndex = 59;
            this.Label15.Text = "From:";
            // 
            // txtSearchCustomerName
            // 
            this.txtSearchCustomerName.Location = new System.Drawing.Point(129, 60);
            this.txtSearchCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCustomerName.Name = "txtSearchCustomerName";
            this.txtSearchCustomerName.Size = new System.Drawing.Size(192, 20);
            this.txtSearchCustomerName.TabIndex = 58;
            // 
            // txtSearchPersonnel
            // 
            this.txtSearchPersonnel.Location = new System.Drawing.Point(129, 83);
            this.txtSearchPersonnel.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchPersonnel.Name = "txtSearchPersonnel";
            this.txtSearchPersonnel.Size = new System.Drawing.Size(192, 20);
            this.txtSearchPersonnel.TabIndex = 57;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(14, 85);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(111, 13);
            this.Label11.TabIndex = 56;
            this.Label11.Text = "Sales Representative:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(15, 62);
            this.Label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(82, 13);
            this.Label14.TabIndex = 55;
            this.Label14.Text = "Customer Name";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(339, 17);
            this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(60, 13);
            this.Label12.TabIndex = 54;
            this.Label12.Text = "Entry Date:";
            // 
            // txtSearchInvoiceNumber
            // 
            this.txtSearchInvoiceNumber.Location = new System.Drawing.Point(129, 37);
            this.txtSearchInvoiceNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchInvoiceNumber.Name = "txtSearchInvoiceNumber";
            this.txtSearchInvoiceNumber.Size = new System.Drawing.Size(192, 20);
            this.txtSearchInvoiceNumber.TabIndex = 48;
            // 
            // pkrSearchInvoiceFrom
            // 
            this.pkrSearchInvoiceFrom.CustomFormat = "MMMM dd, yyyy";
            this.pkrSearchInvoiceFrom.Enabled = false;
            this.pkrSearchInvoiceFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrSearchInvoiceFrom.Location = new System.Drawing.Point(399, 37);
            this.pkrSearchInvoiceFrom.Margin = new System.Windows.Forms.Padding(2);
            this.pkrSearchInvoiceFrom.Name = "pkrSearchInvoiceFrom";
            this.pkrSearchInvoiceFrom.Size = new System.Drawing.Size(138, 20);
            this.pkrSearchInvoiceFrom.TabIndex = 52;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(15, 37);
            this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(85, 13);
            this.Label13.TabIndex = 49;
            this.Label13.Text = "Invoice Number:";
            // 
            // tabTableViewer
            // 
            this.tabTableViewer.Controls.Add(this.btnRefreshTables);
            this.tabTableViewer.Controls.Add(this.dgvPayments);
            this.tabTableViewer.Controls.Add(this.dgvTransactions);
            this.tabTableViewer.Controls.Add(this.dgvProducts);
            this.tabTableViewer.Controls.Add(this.dgvRecievables);
            this.tabTableViewer.Controls.Add(this.dgvPersonnel);
            this.tabTableViewer.Controls.Add(this.dgvCustomer);
            this.tabTableViewer.Location = new System.Drawing.Point(4, 22);
            this.tabTableViewer.Margin = new System.Windows.Forms.Padding(2);
            this.tabTableViewer.Name = "tabTableViewer";
            this.tabTableViewer.Padding = new System.Windows.Forms.Padding(2);
            this.tabTableViewer.Size = new System.Drawing.Size(791, 607);
            this.tabTableViewer.TabIndex = 3;
            this.tabTableViewer.Text = "Table Viewer";
            this.tabTableViewer.UseVisualStyleBackColor = true;
            // 
            // btnRefreshTables
            // 
            this.btnRefreshTables.Location = new System.Drawing.Point(257, 5);
            this.btnRefreshTables.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshTables.Name = "btnRefreshTables";
            this.btnRefreshTables.Size = new System.Drawing.Size(98, 46);
            this.btnRefreshTables.TabIndex = 6;
            this.btnRefreshTables.Text = "Refresh Tables";
            this.btnRefreshTables.UseVisualStyleBackColor = true;
            this.btnRefreshTables.Click += new System.EventHandler(this.btnRefreshTables_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(4, 531);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.Size = new System.Drawing.Size(783, 90);
            this.dgvPayments.TabIndex = 5;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(4, 431);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(783, 94);
            this.dgvTransactions.TabIndex = 4;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(4, 333);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(783, 93);
            this.dgvProducts.TabIndex = 3;
            // 
            // dgvRecievables
            // 
            this.dgvRecievables.AllowUserToAddRows = false;
            this.dgvRecievables.AllowUserToDeleteRows = false;
            this.dgvRecievables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecievables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecievables.Location = new System.Drawing.Point(4, 238);
            this.dgvRecievables.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRecievables.Name = "dgvRecievables";
            this.dgvRecievables.ReadOnly = true;
            this.dgvRecievables.RowTemplate.Height = 24;
            this.dgvRecievables.Size = new System.Drawing.Size(783, 90);
            this.dgvRecievables.TabIndex = 2;
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(4, 144);
            this.dgvPersonnel.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.Size = new System.Drawing.Size(783, 89);
            this.dgvPersonnel.TabIndex = 1;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(4, 55);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(783, 84);
            this.dgvCustomer.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(501, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 13);
            this.label26.TabIndex = 31;
            this.label26.Text = "USER:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(736, 12);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(72, 25);
            this.btnAddUser.TabIndex = 33;
            this.btnAddUser.Text = "ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnLogToggle_Click);
            // 
            // ddlUserList
            // 
            this.ddlUserList.FormattingEnabled = true;
            this.ddlUserList.Location = new System.Drawing.Point(547, 15);
            this.ddlUserList.Name = "ddlUserList";
            this.ddlUserList.Size = new System.Drawing.Size(183, 21);
            this.ddlUserList.TabIndex = 34;
            this.ddlUserList.SelectedIndexChanged += new System.EventHandler(this.ddlUserList_SelectedIndexChanged);
            this.ddlUserList.TextChanged += new System.EventHandler(this.ddlUserList_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 686);
            this.Controls.Add(this.ddlUserList);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.Add_Rec);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Accounts Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportTable)).EndInit();
            this.Add_Rec.ResumeLayout(false);
            this.tabInsertInvoice.ResumeLayout(false);
            this.tabInsertInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItems)).EndInit();
            this.tabSearchInvoice.ResumeLayout(false);
            this.tabSearchInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchInvoice)).EndInit();
            this.tabTableViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecievables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkPaymentTerms;
        internal System.Windows.Forms.ComboBox ddlRecievableStatus;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.DateTimePicker pkrInvoiceDate;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TabPage tabReports;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.CheckBox chkDueDate;
        internal System.Windows.Forms.CheckBox chkReceivableStatus;
        internal System.Windows.Forms.CheckBox chkItem;
        internal System.Windows.Forms.CheckBox chkAmount;
        internal System.Windows.Forms.CheckBox chkBranch;
        internal System.Windows.Forms.CheckBox chkCustomerName;
        internal System.Windows.Forms.CheckBox chkInvoiceNumber;
        internal System.Windows.Forms.DateTimePicker pkrReportInvoiceDate;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Button btnResetReports;
        internal System.Windows.Forms.Button btnSearchReport;
        internal System.Windows.Forms.TextBox txtReportSalesRep;
        internal System.Windows.Forms.TextBox txtReportBranch;
        internal System.Windows.Forms.DataGridView dgvReportTable;
        internal System.Windows.Forms.DateTimePicker pkrReportDueDate;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TabControl Add_Rec;
        internal System.Windows.Forms.TabPage tabInsertInvoice;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button ResetAddInvoice;
        internal System.Windows.Forms.Button Add;
        internal System.Windows.Forms.RichTextBox txtRemarks;
        internal System.Windows.Forms.TextBox txtCustomerName;
        internal System.Windows.Forms.TextBox txtSalesRepresentative;
        internal System.Windows.Forms.TextBox txtBranch;
        internal System.Windows.Forms.TextBox txtInvoiceNumber;
        internal System.Windows.Forms.DataGridView InvoiceItems;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TabPage tabSearchInvoice;
        internal System.Windows.Forms.DataGridView dgvSearchInvoice;
        internal System.Windows.Forms.Button EditRec_Reset;
        internal System.Windows.Forms.Button EditRec_Search;
        internal System.Windows.Forms.DateTimePicker pkrSearchInvoiceTo;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtSearchCustomerName;
        internal System.Windows.Forms.TextBox txtSearchPersonnel;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtSearchInvoiceNumber;
        internal System.Windows.Forms.DateTimePicker pkrSearchInvoiceFrom;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.DateTimePicker pkrEntryDate;
        private System.Windows.Forms.TabPage tabTableViewer;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvRecievables;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnRefreshTables;
        internal System.Windows.Forms.TextBox txtContactNumber;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox txtInvoiceDiscount;
        internal System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown txtPaymentTerms;
        internal System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnAddUser;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button AddInvoiceItemRow;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        internal System.Windows.Forms.DateTimePicker pkrInvoiceDueTo;
        internal System.Windows.Forms.Label label28;
        internal System.Windows.Forms.Label label29;
        internal System.Windows.Forms.Label label30;
        internal System.Windows.Forms.DateTimePicker pkrInvoiceDueFrom;
        private System.Windows.Forms.CheckBox chkDueTo;
        private System.Windows.Forms.CheckBox chkDueFrom;
        private System.Windows.Forms.CheckBox chkEntryTo;
        private System.Windows.Forms.CheckBox chkEntryFrom;
        private System.Windows.Forms.CheckBox chkDueToday;
        private System.Windows.Forms.ComboBox ddlUserList;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchInvoiceNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchCustomerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchSalesRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchEntryDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchDueDateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SearchEditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId;
        private System.Windows.Forms.CheckBox chkDueDatePkr;
        private System.Windows.Forms.CheckBox chkInvoiceDatePkr;
        private System.Windows.Forms.Button PrintReportsPDF;
        private System.Windows.Forms.Button PrintSearchInvoice;
        private System.Windows.Forms.CheckBox chkUnpaidInvoice;
        private System.Windows.Forms.CheckBox chkPartiallyPaid;
        internal System.Windows.Forms.CheckBox chkUnpaidReports;
        internal System.Windows.Forms.CheckBox chkPartiallyPaidReportsOnly;
        internal System.Windows.Forms.CheckBox chkPaidReports;
    }
}

