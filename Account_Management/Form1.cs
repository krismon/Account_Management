using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            DAO.InitTables();
            DisplayTables();
            InitBoxes();

            tabTableViewer.Hide();
        }

        #region Form Functions
        private void InitBoxes()
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            //Add Invoice
            ApplyAutoComplete(txtCustomerName, "NAME", Constants.TableNames.CUSTOMER, false);
            ApplyAutoComplete(txtSalesRepresentative, "NAME", Constants.TableNames.PERSONNEL, false);
            ApplyAutoComplete(txtBranch, "BRANCH", Constants.TableNames.PERSONNEL, false);

            //Search Invoice
            ApplyAutoComplete(txtSearchInvoiceNumber, "INVOICE_NO", Constants.TableNames.RECEIVABLES, true);
            ApplyAutoComplete(txtSearchCustomerName, "NAME", Constants.TableNames.CUSTOMER, false);
            ApplyAutoComplete(txtSearchPersonnel, "NAME", Constants.TableNames.PERSONNEL, false);

            ddlUserList.Items.Add("");
            FillComboBox(DAO.GetUsers(), ddlUserList);

            pkrEntryDate.Value = DateTime.Now;
            pkrEntryDate.Enabled = false;

            txtInvoiceDiscount.KeyPress += new KeyPressEventHandler(DecimalOnly_KeyPress);
            txtInvoiceNumber.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);

        }
        private void FillComboBox(List<string> ListItems, ComboBox cBox)
        {
            foreach (string item in ListItems)
            {
                cBox.Items.Add(item);    
            }
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
        private void DisplayTables()
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            dgvCustomer.DataSource = DAO.SelectQuery("SELECT * from " + Constants.TableNames.CUSTOMER);
            dgvProducts.DataSource = DAO.SelectQuery("SELECT * from " + Constants.TableNames.PRODUCT);
            dgvPersonnel.DataSource = DAO.SelectQuery("SELECT * from " + Constants.TableNames.PERSONNEL);
            dgvRecievables.DataSource = DAO.SelectQuery("SELECT * from " + Constants.TableNames.RECEIVABLES);
            dgvTransactions.DataSource = DAO.SelectQuery("SELECT * from " + Constants.TableNames.TRANSACTIONS);
            dgvPayments.DataSource = DAO.SelectQuery("SELECT * from " + Constants.TableNames.PAYMENTS);
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
            txtInvoiceTotal.Text = "0.00";

            foreach (DataGridViewRow row in InvoiceItems.Rows)
            {
                InvoiceItems.Rows.Clear();
                InvoiceItems.Refresh();
            }
            txtRemarks.Text = "";



        }
        #endregion

        #region Add Invoice Functions

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
        private int GetPaymentTypeCode(string Type)
        {
            string FormattedType = Type.ToUpper();
            if (FormattedType.Equals(Constants.PaymentTypeDisplay.TAX_CERTIFICATE.ToUpper()))
            {
                return Constants.PaymentTypeCode.TAX_CERTIFICATE;
            }
            else if (FormattedType.Equals(Constants.PaymentTypeDisplay.CHECK.ToUpper()))
            {
                return Constants.PaymentTypeCode.CHECK;
            }
            else
            {
                return Constants.PaymentTypeCode.CASH;
            }
        }
        private string ValidateInvoice()
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            string ErrorMessage = "";

            if (txtInvoiceNumber.Text.Length < 1)
            {
                ErrorMessage += "Invoice Number \n";
            }
            else if (DAO.InvoiceExist(txtInvoiceNumber.Text))
            {
                ErrorMessage += "Invoice Number Exists \n";
            }
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
                    Row.Cells[Constants.RowColumnCodeForAddInvoice.AMOUNT].Value = Amount.ToString("#,##0.#0");
                    decimal InvoiceDiscount = 0;
                    decimal.TryParse(txtInvoiceDiscount.Text, out InvoiceDiscount);
                    Total += Amount - InvoiceDiscount;
                }

            }
            txtInvoiceTotal.Text = Total.ToString("#,##0.#0");
        }

        #endregion

        #region Search Invoice Functions

        public void RunCheckBoxBehavior()
        {
            if (chkDueFrom.Checked)
            {
                pkrInvoiceDueFrom.Enabled = true;
            }
            else
            {
                pkrInvoiceDueFrom.Enabled = false;
            }
            if (chkDueTo.Checked)
            {
                pkrInvoiceDueTo.Enabled = true;
            }
            else
            {
                pkrInvoiceDueTo.Enabled = false;
            }
            if (chkEntryFrom.Checked)
            {
                pkrSearchInvoiceFrom.Enabled = true;
            }
            else
            {
                pkrSearchInvoiceFrom.Enabled = false;
            }
            if (chkEntryTo.Checked)
            {
                pkrSearchInvoiceTo.Enabled = true;
            }
            else
            {
                pkrSearchInvoiceTo.Enabled = false;
            }
            if (chkDueToday.Checked)
            {
                pkrInvoiceDueFrom.Enabled = false;
                pkrInvoiceDueTo.Enabled = false;
                chkDueFrom.Checked = false;
                chkDueTo.Checked = false;
            }

        }

        #endregion

        #region Functions



        #endregion

        #region Add Invoice
        private void ResetAddInvoice_Click(object sender, EventArgs e)
        {
            ClearAddInvoice();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow Row in InvoiceItems.Rows)
            int ProductId = 0;
            int CustomerId = 0;
            int InvoiceId = 0;
            int PersonnelId = 0;
            string ErrorMessage = ValidateInvoice();
            if (ErrorMessage.Length > 0)
            {
                MessageBox.Show("Incomplete / Invalid Invoice Details: \n" + ErrorMessage);
            }
            else
            {
                AccountsRecievableDao DAO = new AccountsRecievableDao();
                if (!DAO.CustomerExist(txtCustomerName.Text.ToString().Trim()))
                {
                    CustomerId = DAO.InsertCustomer(
                        txtCustomerName.Text.ToString().Trim(),
                        txtAddress.Text.ToString().Trim(),
                        Convert.ToInt32(txtContactNumber.Text.ToString().Trim())
                        );
                }
                else
                {
                    CustomerId = Convert.ToInt32(DAO.SelectQuery("SELECT CUSTOMER_ID FROM " + Constants.TableNames.CUSTOMER + " WHERE NAME ='" + txtCustomerName.Text.ToString().Trim() + "'").Rows[0][0].ToString());
                    var dicData = new Dictionary<string, object>();
                    dicData["ADDRESS"] = txtAddress.Text;
                    dicData["CONTACT_NO"] = txtContactNumber.Text;

                    DAO.UpdateQuery(Constants.TableNames.CUSTOMER, dicData, "CUSTOMER_ID", CustomerId.ToString());
                }
                if (!DAO.PersonnelExist(txtSalesRepresentative.Text.ToString().Trim()))
                {
                    PersonnelId = DAO.InsertPersonnel(
                       txtSalesRepresentative.Text.ToString().Trim(),
                       txtBranch.Text.ToString().Trim()
                       );
                }
                else
                {
                    PersonnelId = Convert.ToInt32(DAO.SelectQuery("SELECT PERSONNEL_ID FROM " + Constants.TableNames.PERSONNEL + " WHERE NAME ='" + txtSalesRepresentative.Text.ToString().Trim() + "'").Rows[0][0].ToString());
                    var dicData = new Dictionary<string, object>();
                    dicData["BRANCH"] = txtBranch.Text;

                    DAO.UpdateQuery(Constants.TableNames.PERSONNEL, dicData, "PERSONNEL_ID", PersonnelId.ToString());
                }
                if (!DAO.ItemExist(txtInvoiceNumber.Text.ToString()))
                {
                    int InvoiceDiscount = 0;
                    int InvoiceItemDiscount = 0;
                    int.TryParse(txtInvoiceDiscount.Text, out InvoiceDiscount);

                    InvoiceId = DAO.InsertInvoice(
                        txtRemarks.Text.ToString().Trim(),
                        DAO.GetUserId(ddlUserList.SelectedItem.ToString()),
                        null,
                        Convert.ToInt32(txtInvoiceNumber.Text.ToString().Trim()),
                        CustomerId,
                        GetRecievableStatusCode(ddlRecievableStatus.SelectedItem.ToString().Trim()),
                        PersonnelId,
                        InvoiceDiscount,
                        Convert.ToInt32(txtPaymentTerms.Value),
                        Convert.ToDecimal(txtInvoiceTotal.Text.ToString().Replace(",","").Trim()),
                        pkrInvoiceDate.Value,
                        pkrInvoiceDate.Value.AddDays(Convert.ToInt32(txtPaymentTerms.Value)),
                        pkrEntryDate.Value,
                        DateTime.Now
                        );
                    foreach (DataGridViewRow Row in InvoiceItems.Rows)
                    {
                        InvoiceDiscount = 0;
                        if (Row.Cells[Constants.RowColumnCodeForAddInvoice.DISCOUNT].Value != null)
                        {
                            int.TryParse(Row.Cells[Constants.RowColumnCodeForAddInvoice.DISCOUNT].Value.ToString().Trim(), out InvoiceDiscount);
                        }
                        if (Row.Cells[1].Value != null)
                        {
                            if (!DAO.ItemExist(Row.Cells[Constants.RowColumnCodeForAddInvoice.ITEM_CODE].Value.ToString().Trim()))
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
                    if (InvoiceId != null){
                        MessageBox.Show("Invoice Successfully Saved.\n Invoice No.: " + txtInvoiceNumber.Text);
                        ClearAddInvoice();
                        InitBoxes();
                    }
                    else
                    {
                        MessageBox.Show("An error occured while saving the invoice.");
                    }
                }
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
            }

        }
        private void txtSalesRepresentative_TextChanged(object sender, EventArgs e)
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            Dictionary<string, string> PersonnelDetails = DAO.GetPersonelDetails(txtSalesRepresentative.Text.ToString().Trim());
            if (PersonnelDetails.Count > 0)
            {
                txtBranch.Text = PersonnelDetails["BRANCH"];
            }
        }
        private void AddInvoiceItemRow_Click(object sender, EventArgs e)
        {
            InvoiceItems.Rows.Add(null,null,null,null,null,null,null);
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
                    InvoiceItems.Rows.Remove(InvoiceItems.Rows[e.RowIndex]);
                    RecalculateTotals();
                }
            }
        }

        #endregion

        #region Search Invoice
        private void chkEntryFrom_CheckedChanged(object sender, EventArgs e)
        {
            RunCheckBoxBehavior();
        }
        private void chkEntryTo_CheckedChanged(object sender, EventArgs e)
        {
            RunCheckBoxBehavior();
        }
        private void chkDueFrom_CheckedChanged(object sender, EventArgs e)
        {
            RunCheckBoxBehavior();
        }
        private void chkDueTo_CheckedChanged(object sender, EventArgs e)
        {
            RunCheckBoxBehavior();
        }
        private void chkDueToday_CheckedChanged(object sender, EventArgs e)
        {
            RunCheckBoxBehavior();
        }
        private void EditRec_Reset_Click(object sender, EventArgs e)
        {
            dgvSearchInvoice.Rows.Clear();
            dgvSearchInvoice.Refresh();
            ClearSearchInvoiceFields();
        }
        private void EditRec_Search_Click(object sender, EventArgs e)
        {
            dgvSearchInvoice.Rows.Clear();
            dgvSearchInvoice.Refresh();
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            string WhereClause = "";
            if (txtSearchCustomerName.Text.Length > 0)
            {
                WhereClause += "AND CUS.NAME='" + txtSearchCustomerName.Text.ToString() + "'";
            }
            if (txtSearchInvoiceNumber.Text.Length > 0)
            {
                WhereClause += "AND REC.INVOICE_NO='" + txtSearchInvoiceNumber.Text.ToString() + "'";
            }
            if (txtSearchPersonnel.Text.Length > 0)
            {
                WhereClause += "AND PER.NAME='" + txtSearchPersonnel.Text.ToString() + "'";
            }
            if (pkrSearchInvoiceFrom.Enabled && pkrSearchInvoiceTo.Enabled)
            {
                WhereClause += "AND date(REC.ENTRY_DATE) BETWEEN date('" + pkrSearchInvoiceFrom.Value.ToString("yyyy-MM-dd") + "') AND date('" + pkrSearchInvoiceTo.Value.ToString("yyyy-MM-dd") + "')";
            }
            else if (pkrSearchInvoiceFrom.Enabled && !pkrSearchInvoiceTo.Enabled)
            {
                WhereClause += "AND date(REC.ENTRY_DATE) >= date('" + pkrSearchInvoiceFrom.Value.ToString("yyyy-MM-dd") + "')";
            }
            else if (!pkrSearchInvoiceFrom.Enabled && pkrSearchInvoiceTo.Enabled)
            {
                WhereClause += "AND date(REC.ENTRY_DATE) <= date('" + pkrSearchInvoiceTo.Value.ToString("yyyy-MM-dd") + "')";
            }
            if (chkDueToday.Checked)
            {
                WhereClause += "AND date(REC.DUE_DATE) = date('now')";
            }
            else if (pkrInvoiceDueFrom.Enabled && pkrInvoiceDueTo.Enabled)
            {
                WhereClause += "AND date(REC.DUE_DATE) BETWEEN date('" + pkrInvoiceDueFrom.Value.ToString("yyyy-MM-dd") + "') AND date('" + pkrInvoiceDueTo.Value.ToString("yyyy-MM-dd") + "')";
            }
            else if (pkrInvoiceDueFrom.Enabled && !pkrInvoiceDueTo.Enabled)
            {
                WhereClause += "AND date(REC.DUE_DATE) >= date('" + pkrInvoiceDueFrom.Value.ToString("yyyy-MM-dd") + "')";
            }
            else if (!pkrInvoiceDueFrom.Enabled && pkrInvoiceDueTo.Enabled)
            {
                WhereClause += "AND date(REC.DUE_DATE) <= date('" + pkrInvoiceDueTo.Value.ToString("yyyy-MM-dd") + "')";
            }
            if (chkUnpaidInvoice.Checked && chkPartiallyPaid.Checked)
            {
                WhereClause += "AND (REC.RECEIVABLE_STATUS = '" + Constants.RecievableStatusCode.FULLY_PAID + "' OR REC.RECEIVABLE_STATUS = '" + Constants.RecievableStatusCode.PARTIALLY_PAID + "')";
            }
            else if (chkPartiallyPaid.Checked)
            {
                WhereClause += "AND REC.RECEIVABLE_STATUS = '" + Constants.RecievableStatusCode.PARTIALLY_PAID + "'";
            }
            else if (chkUnpaidInvoice.Checked)
            {
                WhereClause += "AND REC.RECEIVABLE_STATUS = '" + Constants.RecievableStatusCode.UNPAID + "'";
            }
            if (WhereClause.Length > 0)
            {
                WhereClause = "WHERE " + WhereClause.Substring(3);
            }


            DataTable dt = DAO.SelectQuery(
                "SELECT REC.INVOICE_NO, CUS.NAME AS 'CUSTOMER NAME',PER.NAME AS 'SALES REPRESENTATIVE', REC.ENTRY_DATE, REC.DUE_DATE, REC.INVOICE_ID FROM RECEIVABLES REC INNER JOIN CUSTOMER CUS ON CUS.CUSTOMER_ID = REC.CUSTOMER_ID INNER JOIN PERSONNEL PER ON PER.PERSONNEL_ID = REC.PERSONNEL_ID "
                 + WhereClause
                );


            foreach (DataRow row in dt.Rows)
            {
                dgvSearchInvoice.Rows.Add(
                    row[0].ToString(),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    null,
                    row[5].ToString()
                );
            }
            dt.Clear();
        }

        #endregion

        #region Table Display
        private void btnRefreshTables_Click(object sender, EventArgs e)
        {
            DisplayTables();
        }
        #endregion

        private void dgvSearchInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == Constants.RowColumnCodeForSearchInvoice.EDIT)
            {
                ViewEditInvoiceItem InvoiceDialog = new ViewEditInvoiceItem(dgvSearchInvoice.Rows[e.RowIndex].Cells[Constants.RowColumnCodeForSearchInvoice.INVOICE_ID].Value.ToString(), DAO.GetUserId(ddlUserList.SelectedItem.ToString()));
                if (!InvoiceDialog.IsDisposed)
                {
                    InvoiceDialog.Show();
                }
                
            }
        }

        private void btnLogToggle_Click(object sender, EventArgs e)
        {
            UserManagement user = new UserManagement(ddlUserList);
            user.Show();
        }

        private void ddlUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ddlUserList.Text))
            {
                Add_Rec.Enabled = true;
            }
            else
            {
                Add_Rec.Enabled = false;
            }
        }

        private void txtInvoiceDiscount_TextChanged(object sender, EventArgs e)
        {
            RecalculateTotals();
        }

        private void ddlUserList_TextChanged(object sender, EventArgs e)
        {
            if (ddlUserList.Text.Equals("administrator"))
            {
                tabTableViewer.Show();
            }
            else
            {
                tabTableViewer.Hide();
            }
        }

        private void chkInvoiceDatePkr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInvoiceDatePkr.Checked)
            {
                pkrReportInvoiceDate.Enabled = true;
            }
            else
            {
                pkrReportInvoiceDate.Enabled = false;
            }
        }

        private void chkDueDatePkr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDueDatePkr.Checked)
            {
                pkrReportDueDate.Enabled = true;
            }
            else
            {
                pkrReportDueDate.Enabled = false;
            }
        }

        private void btnResetReports_Click(object sender, EventArgs e)
        {
            chkDueDatePkr.Checked = false;
            chkInvoiceDatePkr.Checked = false;

            chkInvoiceNumber.Checked = false;
            chkCustomerName.Checked = false;

            chkBranch.Checked = false;
            chkAmount.Checked = false;

            chkItem.Checked = false;
            //chkReceivableStatus.Checked = false;

            chkDueDate.Checked = false;
            chkPaymentTerms.Checked = false;

            chkUnpaidReports.Checked = false;
            chkPartiallyPaidReportsOnly.Checked = false;

            txtReportBranch.Text = "";
            txtReportSalesRep.Text = "";
        }

        private int SelectedColumnsForReports()
        {
            int SelectedColumns = 0;
            if (chkInvoiceNumber.Checked)
            {
                SelectedColumns++;
            }
            if (chkCustomerName.Checked)
            {
                SelectedColumns++;
            }
            if (chkBranch.Checked)
            {
                SelectedColumns++;
            }
            if (chkAmount.Checked)
            {
                SelectedColumns++;
            }
            if (chkItem.Checked)
            {
                SelectedColumns++;
            }
            if (chkDueDate.Checked)
            {
                SelectedColumns++;
            }
            if (chkPaymentTerms.Checked)
            {
                SelectedColumns++;
            }
            if (chkPaidReports.Checked)
            {
                SelectedColumns++;
            }
            if (chkUnpaidReports.Checked)
            {
                SelectedColumns++;
            }
            if (chkPartiallyPaidReportsOnly.Checked)
            {
                SelectedColumns++;
            }
            return SelectedColumns;
        }

        private void btnSearchReport_Click(object sender, EventArgs e)
        {
            if (SelectedColumnsForReports() <= 0)
            {
                MessageBox.Show("Please select atleast one Report Detail.");
            }
            else
            {
                string preQuery = "SELECT ";
                string Columns = "";
                string sufQuery = " FROM RECEIVABLES REC ";
                string Joins = "";
                string WhereClause = "";
                Columns += chkInvoiceNumber.Checked ? "REC.INVOICE_NO," : "";
                Columns += chkCustomerName.Checked ? "CUS.NAME AS CUSTOMER_NAME," : "";

                Columns += chkBranch.Checked ? "PER.BRANCH," : "";
                Columns += chkAmount.Checked ? "PRO.UNIT_PRICE * TRA.QUANTITY AS AMOUNT," : "";

                Columns += chkItem.Checked ? "PRO.PRODUCT_CODE," : "";
                //Columns += chkReceivableStatus.Checked ? "CAST(REC.RECEIVABLE_STATUS AS TEXT) AS STATUS," : "";
                

                Columns += chkDueDate.Checked ? "REC.DUE_DATE," : "";
                Columns += chkPaymentTerms.Checked ? "REC.PAYMENT_TERMS," : "";
                Columns += "CAST(REC.RECEIVABLE_STATUS AS TEXT) AS STATUS,";

                Joins += "LEFT JOIN " + Constants.TableNames.CUSTOMER + " CUS ON CUS.CUSTOMER_ID = REC.CUSTOMER_ID ";
                Joins += "LEFT JOIN " + Constants.TableNames.PERSONNEL + " PER ON PER.PERSONNEL_ID = REC.PERSONNEL_ID ";

                if (Columns.Contains("PRO."))
                {
                    Joins += "LEFT JOIN " + Constants.TableNames.TRANSACTIONS + " TRA ON TRA.INVOICE_ID = REC.INVOICE_ID ";
                    Joins += "LEFT JOIN " + Constants.TableNames.PRODUCT + " PRO ON PRO.PRODUCT_ID = TRA.PRODUCT_ID ";
                }


                if (txtReportBranch.Text.Length > 0)
                {
                    WhereClause += "PER.BRANCH = '" + txtReportBranch.Text + "'";
                }
                if (txtReportSalesRep.Text.Length > 0)
                {
                    if (WhereClause.Length > 0)
                    {
                        WhereClause += " AND";
                    }
                    WhereClause += " PER.NAME like '%" + txtReportSalesRep.Text + "%'";
                }
                if (chkInvoiceDatePkr.Checked)
                {
                    if (WhereClause.Length > 0)
                    {
                        WhereClause += " AND";
                    }
                    WhereClause += " REC.INVOICE_DATE = date('" + pkrReportInvoiceDate.Value.ToString("yyyy-MM-dd") + "')";
                }
                if (chkDueDatePkr.Checked)
                {
                    if (WhereClause.Length > 0)
                    {
                        WhereClause += " AND";
                    }
                    WhereClause += " date(REC.DUE_DATE) = date('" + pkrReportDueDate.Value.ToString("yyyy-MM-dd") + "')";
                }
                if (chkUnpaidReports.Checked)
                {
                    if (WhereClause.Length > 0)
                    {
                        WhereClause += " AND";
                    }
                    WhereClause += " REC.RECEIVABLE_STATUS = '" + Constants.RecievableStatusCode.UNPAID + "'";
                }
                else if (chkPartiallyPaidReportsOnly.Checked)
                {
                    if (WhereClause.Length > 0)
                    {
                        WhereClause += " AND";
                    }
                    WhereClause += " REC.RECEIVABLE_STATUS = '" + Constants.RecievableStatusCode.PARTIALLY_PAID + "'";
                }
                if (WhereClause.Length > 0)
                {
                    WhereClause = WhereClause.Insert(0, "WHERE ");
                }

                if (Columns.Length > 0)
                {
                    Columns = Columns.Substring(0, Columns.Length - 1);
                    AccountsRecievableDao DAO = new AccountsRecievableDao();
                    DataTable dt = DAO.SelectQuery(preQuery + Columns + sufQuery + Joins + WhereClause);

                    if (dt.Columns.Contains("STATUS"))
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            row[row.Table.Columns["STATUS"].Ordinal] = GetRecievableStatusDisplay(row[row.Table.Columns["STATUS"].Ordinal].ToString());
                        }
                    }

                    dgvReportTable.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Please select a column to populate the report.");
                }
            }
        }

        public void ClearSearchInvoiceFields()
        {
            txtSearchInvoiceNumber.Text = "";
            txtSearchCustomerName.Text = "";
            txtSearchPersonnel.Text = "";
            chkEntryFrom.Checked = false;
            chkDueFrom.Checked = false;
            chkEntryTo.Checked = false;
            chkDueTo.Checked = false;
            chkUnpaidInvoice.Checked = false;

            pkrSearchInvoiceFrom.Value = DateTime.Now.Date;
            pkrSearchInvoiceTo.Value = DateTime.Now.Date;
            pkrInvoiceDueFrom.Value = DateTime.Now.Date;
            pkrInvoiceDueTo.Value = DateTime.Now.Date;



        }

        public void PrintTable(DataGridView Table, string Filename)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Filename));
            FileStream fs = new FileStream(Filename + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document(PageSize.LETTER, 10f, 10f, 10f, 10f);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            if (Table.Columns.Count > 0)
            {
                PdfPTable table = new PdfPTable(Table.Columns.Count);
                table.TotalWidth = 575f;
                table.LockedWidth = true;

                foreach (DataGridViewColumn column in Table.Columns)
                {
                    table.AddCell(Table.Columns[column.Index].HeaderText.ToString());
                }

                foreach (DataGridViewRow row in Table.Rows)
                {
                    foreach (DataGridViewColumn column in Table.Columns)
                    {
                        table.AddCell(Table[column.Index, row.Index].Value.ToString());
                    }
                }


                doc.Open();
                doc.Add(table);
                doc.Close();
                System.Diagnostics.Process.Start(Filename + ".pdf");
            }
            else
            {
                MessageBox.Show("There is no data to print.");
            }
            
        }

        private void PrintReportsPDF_Click(object sender, EventArgs e)
        {
            PrintTable(dgvReportTable, Constants.PDFOutputFolderReport + DateTime.Now.ToString("MMMddyyyyhhmmss"));
        }

        private void PrintSearchInvoice_Click(object sender, EventArgs e)
        {
            PrintTable(dgvSearchInvoice, Constants.PDFOutputFolderSearch + DateTime.Now.ToString("MMMddyyyyhhmmss"));
        }

        private void chkUnpaidReports_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkUnpaidReports.Checked)
            {
                chkPartiallyPaidReportsOnly.Checked = false;
                chkPaidReports.Checked = false;
            }
        }

        private void chkPartiallyPaidReportsOnly_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPartiallyPaidReportsOnly.Checked)
            {
                chkUnpaidReports.Checked = false;
                chkPaidReports.Checked = false;
            }
        }

        private void chkPaidReports_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaidReports.Checked)
            {
                chkUnpaidReports.Checked = false;
                chkPartiallyPaidReportsOnly.Checked = false;
            }
        }
        

        

        
    }
}
