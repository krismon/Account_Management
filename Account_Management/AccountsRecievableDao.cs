using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Account_Management
{
    public class AccountsRecievableDao
    {
        private string DataSource = Constants.DataSource;

        #region InitScript

        public void InitTables()
        {
            if (!TableExists(Constants.TableNames.CUSTOMER))
            {
                ExecuteSQL("CREATE TABLE CUSTOMER ( CUSTOMER_ID INTEGER PRIMARY KEY AUTOINCREMENT, NAME TEXT , ADDRESS TEXT , CONTACT_NO TEXT ) ");
            }
            if (!TableExists(Constants.TableNames.PERSONNEL))
            {
                ExecuteSQL("CREATE TABLE PERSONNEL ( PERSONNEL_ID INTEGER PRIMARY KEY AUTOINCREMENT , NAME TEXT, BRANCH TEXT) ");
            }
            if (!TableExists(Constants.TableNames.PRODUCT))
            {
                ExecuteSQL("CREATE TABLE PRODUCT ( PRODUCT_ID INTEGER PRIMARY KEY AUTOINCREMENT , BRAND TEXT , PRODUCT_CODE TEXT , UNIT_PRICE DECIMAL ) ");
            }
            if (!TableExists(Constants.TableNames.RECEIVABLES))
            {
                ExecuteSQL("CREATE TABLE RECEIVABLES ( INVOICE_ID INTEGER PRIMARY KEY AUTOINCREMENT,INVOICE_NO INTEGER,INVOICE_DATE DATETIME,CUSTOMER_ID INTEGER,RECEIVABLE_STATUS INTEGER,PERSONNEL_ID INTEGER,REMARKS TEXT ,DUE_DATE DATETIME,DISCOUNT INTEGER,ENTRY_DATE DATETIME,DATE_UPDATED DATETIME,UPDATED_BY TEXT ,PAYMENT_TERMS INTEGER,ADDED_BY TEXT,AMOUNT DECIMAL)");
            }
            if (!TableExists(Constants.TableNames.TRANSACTIONS))
            {
                ExecuteSQL("CREATE TABLE TRANSACTIONS ( TRANSACTION_NO INTEGER PRIMARY KEY AUTOINCREMENT, INVOICE_ID INTEGER,PRODUCT_ID INTEGER,QUANTITY INTEGER,DISCOUNT INTEGER)");
            }
            if (!TableExists(Constants.TableNames.PAYMENTS))
            {
                ExecuteSQL(@"CREATE TABLE PAYMENTS ( PAYMENT_ID INTEGER PRIMARY KEY AUTOINCREMENT
                ,INVOICE_NO INTEGER
                ,PAYMENT_DATE DATETIME
                ,PAYMENT_TYPE INTEGER
                ,ADDED_BY TEXT 
                ,DATE_UPDATED DATETIME
                ,UPDATED_BY TEXT 
                ,REMARKS TEXT 
                ,ENTRY_DATE DATETIME
                ,AMOUNT DECIMAL
                ,CHECK_NO TEXT
                ,CHECK_DATE DATETIME
                )");
            }
            if (!TableExists(Constants.TableNames.USER))
            {
                ExecuteSQL("CREATE TABLE USER ( USER_ID INTEGER PRIMARY KEY AUTOINCREMENT, FIRST_NAME TEXT,LAST_NAME TEXT,USER_NAME TEXT)");
            }
        }
        #endregion

        #region Template Queries
        public Boolean TableExists(string TableName)
        {
            DataTable TempTable;
            TempTable = SelectQuery("SELECT name FROM sqlite_master WHERE type='table' AND name='"+TableName+"';");
            if (TempTable.Rows.Count <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public DataTable SelectQuery(string QueryString)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    DataTable dt = sh.Select(QueryString + ";");
                    conn.Close();

                    return dt;
                }
            }
        }
        public int InsertQuery(string Table, Dictionary<string, object> Parameters)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.Insert(Table, Parameters);
                    int Id = Convert.ToInt32(sh.LastInsertRowId());
                    conn.Close();
                    return Id;
                }
            }
        }
        public void UpdateQuery(string Table, Dictionary<string, object> Parameters, Dictionary<string, object> Conditions)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.Update(Table, Parameters, Conditions);
                    conn.Close();

                }
            }
        }
        public void UpdateQuery(string Table, Dictionary<string, object> Parameters, string ColumnName, string Parameter)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.Update(Table, Parameters, ColumnName, Parameter);
                    conn.Close();

                }
            }
        }
        public void DeleteQuery(string Table, string Id)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.Execute("Delete from " + Table + " WHERE ID = '" + Id + "';");
                    conn.Close();

                }
            }
        }
        public void ExecuteSQL(string ExecuteScript)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.Execute(ExecuteScript + ";");
                    conn.Close();

                }
            }
        }
        public DataTable TableStatus(string TableName)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    DataTable dt = sh.GetColumnStatus(TableName);
                    conn.Close();

                    return dt;

                }
            }
        }
        #endregion

        #region Queries
        public int InsertTransaction(int InvoiceId, int ProductId, int Quantity, int Discount)
        {
            Dictionary<string, object> InsertParameters = new Dictionary<string, object>();
            InsertParameters.Add("INVOICE_ID", InvoiceId);
            InsertParameters.Add("PRODUCT_ID", ProductId);
            InsertParameters.Add("QUANTITY", Quantity);
            InsertParameters.Add("DISCOUNT", Discount);
            int TransactionID = InsertQuery(Constants.TableNames.TRANSACTIONS, InsertParameters);

            return TransactionID;
        }
        public int InsertItem(string ProductCode, string Brand, decimal UnitPrice)
        {
            Dictionary<string, object> InsertParameters = new Dictionary<string, object>();
            InsertParameters.Add("BRAND", Brand);
            InsertParameters.Add("PRODUCT_CODE", ProductCode);
            InsertParameters.Add("UNIT_PRICE", UnitPrice);
            int ProductId = InsertQuery(Constants.TableNames.PRODUCT, InsertParameters);

            return ProductId;
        }
        public int InsertCustomer(string Name, string Address, int ContactNo)
        {
            Dictionary<string, object> InsertParameters = new Dictionary<string, object>();
            InsertParameters.Add("NAME", Name);
            InsertParameters.Add("ADDRESS", Address);
            InsertParameters.Add("CONTACT_NO", ContactNo);
            int CustomerId = InsertQuery(Constants.TableNames.CUSTOMER, InsertParameters);

            return CustomerId;
        }
        public int InsertPersonnel(string Name, string Branch)
        {
            Dictionary<string, object> InsertParameters = new Dictionary<string, object>();
            InsertParameters.Add("NAME", Name);
            InsertParameters.Add("BRANCH", Branch);
            int PersonnelId = InsertQuery(Constants.TableNames.PERSONNEL, InsertParameters);

            return PersonnelId;
        }
        public int InsertUser(string FirstName, string LastName, string UserName)
        {
            Dictionary<string, object> InsertParameters = new Dictionary<string, object>();
            InsertParameters.Add("FIRST_NAME", FirstName);
            InsertParameters.Add("LAST_NAME", LastName);
            InsertParameters.Add("USER_NAME", UserName);
            int UserId = InsertQuery(Constants.TableNames.USER, InsertParameters);

            return UserId;
        }
        public int InsertItemToInvoice(string InvoiceId, int ProductId, int Quantity, int Discount)
        {
            Dictionary<string, object> InsertParameters = new Dictionary<string, object>();
            InsertParameters.Add("INVOICE_ID", InvoiceId);
            InsertParameters.Add("PRODUCT_ID", ProductId);
            InsertParameters.Add("QUANTITY", Quantity);
            InsertParameters.Add("DISCOUNT", Discount);
            int TransactionId = InsertQuery(Constants.TableNames.TRANSACTIONS, InsertParameters);

            return TransactionId;
        }
        public int InsertInvoice(
            string REMARKS,
            string ADDED_BY,
            string UPDATED_BY,
            int INVOICE_NO,
            int CUSTOMER_ID,
            int RECEIVABLE_STATUS,
            int PERSONNEL_ID,
            int DISCOUNT,
            int PAYMENT_TERMS,
            decimal AMOUNT,
            DateTime INVOICE_DATE,
            DateTime DUE_DATE,
            DateTime ENTRY_DATE,
            DateTime DATE_UPDATED
            )
        {
            Dictionary<string, object> InsertParameters = new Dictionary<string, object>();
            InsertParameters.Add("INVOICE_NO", INVOICE_NO);
            InsertParameters.Add("INVOICE_DATE", INVOICE_DATE);
            InsertParameters.Add("CUSTOMER_ID", CUSTOMER_ID);
            InsertParameters.Add("RECEIVABLE_STATUS", RECEIVABLE_STATUS);
            InsertParameters.Add("PERSONNEL_ID", PERSONNEL_ID);
            InsertParameters.Add("REMARKS", REMARKS);
            InsertParameters.Add("DUE_DATE", DUE_DATE);
            InsertParameters.Add("DISCOUNT", DISCOUNT);
            InsertParameters.Add("ENTRY_DATE", ENTRY_DATE);
            InsertParameters.Add("DATE_UPDATED", DATE_UPDATED);
            InsertParameters.Add("UPDATED_BY", UPDATED_BY);
            InsertParameters.Add("PAYMENT_TERMS", PAYMENT_TERMS);
            InsertParameters.Add("ADDED_BY", ADDED_BY);
            InsertParameters.Add("AMOUNT", AMOUNT);
            int InvoiceId = InsertQuery(Constants.TableNames.RECEIVABLES, InsertParameters);
            return InvoiceId;
        }
        public int InsertPayment(
            int INVOICE_NO,
            DateTime PAYMENT_DATE,
            int PAYMENT_TYPE,
            int ADDED_BY,
            DateTime DATE_UPDATED,
            int UPDATED_BY,
            string REMARKS,
            DateTime ENTRY_DATE,
            decimal AMOUNT,
            string CHECK_NO,
            DateTime CHECK_DATE)
        {
            Dictionary<string, object> InsertParameters = new Dictionary<string, object>();
            InsertParameters.Add("INVOICE_NO", INVOICE_NO);
            InsertParameters.Add("PAYMENT_DATE", PAYMENT_DATE);
            InsertParameters.Add("PAYMENT_TYPE", PAYMENT_TYPE);
            InsertParameters.Add("ADDED_BY", ADDED_BY);
            InsertParameters.Add("DATE_UPDATED", DATE_UPDATED);
            InsertParameters.Add("UPDATED_BY", UPDATED_BY);
            InsertParameters.Add("REMARKS", REMARKS);
            InsertParameters.Add("ENTRY_DATE", ENTRY_DATE);
            InsertParameters.Add("AMOUNT", AMOUNT);
            InsertParameters.Add("CHECK_NO", CHECK_NO);
            InsertParameters.Add("CHECK_DATE", CHECK_DATE);
            int PaymentId = InsertQuery(Constants.TableNames.PAYMENTS, InsertParameters);
            return PaymentId;
        }
        public Boolean ItemExist(string ProductCode)
        {
            DataTable td = SelectQuery("Select PRODUCT_ID from " + Constants.TableNames.PRODUCT + " WHERE UPPER(PRODUCT_CODE) = UPPER('" + ProductCode + "')");
            if (td.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean InvoiceExist(string INVOICE_NO)
        {
            DataTable td = SelectQuery("Select INVOICE_ID from " + Constants.TableNames.RECEIVABLES + " WHERE INVOICE_NO='" + INVOICE_NO + "'");
            if (td.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean CustomerExist(string NAME)
        {
            DataTable td = SelectQuery("Select CUSTOMER_ID from " + Constants.TableNames.CUSTOMER + " WHERE UPPER(NAME) = UPPER('" + NAME + "')");
            if (td.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean PersonnelExist(string NAME)
        {
            DataTable td = SelectQuery("Select PERSONNEL_ID from " + Constants.TableNames.PERSONNEL + " WHERE UPPER(NAME) = UPPER('" + NAME + "')");
            if (td.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean UserExist(string UserName)
        {
            DataTable td = SelectQuery("Select USER_ID from " + Constants.TableNames.USER + " WHERE USER_NAME = '" + UserName + "'");
            if (td.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public AutoCompleteStringCollection GetAutoCompleteList(string Column, string Table)
        {
            AutoCompleteStringCollection AutoCompleteList = new AutoCompleteStringCollection();
            DataTable td = SelectQuery("Select " + Column + " from " + Table);
            List<string> Product_List = td.AsEnumerable().Select(r => r.Field<string>(Column)).ToList();
            foreach (string item in Product_List)
            {
                AutoCompleteList.Add(item);
            }
            return AutoCompleteList;
        }
        public AutoCompleteStringCollection GetAutoCompleteListForInt(string Column, string Table)
        {
            AutoCompleteStringCollection AutoCompleteList = new AutoCompleteStringCollection();
            DataTable td = SelectQuery("Select " + Column + " from " + Table);
            //List<int> Product_List = td.AsEnumerable().Select(r => r.Field<int>(Column)).ToList();


            foreach (DataRow rowitem in td.Rows)
            {
                AutoCompleteList.Add(rowitem[0].ToString());
            }
            return AutoCompleteList;
        }
        public Dictionary<string, string> GetCustomerDetails(string CustomerName)
        {
            DataTable td = SelectQuery("SELECT ADDRESS, CONTACT_NO,NAME,CUSTOMER_ID FROM CUSTOMER WHERE UPPER(NAME) = UPPER('" + CustomerName + "')");
            Dictionary<string, string> CustomerDetails = new Dictionary<string, string>();
            if (td.Rows.Count > 0)
            {
                CustomerDetails.Add("ADDRESS", td.Rows[0][0].ToString());
                CustomerDetails.Add("CONTACT_NO", td.Rows[0][1].ToString());
                CustomerDetails.Add("NAME", td.Rows[0][2].ToString());
                CustomerDetails.Add("CUSTOMER_ID", td.Rows[0][3].ToString());
            }
            return CustomerDetails;
        }
        public Dictionary<string, string> GetPersonelDetails(string PersonnelName)
        {
            DataTable td = SelectQuery("SELECT PERSONNEL_ID,NAME,BRANCH FROM PERSONNEL WHERE UPPER(NAME) = UPPER('" + PersonnelName + "')");
            Dictionary<string, string> PersonnelDetails = new Dictionary<string, string>();
            if (td.Rows.Count > 0)
            {
                PersonnelDetails.Add("PERSONNEL_ID", td.Rows[0][0].ToString());
                PersonnelDetails.Add("NAME", td.Rows[0][1].ToString());
                PersonnelDetails.Add("BRANCH", td.Rows[0][2].ToString());
            }
            return PersonnelDetails;
        }
        public List<string> GetUsers()
        {
            List<string> UserList = new List<string>();
            DataTable dt = SelectQuery("SELECT FIRST_NAME, LAST_NAME, USER_NAME FROM " + Constants.TableNames.USER);

            foreach (DataRow row in dt.Rows)
            {
                UserList.Add(row[2].ToString());
            }
            return UserList;
        }
        public string GetUserId(string UserName)
        {
            DataTable dt = SelectQuery("SELECT USER_ID FROM " + Constants.TableNames.USER + " WHERE USER_NAME='" + UserName + "'");
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return null;
            }

        }
        #endregion
    }
}
