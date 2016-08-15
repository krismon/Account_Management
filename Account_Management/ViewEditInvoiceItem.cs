using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Management
{
    public partial class ViewEditInvoiceItem : Form
    {
        private Boolean Looped = false;
        private int InvoiceId;
        private int CustomerId;
        private int PaymentId;
        private int PersonnelId;
        private string UpdatedBy;
        private string AddedBy;
        private DateTime DueDate;
        private DateTime DateUpdated;
        private List<int> AddTransaction = new List<int>();
        private List<int> DeleteTransaction = new List<int>();
        private string UserId;

        public ViewEditInvoiceItem()
        {
            InitializeComponent();
        }
        public ViewEditInvoiceItem(string InvoiceId, string UserId)
        {
            this.InvoiceId = int.Parse(InvoiceId);
            this.UserId = UserId;
            InitializeComponent();
            if(!InitializeData(InvoiceId)){
                DialogResult dialogResult = MessageBox.Show(this, "There was a problem loading the invoice.", "Error", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                InitBoxes();
            }
        }
        private void InitBoxes()
        {
            //Add Invoice
            txtInvoiceDiscount.KeyPress += new KeyPressEventHandler(DecimalOnly_KeyPress);
            txtInvoiceNumber.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);

            //Pay Invoice
            txtPaymentAmount.KeyPress += new KeyPressEventHandler(DecimalOnly_KeyPress);
            
            txtInvoiceNumber.Enabled = false;
            ApplyAutoComplete(txtCustomerName, "NAME", Constants.TableNames.CUSTOMER, false);
            ApplyAutoComplete(txtSalesRepresentative, "NAME", Constants.TableNames.PERSONNEL, false);
            ApplyAutoComplete(txtBranch, "BRANCH", Constants.TableNames.PERSONNEL, false);
            pkrEntryDate.Value = DateTime.Now;
            pkrEntryDate.Enabled = false;

        }
        private void ApplyAutoComplete(TextBox TextBox, string ColumnName, string Table, Boolean IsInt)
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            TextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            TextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            if (IsInt)
            {
                TextBox.AutoCompleteCustomSource = DAO.GetAutoCompleteListForInt(ColumnName, Table);
            }
            else
            {
                TextBox.AutoCompleteCustomSource = DAO.GetAutoCompleteList(ColumnName, Table);
            }

        }
        private void DecimalOnly_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void ClearAddInvoice()
        {
            txtInvoiceNumber.Text = "";
            txtSalesRepresentative.Text = "";
            txtBranch.Text = "";
            txtCustomerName.Text = "";
            txtContactNumber.Text = "";
            txtAddress.Text = "";
            pkrInvoiceDate.Value = DateTime.Now;
            txtPaymentTerms.Value = 1;
            ddlRecievableStatus.Text = "";

            foreach (DataGridViewRow row in InvoiceItems.Rows)
            {
                InvoiceItems.Rows.Clear();
                InvoiceItems.Refresh();
            }
            txtRemarks.Text = "";



        }
        private string ValidateInvoice()
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            string ErrorMessage = "";

            if (txtInvoiceNumber.Text.Length < 1)
            {
                ErrorMessage += "Invoice Number \n";
            }
            //else if (DAO.InvoiceExist(txtInvoiceNumber.Text))
            //{
            //    ErrorMessage += "Invoice Number Exists \n";
            //}
            if (txtSalesRepresentative.Text.Length < 1)
            {
                ErrorMessage += "Sales Representative \n";
            }
            if (txtBranch.Text.Length < 1)
            {
                ErrorMessage += "Branch \n";
            }
            if (txtCustomerName.Text.Length < 1)
            {
                ErrorMessage += "Customer Name \n";
            }
            if (txtContactNumber.Text.Length < 1)
            {
                ErrorMessage += "Contact Number \n";
            }
            if (txtAddress.Text.Length < 1)
            {
                ErrorMessage += "Address \n";
            }
            if (pkrInvoiceDate.Value.ToString().Length < 1)
            {
                ErrorMessage += "Invoice Date \n";
            }
            if (txtPaymentTerms.Value.ToString().Length < 1)
            {
                ErrorMessage += "Payment Terms \n";
            }
            if (ddlRecievableStatus.SelectedItem == null)
            {
                ErrorMessage += "Recievable Status \n";
            }
            else
            {
                if (ddlRecievableStatus.SelectedItem.ToString().Length < 1)
                {
                    ErrorMessage += "Recievable Status \n";
                }
            }
            if (txtInvoiceTotal.Text.Length < 1)
            {
                ErrorMessage += "Total \n";
            }

            foreach (DataGridViewRow Row in InvoiceItems.Rows)
            {
                if (Row.Cells[Constants.RowColumnCodeForAddInvoice.QUANTITY].Value == null ||
                    Row.Cells[Constants.RowColumnCodeForAddInvoice.ITEM_CODE].Value == null ||
                    Row.Cells[Constants.RowColumnCodeForAddInvoice.BRAND].Value == null ||
                    Row.Cells[Constants.RowColumnCodeForAddInvoice.PRICE].Value == null ||
                    Row.Cells[Constants.RowColumnCodeForAddInvoice.AMOUNT].Value == null)
                {
                    if (ErrorMessage.Contains("Row No"))
                    {
                        ErrorMessage += ", " + (Row.Index + 1);
                    }
                    else
                    {
                        ErrorMessage += "Invoice Item Details for Row No. " + (Row.Index + 1);
                    }

                }
            }
            return ErrorMessage;
        }
        public void RecalculateTotals()
        {
            decimal Amount = 0;
            decimal Total = 0;

            decimal Quantity = 0;
            decimal Price = 0;
            decimal Discount = 0;

            foreach (DataGridViewRow Row in InvoiceItems.Rows)
            {
                if (Row.Cells[Constants.RowColumnCodeForAddInvoice.QUANTITY] != null && Row.Cells[Constants.RowColumnCodeForAddInvoice.PRICE] != null && Row.Cells[Constants.RowColumnCodeForAddInvoice.QUANTITY].Value != null && Row.Cells[Constants.RowColumnCodeForAddInvoice.PRICE].Value != null)
                {
                    Amount = 0;
                    if (decimal.TryParse(Row.Cells[Constants.RowColumnCodeForAddInvoice.QUANTITY].Value.ToString(), out Quantity))
                        if (decimal.TryParse(Row.Cells[Constants.RowColumnCodeForAddInvoice.PRICE].Value.ToString(), out Price))
                            if (Row.Cells[4] != null && Row.Cells[Constants.RowColumnCodeForAddInvoice.DISCOUNT].Value != null)
                            {
                                if (decimal.TryParse(Row.Cells[Constants.RowColumnCodeForAddInvoice.DISCOUNT].Value.ToString(), out Discount)) { }
                            }

                    Amount = (Quantity * Price) - Discount;
                    Row.Cells[6].Value = Amount.ToString("#,##0.#0");
                    decimal InvoiceDiscount = 0;
                    decimal.TryParse(txtInvoiceDiscount.Text, out InvoiceDiscount);
                    Total += Amount - InvoiceDiscount;
                }

            }
                txtInvoiceTotal.Text = Total.ToString("#,##0.#0");
        }
        public Boolean InitializeData(string InvoiceId)
        {
            Boolean IsSuccess = true;
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            DataTable dt = DAO.SelectQuery(@"
                                            SELECT
 
                                            INV.INVOICE_ID,
                                            INV.INVOICE_NO,
                                            INVOICE_DATE,
                                            INV.RECEIVABLE_STATUS,
                                            
                                            INV.PERSONNEL_ID,
                                            INV.REMARKS,
                                            INV.DUE_DATE,
                                            INV.DISCOUNT,

                                            INV.ENTRY_DATE,
                                            INV.DATE_UPDATED,
                                            INV.UPDATED_BY,
                                            INV.PAYMENT_TERMS,

                                            INV.ADDED_BY,
                                            INV.AMOUNT,

                                            PER.NAME AS SALES_REPRESENTATIVE,
                                            PER.BRANCH,
                                            CUS.NAME AS CUSTOMER_NAME,
                                            CUS.ADDRESS,
                                            CUS.CONTACT_NO,
                                            CUS.CUSTOMER_ID

                                            FROM RECEIVABLES INV
                                            INNER JOIN PERSONNEL PER ON PER.PERSONNEL_ID = INV.PERSONNEL_ID
                                            INNER JOIN CUSTOMER CUS ON CUS.CUSTOMER_ID = INV.CUSTOMER_ID
                                            WHERE INV.INVOICE_ID = '" + InvoiceId + "'");
            if (dt.Rows.Count < 1)
            {
                IsSuccess = false;
            }
            else
            {
                InvoiceId = dt.Rows[0][0].ToString();
                txtInvoiceNumber.Text = dt.Rows[0][1].ToString();
                pkrInvoiceDate.Value = DateTime.Parse(dt.Rows[0][2].ToString());
                ddlRecievableStatus.Text = GetRecievableStatusDisplay(dt.Rows[0][3].ToString());

                PersonnelId = int.Parse(dt.Rows[0][4].ToString());
                txtRemarks.Text = dt.Rows[0][5].ToString();
                DueDate = DateTime.Parse(dt.Rows[0][6].ToString());
                txtInvoiceDiscount.Text = dt.Rows[0][7].ToString();

                pkrEntryDate.Value = DateTime.Parse(dt.Rows[0][8].ToString());
                DateUpdated = DateTime.Parse(dt.Rows[0][9].ToString());
                UpdatedBy = dt.Rows[0][10].ToString();
                txtPaymentTerms.Value = Int32.Parse(dt.Rows[0][11].ToString());

                AddedBy = dt.Rows[0][12].ToString();
                txtInvoiceTotal.Text = decimal.Parse(dt.Rows[0][13].ToString()).ToString("#,##0.00#");
                txtTotalInvoice.Text = decimal.Parse(dt.Rows[0][13].ToString()).ToString("#,##0.00#");


                txtSalesRepresentative.Text = dt.Rows[0][14].ToString();
                txtBranch.Text = dt.Rows[0][15].ToString();
                txtCustomerName.Text = dt.Rows[0][16].ToString();
                txtAddress.Text = dt.Rows[0][17].ToString();
                txtContactNumber.Text = dt.Rows[0][18].ToString();
                CustomerId = int.Parse(dt.Rows[0][19].ToString());

                DataTable DtItems = DAO.SelectQuery(@"
                                            SELECT

                                            TRA.TRANSACTION_NO,
                                            TRA.PRODUCT_ID,
                                            TRA.QUANTITY,
                                            TRA.DISCOUNT,

                                            PRO.BRAND,
                                            PRO.PRODUCT_CODE,
                                            PRO.UNIT_PRICE

                                            FROM TRANSACTIONS TRA
                                            INNER JOIN PRODUCT PRO ON PRO.PRODUCT_ID = TRA.PRODUCT_ID
                                            WHERE TRA.INVOICE_ID = '" + InvoiceId + "'");

                foreach (DataRow row in DtItems.Rows)
                {
                    string amount = ((decimal.Parse(row[2].ToString()) * decimal.Parse(row[6].ToString())) - decimal.Parse(row[3].ToString())).ToString("#,##0.00#");
                    
                    InvoiceItems.Rows.Add(
                        null,
                        int.Parse(row[2].ToString()),
                        row[5].ToString(),
                        row[4].ToString(),
                        row[6].ToString(),
                        row[3].ToString(),
                        amount,
                        row[0].ToString()
                        );
                }

                DataTable PaymentItems = DAO.SelectQuery(@"
                                            SELECT 

                                            PAY.INVOICE_NO,
                                            PAY.PAYMENT_DATE,
                                            PAY.PAYMENT_TYPE,
                                            PAY.REMARKS,
                                            PAY.AMOUNT,
                                            PAY.CHECK_NO,
                                            PAY.CHECK_DATE
                                            FROM PAYMENTS PAY
                                            INNER JOIN RECEIVABLES INV ON INV.INVOICE_NO = PAY.INVOICE_NO 
                                                                      AND PAY.INVOICE_NO = '" + txtInvoiceNumber.Text + "'");
                
                foreach (DataRow row in PaymentItems.Rows)
                {
                    string amount = decimal.Parse(row[4].ToString()).ToString("#,##0.00#");
                    string CheckDetails = "";
                    if (!String.IsNullOrEmpty(row[5].ToString()))
                    {
                        CheckDetails = " - " + row[5].ToString() + " - " + DateTime.Parse(row[6].ToString()).ToString("MMMM dd, yyyy");
                    }
                    
                    dgvPaymentDetails.Rows.Add(
                        null,
                        DateTime.Parse(row[1].ToString()).ToString("MMMM dd, yyyy"),
                        GetPaymentTypeDisplay(row[2].ToString()) + CheckDetails,
                        amount,
                        row[3].ToString()
                        );
                }
                RecalculatePayments();

            }
            return IsSuccess;
        }

        private void CancelInvoice_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetRecievableStatusDisplay(string Status)
        {

            int FormattedStatus = int.Parse(Status);
            if (FormattedStatus == Constants.RecievableStatusCode.FULLY_PAID)
            {
                return Constants.RecievableStatusDisplay.FULLY_PAID;
            }
            else if (FormattedStatus == Constants.RecievableStatusCode.PARTIALLY_PAID)
            {
                return Constants.RecievableStatusDisplay.PARTIALLY_PAID;
            }
            else
            {
                return Constants.RecievableStatusDisplay.UNPAID;
            }
        }

        private string GetPaymentTypeDisplay(string Type)
        {

            int FormattedType = int.Parse(Type);
            if (FormattedType == Constants.PaymentTypeCode.CASH)
            {
                return Constants.PaymentTypeDisplay.CASH;
            }
            else if (FormattedType == Constants.PaymentTypeCode.CHECK)
            {
                return Constants.PaymentTypeDisplay.CHECK;
            }
            else
            {
                return Constants.PaymentTypeDisplay.TAX_CERTIFICATE;
            }
        }

        private int GetRecievableStatusCode(string Status)
        {
            string FormattedStatus = Status.ToUpper();
            if (FormattedStatus.Equals(Constants.RecievableStatusDisplay.FULLY_PAID.ToUpper()))
            {
                return Constants.RecievableStatusCode.FULLY_PAID;
            }
            else if (FormattedStatus.Equals(Constants.RecievableStatusDisplay.PARTIALLY_PAID.ToUpper()))
            {
                return Constants.RecievableStatusCode.PARTIALLY_PAID;
            }
            else
            {
                return Constants.RecievableStatusCode.UNPAID;
            }
        }
        private int GetPaymentTypeCode(string Type)
        {
            string FormattedType = Type.ToUpper();
            if (FormattedType.Equals(Constants.PaymentTypeDisplay.CASH.ToUpper()))
            {
                return Constants.PaymentTypeCode.CASH;
            }
            else if (FormattedType.Equals(Constants.PaymentTypeDisplay.CHECK.ToUpper()))
            {
                return Constants.PaymentTypeCode.CHECK;
            }
            else
            {
                return Constants.PaymentTypeCode.TAX_CERTIFICATE;
            }
        }

        private void SaveInvoice_Click(object sender, EventArgs e)
        {
            SaveInvoiceFunction();
        }

        private void DeleteInvoice_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to delete the invoice?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                AccountsRecievableDao DAO = new AccountsRecievableDao();
                foreach(DataGridViewRow row in InvoiceItems.Rows)
                {
                    if (row.Cells[7].Value != null)
                    {
                        //DAO.DeleteQuery(Constants.TableNames.TRANSACTIONS, row.Cells[7].Value.ToString());
                        DAO.ExecuteSQL("DELETE FROM TRANSACTIONS WHERE TRANSACTION_NO = " + row.Cells[7].Value.ToString());
                    }
                }
                DAO.ExecuteSQL("DELETE FROM RECEIVABLES WHERE INVOICE_ID = " + InvoiceId.ToString());
                this.Close();
                //DAO.DeleteQuery(Constants.TableNames.RECEIVABLES, InvoiceId.ToString());
            }
        }

        private void InvoiceItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(NumberOnly_KeyPress);
            e.Control.KeyPress -= new KeyPressEventHandler(DecimalOnly_KeyPress);

            if (InvoiceItems.CurrentCell.ColumnIndex == Constants.RowColumnCodeForAddInvoice.QUANTITY)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);
                }
            }
            else if (InvoiceItems.CurrentCell.ColumnIndex == Constants.RowColumnCodeForAddInvoice.PRICE)
            {

                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(DecimalOnly_KeyPress);
                }
            }
            else if (InvoiceItems.CurrentCell.ColumnIndex == Constants.RowColumnCodeForAddInvoice.ITEM_CODE)
            {
                TextBox ProductCode = e.Control as TextBox;
                if (ProductCode != null)
                {
                    ApplyAutoComplete(ProductCode, "Product_Code", Constants.TableNames.PRODUCT, false);
                }
            }
            else if (InvoiceItems.CurrentCell.ColumnIndex == Constants.RowColumnCodeForAddInvoice.BRAND)
            {
                TextBox ProductBrand = e.Control as TextBox;
                if (ProductBrand != null)
                {
                    ApplyAutoComplete(ProductBrand, "Brand", Constants.TableNames.PRODUCT, false);
                }
            }
            else
            {
                TextBox prodCode = e.Control as TextBox;
                if (prodCode != null)
                {
                    prodCode.AutoCompleteMode = AutoCompleteMode.None;
                }
            }
        }

        private void InvoiceItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                RecalculateTotals();
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            Dictionary<string, string> CustomerDetails = DAO.GetCustomerDetails(txtCustomerName.Text.ToString().Trim());
            if (CustomerDetails.Count > 0)
            {
                txtAddress.Text = CustomerDetails["ADDRESS"];
                txtContactNumber.Text = CustomerDetails["CONTACT_NO"];
                CustomerId =  int.Parse(CustomerDetails["CUSTOMER_ID"]);
            }
        }

        private void txtSalesRepresentative_TextChanged(object sender, EventArgs e)
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            Dictionary<string, string> PersonnelDetails = DAO.GetPersonelDetails(txtSalesRepresentative.Text.ToString().Trim());
            if (PersonnelDetails.Count > 0)
            {
                txtBranch.Text = PersonnelDetails["BRANCH"];
                PersonnelId = int.Parse(PersonnelDetails["PERSONNEL_ID"]);
            }
        }

        private void AddInvoiceItemRow_Click(object sender, EventArgs e)
        {
            InvoiceItems.Rows.Add();
        }

        private void InvoiceItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string ItemCode = InvoiceItems.Rows[e.RowIndex].Cells[Constants.RowColumnCodeForAddInvoice.ITEM_CODE].Value == null ?
                    "(empty)" : InvoiceItems.Rows[e.RowIndex].Cells[Constants.RowColumnCodeForAddInvoice.ITEM_CODE].Value.ToString();

                DialogResult dialogResult = MessageBox.Show(this, "Are you sure you want to remove: \n" + ItemCode, "Message", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (InvoiceItems.Rows[e.RowIndex].Cells[7].Value != null)
                    {
                        DeleteTransaction.Add(int.Parse(InvoiceItems.Rows[e.RowIndex].Cells[7].Value.ToString()));
                    }
                    InvoiceItems.Rows.Remove(InvoiceItems.Rows[e.RowIndex]);
                    RecalculateTotals();
                }
            }
        }

        private void SaveInvoiceFunction()
        {
            string ErrorMessage = "";
            ErrorMessage = ValidateInvoice();
            if (ErrorMessage.Length > 0)
            {
                MessageBox.Show("Incomplete / Invalid Invoice Details: \n" + ErrorMessage);
            }
            else 
            {
                AccountsRecievableDao DAO = new AccountsRecievableDao();
                if (!DAO.CustomerExist(txtCustomerName.Text))
                {
                    CustomerId = DAO.InsertCustomer(
                        txtCustomerName.Text.ToString().Trim(),
                        txtAddress.Text.ToString().Trim(),
                        Convert.ToInt32(txtContactNumber.Text.ToString().Trim())
                        );
                }
                else
                {
                    var CustomerDetails = new Dictionary<string, object>();
                    CustomerDetails["ADDRESS"] = txtAddress.Text;
                    CustomerDetails["CONTACT_NO"] = txtContactNumber.Text;

                    DAO.UpdateQuery(Constants.TableNames.CUSTOMER, CustomerDetails, "CUSTOMER_ID", CustomerId.ToString());
                }
                if (!DAO.PersonnelExist(txtSalesRepresentative.Text))
                {
                    PersonnelId = DAO.InsertPersonnel(
                       txtSalesRepresentative.Text.ToString().Trim(),
                       txtBranch.Text.ToString().Trim()
                       );
                }
                else
                {
                    var PersonnelDetails = new Dictionary<string, object>();
                    PersonnelDetails["BRANCH"] = txtBranch.Text;

                    DAO.UpdateQuery(Constants.TableNames.PERSONNEL, PersonnelDetails, "PERSONNEL_ID", PersonnelId.ToString());
                }
                //update invoice
                var InvoiceDetails = new Dictionary<string, object>();
                InvoiceDetails["ENTRY_DATE"] = pkrEntryDate.Value;
                InvoiceDetails["INVOICE_DATE"] = pkrInvoiceDate.Value;
                InvoiceDetails["PAYMENT_TERMS"] = txtPaymentTerms.Value;
                InvoiceDetails["RECEIVABLE_STATUS"] = GetRecievableStatusCode(ddlRecievableStatus.SelectedItem.ToString());
                InvoiceDetails["DISCOUNT"] = txtInvoiceDiscount.Text;
                InvoiceDetails["DUE_DATE"] = pkrInvoiceDate.Value.AddDays(int.Parse(txtPaymentTerms.Value.ToString()));
                InvoiceDetails["REMARKS"] = txtRemarks.Text;
                InvoiceDetails["AMOUNT"] = txtInvoiceTotal.Text.Replace(",","");
                InvoiceDetails["PERSONNEL_ID"] = PersonnelId;
                InvoiceDetails["CUSTOMER_ID"] = CustomerId;
                InvoiceDetails["DATE_UPDATED"] = DateTime.Now;
                InvoiceDetails["UPDATED_BY"] = DAO.GetUserId(UserId);

                DAO.UpdateQuery(Constants.TableNames.RECEIVABLES, InvoiceDetails, "INVOICE_NO", txtInvoiceNumber.Text);
                
                //update transactions
                DAO.ExecuteSQL("DELETE FROM " + Constants.TableNames.TRANSACTIONS + " WHERE INVOICE_ID = '" +InvoiceId.ToString()+ "'");
                int InvoiceDiscount = 0;
                int ProductId = 0;
                int InvoiceItemDiscount = 0;
                int.TryParse(txtInvoiceDiscount.Text, out InvoiceDiscount);
                foreach (DataGridViewRow Row in InvoiceItems.Rows)
                {
                    InvoiceDiscount = 0;
                    if (Row.Cells[Constants.RowColumnCodeForAddInvoice.DISCOUNT].Value != null)
                    {
                        int.TryParse(Row.Cells[Constants.RowColumnCodeForAddInvoice.DISCOUNT].Value.ToString().Trim(), out InvoiceDiscount);
                    }
                    if (Row.Cells[1].Value != null)
                    {
                        if (!DAO.ItemExist(Row.Cells[Constants.RowColumnCodeForAddInvoice.ITEM_CODE].Value.ToString().Trim(), Convert.ToDecimal(Row.Cells[Constants.RowColumnCodeForAddInvoice.PRICE].Value.ToString().Trim())))
                        {
                            ProductId = DAO.InsertItem(Row.Cells[Constants.RowColumnCodeForAddInvoice.ITEM_CODE].Value.ToString().Trim(),
                                Row.Cells[Constants.RowColumnCodeForAddInvoice.BRAND].Value.ToString().Trim(),
                                Convert.ToDecimal(Row.Cells[Constants.RowColumnCodeForAddInvoice.PRICE].Value.ToString().Trim()));
                        }
                        else
                        {
                            ProductId = Convert.ToInt32(DAO.SelectQuery("SELECT PRODUCT_ID FROM " + Constants.TableNames.PRODUCT + " WHERE PRODUCT_CODE ='" + Row.Cells[Constants.RowColumnCodeForAddInvoice.ITEM_CODE].Value.ToString().Trim() + "'").Rows[0][0].ToString());
                        }
                        DAO.InsertTransaction(InvoiceId, ProductId, Convert.ToInt32(Row.Cells[Constants.RowColumnCodeForAddInvoice.QUANTITY].Value.ToString().Trim()), InvoiceDiscount);
                    }

                }
                MessageBox.Show(this, "Invoice Saved.", "Success", MessageBoxButtons.OK);
                this.Close();
            }
            
        }

        private void AddPayment_Click(object sender, EventArgs e)
        {
            bool Valid = true;
            string ErrorMessage = "";

            if (txtPaymentType.SelectedItem == null)
            {
                Valid = false;
                ErrorMessage += "No Payment Type Selected. \n";
            }
            else if (txtPaymentAmount.Text.Length <= 0)
            {
                Valid = false;
                ErrorMessage += "The Amount cannot be empty. \n";
            }
            
            else if (txtPaymentType.SelectedItem.ToString().Equals(Constants.PaymentTypeDisplay.CHECK))
            {
                if (txtCheckNo.Text.Length <= 0)
                {
                    Valid = false;
                    ErrorMessage += "The Check No. cannot be empty. \n";
                }
            }
            if (decimal.Parse(txtRemainingReceivable.Text) <= 0m)
            {
                Valid = false;
                ErrorMessage += "Cannot add anymore payments when the remaining balance is 0 or less. \n";
            }

            if (Valid)
            {
                dgvPaymentDetails.Rows.Add(
                null,
                txtPaymentDate.Text,
                txtPaymentType.SelectedItem.ToString().Equals(Constants.PaymentTypeDisplay.CHECK) ? txtPaymentType.SelectedItem.ToString() + " - " + txtCheckNo.Text + " - " + pkrCheckDate.Value.ToString("MMMM dd, yyyy") : txtPaymentType.SelectedItem.ToString(),
                txtPaymentAmount.Text,
                txtPaymentRemarks.Text
                );
                RecalculatePayments();

                txtPaymentDate.Value = DateTime.Now;
                txtPaymentType.Text = "";
                txtPaymentAmount.Text = "";
                txtPaymentRemarks.Text = "";
                txtCheckNo.Text = "";
                pkrCheckDate.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show(ErrorMessage);
            }
            
        }

        private void dgvPaymentDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string PaymentType = dgvPaymentDetails.Rows[e.RowIndex].Cells[2].Value == null ?
                    "(empty)" : dgvPaymentDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                string PaymentAmount = dgvPaymentDetails.Rows[e.RowIndex].Cells[3].Value == null ?
                    "(empty)" : dgvPaymentDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
                string PaymentDate = dgvPaymentDetails.Rows[e.RowIndex].Cells[1].Value == null ?
                    "(empty)" : dgvPaymentDetails.Rows[e.RowIndex].Cells[1].Value.ToString();

                DialogResult dialogResult = MessageBox.Show(this, "Are you sure you want to remove: \nType: " + PaymentType + "\nAmount: " + PaymentAmount + "\nDate: " + PaymentDate, "Message", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dgvPaymentDetails.Rows.Remove(dgvPaymentDetails.Rows[e.RowIndex]);
                    RecalculatePayments();
                }
            }
        }

        private void SavePayments_Click(object sender, EventArgs e)
        {
            
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            string InvoiceTotal = txtInvoiceTotal.Text.Replace(",", "");
            decimal PaymentTotal = 0;
            foreach (DataGridViewRow row in dgvPaymentDetails.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    PaymentTotal += decimal.Parse(row.Cells[3].Value.ToString());
                }
            }
            if (PaymentTotal >= decimal.Parse(InvoiceTotal))
            {
                ddlRecievableStatus.Text = Constants.RecievableStatusDisplay.FULLY_PAID;
                DAO.ExecuteSQL("UPDATE "+Constants.TableNames.RECEIVABLES+" SET RECEIVABLE_STATUS='" + Constants.RecievableStatusCode.FULLY_PAID + "' WHERE INVOICE_ID = '" + InvoiceId + "'");

            }
            else if (PaymentTotal > 0)
            {
                ddlRecievableStatus.Text = Constants.RecievableStatusDisplay.PARTIALLY_PAID;
                DAO.ExecuteSQL("UPDATE "+Constants.TableNames.RECEIVABLES+" SET RECEIVABLE_STATUS='" + Constants.RecievableStatusCode.PARTIALLY_PAID + "' WHERE INVOICE_ID = '" + InvoiceId + "'");
            }
            else
            {
                ddlRecievableStatus.Text = Constants.RecievableStatusDisplay.UNPAID;
                DAO.ExecuteSQL("UPDATE "+Constants.TableNames.RECEIVABLES+" SET RECEIVABLE_STATUS='" + Constants.RecievableStatusCode.UNPAID + "' WHERE INVOICE_ID = '" + InvoiceId + "'");
            }

            DAO.ExecuteSQL("DELETE FROM " + Constants.TableNames.PAYMENTS + " WHERE INVOICE_NO='" + txtInvoiceNumber.Text + "'");
            foreach (DataGridViewRow row in dgvPaymentDetails.Rows)
            {

                string[] PaymentTypeExtract = row.Cells[2].Value.ToString().Split('-');
                int PaymentType = GetPaymentTypeCode(PaymentTypeExtract[0].Trim());
                string CheckNo = "";
                string CheckDate = "";

                if (PaymentType == Constants.PaymentTypeCode.CHECK)
                {
                    CheckNo = PaymentTypeExtract[1].Trim();
                    CheckDate = PaymentTypeExtract[2].Trim();
                }


                PaymentId = DAO.InsertPayment(int.Parse(txtInvoiceNumber.Text)
                    ,DateTime.Parse( row.Cells[1].Value.ToString())
                    , PaymentType
                    ,int.Parse(UserId)
                    ,DateTime.Now
                    ,int.Parse(UserId)
                    ,row.Cells[4].Value.ToString().Replace(",","")
                    ,DateTime.Now
                    ,decimal.Parse(row.Cells[3].Value.ToString().Replace(",","")),
                    CheckNo,
                    String.IsNullOrEmpty(CheckDate) ? DateTime.MinValue : DateTime.ParseExact(CheckDate, "MMMM dd, yyyy", CultureInfo.InvariantCulture)
                    );
            }
            MessageBox.Show("Payment Successfully Saved.");
        }
        private void RecalculatePayments()
        {
            decimal TotalPayments = 0;
            foreach (DataGridViewRow row in dgvPaymentDetails.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    TotalPayments += decimal.Parse(row.Cells[3].Value.ToString());
                }
            }

            decimal TotalReceivable = 0;
            decimal.TryParse(txtInvoiceTotal.Text, out TotalReceivable);

            decimal RemainingReceivable = TotalReceivable - TotalPayments;

            txtTotalInvoice.Text = TotalReceivable.ToString("#,##0.00#");
            txtTotalPayment.Text = TotalPayments.ToString("#,##0.00#");
            txtRemainingReceivable.Text = RemainingReceivable.ToString("#,##0.00#");
        }

        private void txtInvoiceDiscount_TextChanged(object sender, EventArgs e)
        {
            RecalculateTotals();
            RecalculatePayments();
        }

        private void txtPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPaymentType.SelectedItem.ToString().Equals(Constants.PaymentTypeDisplay.CHECK))
            {
                txtCheckNo.Enabled = true;
                pkrCheckDate.Enabled = true;
            }
            else
            {
                txtCheckNo.Enabled = false;
                pkrCheckDate.Enabled = false;
            }
        }
    }
}
