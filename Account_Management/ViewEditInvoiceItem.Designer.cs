namespace Account_Management
{
    partial class ViewEditInvoiceItem
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
            this.SaveInvoice = new System.Windows.Forms.Button();
            this.CancelInvoice = new System.Windows.Forms.Button();
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
            this.TransactionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlRecievableStatus = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.pkrInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DeleteInvoice = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pkrCheckDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.CheckNoLabel = new System.Windows.Forms.Label();
            this.txtRemainingReceivable = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotalInvoice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SavePayments = new System.Windows.Forms.Button();
            this.AddPayment = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPaymentRemarks = new System.Windows.Forms.TextBox();
            this.txtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.dgvPaymentDetails = new System.Windows.Forms.DataGridView();
            this.PaymentRemoveRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPaymentType = new System.Windows.Forms.ComboBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItems)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // AddInvoiceItemRow
            // 
            this.AddInvoiceItemRow.Location = new System.Drawing.Point(9, 294);
            this.AddInvoiceItemRow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddInvoiceItemRow.Name = "AddInvoiceItemRow";
            this.AddInvoiceItemRow.Size = new System.Drawing.Size(138, 42);
            this.AddInvoiceItemRow.TabIndex = 98;
            this.AddInvoiceItemRow.Text = "ADD ROW";
            this.AddInvoiceItemRow.UseVisualStyleBackColor = true;
            this.AddInvoiceItemRow.Click += new System.EventHandler(this.AddInvoiceItemRow_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Maroon;
            this.label27.Location = new System.Drawing.Point(127, 834);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 17);
            this.label27.TabIndex = 97;
            this.label27.Text = "optional";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Maroon;
            this.label24.Location = new System.Drawing.Point(814, 201);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 17);
            this.label24.TabIndex = 96;
            this.label24.Text = "optional";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(213, 249);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(1166, 29);
            this.txtAddress.TabIndex = 95;
            // 
            // txtPaymentTerms
            // 
            this.txtPaymentTerms.Location = new System.Drawing.Point(933, 105);
            this.txtPaymentTerms.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPaymentTerms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPaymentTerms.Name = "txtPaymentTerms";
            this.txtPaymentTerms.Size = new System.Drawing.Size(449, 29);
            this.txtPaymentTerms.TabIndex = 94;
            this.txtPaymentTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaymentTerms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceTotal.Location = new System.Drawing.Point(213, 750);
            this.txtInvoiceTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.ReadOnly = true;
            this.txtInvoiceTotal.Size = new System.Drawing.Size(1227, 55);
            this.txtInvoiceTotal.TabIndex = 93;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(17, 750);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(188, 54);
            this.label22.TabIndex = 92;
            this.label22.Text = "TOTAL:";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(213, 22);
            this.txtInvoiceNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(389, 29);
            this.txtInvoiceNumber.TabIndex = 67;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 30);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(154, 25);
            this.Label3.TabIndex = 69;
            this.Label3.Text = "Invoice Number:";
            // 
            // txtInvoiceDiscount
            // 
            this.txtInvoiceDiscount.Location = new System.Drawing.Point(933, 198);
            this.txtInvoiceDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInvoiceDiscount.Name = "txtInvoiceDiscount";
            this.txtInvoiceDiscount.Size = new System.Drawing.Size(446, 29);
            this.txtInvoiceDiscount.TabIndex = 91;
            this.txtInvoiceDiscount.TextChanged += new System.EventHandler(this.txtInvoiceDiscount_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(711, 201);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 24);
            this.label20.TabIndex = 90;
            this.label20.Text = "Discount:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(213, 203);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(389, 29);
            this.txtContactNumber.TabIndex = 89;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 210);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 24);
            this.label18.TabIndex = 88;
            this.label18.Text = "Contact Number:";
            // 
            // pkrEntryDate
            // 
            this.pkrEntryDate.CustomFormat = "MMMM dd, yyyy";
            this.pkrEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrEntryDate.Location = new System.Drawing.Point(933, 18);
            this.pkrEntryDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pkrEntryDate.Name = "pkrEntryDate";
            this.pkrEntryDate.Size = new System.Drawing.Size(446, 29);
            this.pkrEntryDate.TabIndex = 87;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(24, 834);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(95, 25);
            this.Label9.TabIndex = 86;
            this.Label9.Text = "Remarks:";
            // 
            // SaveInvoice
            // 
            this.SaveInvoice.Location = new System.Drawing.Point(477, 982);
            this.SaveInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveInvoice.Name = "SaveInvoice";
            this.SaveInvoice.Size = new System.Drawing.Size(169, 63);
            this.SaveInvoice.TabIndex = 84;
            this.SaveInvoice.Text = "SAVE";
            this.SaveInvoice.UseVisualStyleBackColor = true;
            this.SaveInvoice.Click += new System.EventHandler(this.SaveInvoice_Click);
            // 
            // CancelInvoice
            // 
            this.CancelInvoice.Location = new System.Drawing.Point(653, 982);
            this.CancelInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelInvoice.Name = "CancelInvoice";
            this.CancelInvoice.Size = new System.Drawing.Size(169, 63);
            this.CancelInvoice.TabIndex = 83;
            this.CancelInvoice.Text = "CANCEL";
            this.CancelInvoice.UseVisualStyleBackColor = true;
            this.CancelInvoice.Click += new System.EventHandler(this.CancelInvoice_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(28, 862);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(1412, 107);
            this.txtRemarks.TabIndex = 82;
            this.txtRemarks.Text = "";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(213, 162);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(389, 29);
            this.txtCustomerName.TabIndex = 78;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // txtSalesRepresentative
            // 
            this.txtSalesRepresentative.Location = new System.Drawing.Point(213, 66);
            this.txtSalesRepresentative.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalesRepresentative.Name = "txtSalesRepresentative";
            this.txtSalesRepresentative.Size = new System.Drawing.Size(389, 29);
            this.txtSalesRepresentative.TabIndex = 77;
            this.txtSalesRepresentative.TextChanged += new System.EventHandler(this.txtSalesRepresentative_TextChanged);
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(213, 111);
            this.txtBranch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(389, 29);
            this.txtBranch.TabIndex = 75;
            // 
            // InvoiceItems
            // 
            this.InvoiceItems.AllowUserToAddRows = false;
            this.InvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RemoveRow,
            this.Qty,
            this.Item,
            this.Brand,
            this.Price,
            this.Discount,
            this.Amount,
            this.TransactionIdColumn});
            this.InvoiceItems.Location = new System.Drawing.Point(13, 345);
            this.InvoiceItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InvoiceItems.Name = "InvoiceItems";
            this.InvoiceItems.RowHeadersVisible = false;
            this.InvoiceItems.RowTemplate.Height = 24;
            this.InvoiceItems.Size = new System.Drawing.Size(1419, 397);
            this.InvoiceItems.TabIndex = 81;
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
            // TransactionIdColumn
            // 
            this.TransactionIdColumn.HeaderText = "Transaction Id";
            this.TransactionIdColumn.Name = "TransactionIdColumn";
            this.TransactionIdColumn.ReadOnly = true;
            this.TransactionIdColumn.Visible = false;
            // 
            // ddlRecievableStatus
            // 
            this.ddlRecievableStatus.FormattingEnabled = true;
            this.ddlRecievableStatus.Items.AddRange(new object[] {
            "Unpaid",
            "Partially Paid",
            "Paid",
            "Recieved"});
            this.ddlRecievableStatus.Location = new System.Drawing.Point(933, 150);
            this.ddlRecievableStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddlRecievableStatus.Name = "ddlRecievableStatus";
            this.ddlRecievableStatus.Size = new System.Drawing.Size(446, 32);
            this.ddlRecievableStatus.TabIndex = 80;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label10.Location = new System.Drawing.Point(713, 155);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(175, 25);
            this.Label10.TabIndex = 79;
            this.Label10.Text = "Receivable Status:";
            // 
            // pkrInvoiceDate
            // 
            this.pkrInvoiceDate.CustomFormat = "MMMM dd, yyyy";
            this.pkrInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrInvoiceDate.Location = new System.Drawing.Point(933, 63);
            this.pkrInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pkrInvoiceDate.Name = "pkrInvoiceDate";
            this.pkrInvoiceDate.Size = new System.Drawing.Size(446, 29);
            this.pkrInvoiceDate.TabIndex = 76;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 74);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(203, 25);
            this.Label8.TabIndex = 74;
            this.Label8.Text = "Sales Representative:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(713, 111);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(220, 25);
            this.Label7.TabIndex = 73;
            this.Label7.Text = "Payment Terms (Days):";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(713, 74);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(126, 25);
            this.Label6.TabIndex = 72;
            this.Label6.Text = "Invoice Date:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(713, 30);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(109, 25);
            this.Label5.TabIndex = 71;
            this.Label5.Text = "Entry Date:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(7, 118);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 25);
            this.Label4.TabIndex = 70;
            this.Label4.Text = "Branch:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 255);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 24);
            this.Label2.TabIndex = 68;
            this.Label2.Text = "Address:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(7, 162);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(152, 24);
            this.Label1.TabIndex = 66;
            this.Label1.Text = "Customer Name:";
            // 
            // DeleteInvoice
            // 
            this.DeleteInvoice.Location = new System.Drawing.Point(829, 982);
            this.DeleteInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteInvoice.Name = "DeleteInvoice";
            this.DeleteInvoice.Size = new System.Drawing.Size(169, 63);
            this.DeleteInvoice.TabIndex = 99;
            this.DeleteInvoice.Text = "DELETE";
            this.DeleteInvoice.UseVisualStyleBackColor = true;
            this.DeleteInvoice.Click += new System.EventHandler(this.DeleteInvoice_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1478, 1122);
            this.tabControl1.TabIndex = 100;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Label3);
            this.tabPage1.Controls.Add(this.DeleteInvoice);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.AddInvoiceItemRow);
            this.tabPage1.Controls.Add(this.txtInvoiceTotal);
            this.tabPage1.Controls.Add(this.Label2);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.Label9);
            this.tabPage1.Controls.Add(this.Label4);
            this.tabPage1.Controls.Add(this.SaveInvoice);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.CancelInvoice);
            this.tabPage1.Controls.Add(this.Label5);
            this.tabPage1.Controls.Add(this.txtRemarks);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.Label6);
            this.tabPage1.Controls.Add(this.txtPaymentTerms);
            this.tabPage1.Controls.Add(this.Label7);
            this.tabPage1.Controls.Add(this.Label8);
            this.tabPage1.Controls.Add(this.pkrInvoiceDate);
            this.tabPage1.Controls.Add(this.txtInvoiceNumber);
            this.tabPage1.Controls.Add(this.Label10);
            this.tabPage1.Controls.Add(this.ddlRecievableStatus);
            this.tabPage1.Controls.Add(this.txtInvoiceDiscount);
            this.tabPage1.Controls.Add(this.InvoiceItems);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.txtBranch);
            this.tabPage1.Controls.Add(this.txtContactNumber);
            this.tabPage1.Controls.Add(this.txtSalesRepresentative);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.txtCustomerName);
            this.tabPage1.Controls.Add(this.pkrEntryDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1470, 1085);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Invoice Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pkrCheckDate);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.txtCheckNo);
            this.tabPage2.Controls.Add(this.CheckNoLabel);
            this.tabPage2.Controls.Add(this.txtRemainingReceivable);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.txtTotalInvoice);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtTotalPayment);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.SavePayments);
            this.tabPage2.Controls.Add(this.AddPayment);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtPaymentRemarks);
            this.tabPage2.Controls.Add(this.txtPaymentDate);
            this.tabPage2.Controls.Add(this.dgvPaymentDetails);
            this.tabPage2.Controls.Add(this.txtPaymentType);
            this.tabPage2.Controls.Add(this.txtPaymentAmount);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1470, 1085);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payment Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pkrCheckDate
            // 
            this.pkrCheckDate.CustomFormat = "MMMM dd, yyyy";
            this.pkrCheckDate.Enabled = false;
            this.pkrCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pkrCheckDate.Location = new System.Drawing.Point(559, 142);
            this.pkrCheckDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pkrCheckDate.Name = "pkrCheckDate";
            this.pkrCheckDate.Size = new System.Drawing.Size(363, 29);
            this.pkrCheckDate.TabIndex = 117;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(411, 148);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 25);
            this.label19.TabIndex = 116;
            this.label19.Text = "Check Date:";
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.Enabled = false;
            this.txtCheckNo.Location = new System.Drawing.Point(160, 142);
            this.txtCheckNo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(219, 29);
            this.txtCheckNo.TabIndex = 114;
            // 
            // CheckNoLabel
            // 
            this.CheckNoLabel.AutoSize = true;
            this.CheckNoLabel.Location = new System.Drawing.Point(9, 148);
            this.CheckNoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CheckNoLabel.Name = "CheckNoLabel";
            this.CheckNoLabel.Size = new System.Drawing.Size(110, 25);
            this.CheckNoLabel.TabIndex = 113;
            this.CheckNoLabel.Text = "Check No.:";
            // 
            // txtRemainingReceivable
            // 
            this.txtRemainingReceivable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainingReceivable.Location = new System.Drawing.Point(458, 990);
            this.txtRemainingReceivable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRemainingReceivable.Name = "txtRemainingReceivable";
            this.txtRemainingReceivable.Size = new System.Drawing.Size(719, 61);
            this.txtRemainingReceivable.TabIndex = 112;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 1006);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(412, 42);
            this.label17.TabIndex = 111;
            this.label17.Text = "Remaining Receivable: ";
            // 
            // txtTotalInvoice
            // 
            this.txtTotalInvoice.Location = new System.Drawing.Point(240, 942);
            this.txtTotalInvoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTotalInvoice.Name = "txtTotalInvoice";
            this.txtTotalInvoice.Size = new System.Drawing.Size(937, 29);
            this.txtTotalInvoice.TabIndex = 110;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 947);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 25);
            this.label16.TabIndex = 109;
            this.label16.Text = "Invoice Total: ";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(240, 894);
            this.txtTotalPayment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(937, 29);
            this.txtTotalPayment.TabIndex = 108;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 899);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 25);
            this.label15.TabIndex = 107;
            this.label15.Text = "Payment Total: ";
            // 
            // SavePayments
            // 
            this.SavePayments.Location = new System.Drawing.Point(1168, 33);
            this.SavePayments.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SavePayments.Name = "SavePayments";
            this.SavePayments.Size = new System.Drawing.Size(220, 42);
            this.SavePayments.TabIndex = 11;
            this.SavePayments.Text = "SAVE PAYMENTS";
            this.SavePayments.UseVisualStyleBackColor = true;
            this.SavePayments.Click += new System.EventHandler(this.SavePayments_Click);
            // 
            // AddPayment
            // 
            this.AddPayment.Location = new System.Drawing.Point(937, 33);
            this.AddPayment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddPayment.Name = "AddPayment";
            this.AddPayment.Size = new System.Drawing.Size(220, 42);
            this.AddPayment.TabIndex = 10;
            this.AddPayment.Text = "ADD PAYMENT";
            this.AddPayment.UseVisualStyleBackColor = true;
            this.AddPayment.Click += new System.EventHandler(this.AddPayment_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(411, 100);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "Remarks:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(411, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "Payment Date:";
            // 
            // txtPaymentRemarks
            // 
            this.txtPaymentRemarks.Location = new System.Drawing.Point(559, 94);
            this.txtPaymentRemarks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPaymentRemarks.Name = "txtPaymentRemarks";
            this.txtPaymentRemarks.Size = new System.Drawing.Size(891, 29);
            this.txtPaymentRemarks.TabIndex = 7;
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.CustomFormat = "MMMM dd, yyyy";
            this.txtPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtPaymentDate.Location = new System.Drawing.Point(559, 39);
            this.txtPaymentDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.Size = new System.Drawing.Size(363, 29);
            this.txtPaymentDate.TabIndex = 6;
            // 
            // dgvPaymentDetails
            // 
            this.dgvPaymentDetails.AllowUserToAddRows = false;
            this.dgvPaymentDetails.AllowUserToDeleteRows = false;
            this.dgvPaymentDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvPaymentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentRemoveRow,
            this.PaymentDate,
            this.PaymentType,
            this.PaymentAmount,
            this.PaymentRemarks});
            this.dgvPaymentDetails.Location = new System.Drawing.Point(15, 190);
            this.dgvPaymentDetails.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvPaymentDetails.Name = "dgvPaymentDetails";
            this.dgvPaymentDetails.ReadOnly = true;
            this.dgvPaymentDetails.RowHeadersVisible = false;
            this.dgvPaymentDetails.Size = new System.Drawing.Size(1439, 692);
            this.dgvPaymentDetails.TabIndex = 5;
            this.dgvPaymentDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentDetails_CellContentClick);
            // 
            // PaymentRemoveRow
            // 
            this.PaymentRemoveRow.FillWeight = 19.18159F;
            this.PaymentRemoveRow.HeaderText = "";
            this.PaymentRemoveRow.Name = "PaymentRemoveRow";
            this.PaymentRemoveRow.ReadOnly = true;
            this.PaymentRemoveRow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentRemoveRow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PaymentRemoveRow.Text = "X";
            this.PaymentRemoveRow.UseColumnTextForButtonValue = true;
            this.PaymentRemoveRow.Width = 30;
            // 
            // PaymentDate
            // 
            this.PaymentDate.FillWeight = 104.2875F;
            this.PaymentDate.HeaderText = "Payment Date";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            this.PaymentDate.Width = 163;
            // 
            // PaymentType
            // 
            this.PaymentType.FillWeight = 144.5649F;
            this.PaymentType.HeaderText = "Payment Type";
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.ReadOnly = true;
            this.PaymentType.Width = 226;
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.FillWeight = 129.0039F;
            this.PaymentAmount.HeaderText = "Amount";
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.ReadOnly = true;
            this.PaymentAmount.Width = 202;
            // 
            // PaymentRemarks
            // 
            this.PaymentRemarks.FillWeight = 102.962F;
            this.PaymentRemarks.HeaderText = "Remarks";
            this.PaymentRemarks.Name = "PaymentRemarks";
            this.PaymentRemarks.ReadOnly = true;
            this.PaymentRemarks.Width = 161;
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.FormattingEnabled = true;
            this.txtPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Tax Certificate"});
            this.txtPaymentType.Location = new System.Drawing.Point(160, 44);
            this.txtPaymentType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(219, 32);
            this.txtPaymentType.TabIndex = 4;
            this.txtPaymentType.SelectedIndexChanged += new System.EventHandler(this.txtPaymentType_SelectedIndexChanged);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(160, 94);
            this.txtPaymentAmount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(219, 29);
            this.txtPaymentAmount.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Amount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Payment Type:";
            // 
            // ViewEditInvoiceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 1159);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ViewEditInvoiceItem";
            this.Text = "View / Edit Invoice Item";
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItems)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddInvoiceItemRow;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.NumericUpDown txtPaymentTerms;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.Label label22;
        internal System.Windows.Forms.TextBox txtInvoiceNumber;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtInvoiceDiscount;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.TextBox txtContactNumber;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.DateTimePicker pkrEntryDate;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button SaveInvoice;
        internal System.Windows.Forms.Button CancelInvoice;
        internal System.Windows.Forms.RichTextBox txtRemarks;
        internal System.Windows.Forms.TextBox txtCustomerName;
        internal System.Windows.Forms.TextBox txtSalesRepresentative;
        internal System.Windows.Forms.TextBox txtBranch;
        internal System.Windows.Forms.DataGridView InvoiceItems;
        internal System.Windows.Forms.ComboBox ddlRecievableStatus;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.DateTimePicker pkrInvoiceDate;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button DeleteInvoice;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionIdColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvPaymentDetails;
        private System.Windows.Forms.ComboBox txtPaymentType;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddPayment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPaymentRemarks;
        private System.Windows.Forms.DateTimePicker txtPaymentDate;
        private System.Windows.Forms.Button SavePayments;
        private System.Windows.Forms.DataGridViewButtonColumn PaymentRemoveRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentRemarks;
        private System.Windows.Forms.TextBox txtRemainingReceivable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalInvoice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker pkrCheckDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCheckNo;
        private System.Windows.Forms.Label CheckNoLabel;
    }
}