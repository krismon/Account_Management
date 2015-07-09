using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management
{
    public class Constants
    {
        public const string DataSource = "C:\\AccountManagement\\data";
        public const string PDFOutputFolderSearch = "C:\\AccountManagement\\Extracts\\Searches\\";
        public const string PDFOutputFolderReport = "C:\\AccountManagement\\Extracts\\Reports\\";
        public class TableNames
        {
            public const string CUSTOMER = "CUSTOMER";
            public const string PERSONNEL = "PERSONNEL";
            public const string PRODUCT = "PRODUCT";
            public const string RECEIVABLES = "RECEIVABLES";
            public const string TRANSACTIONS = "TRANSACTIONS";
            public const string PAYMENTS = "PAYMENTS";
            public const string USER = "USER";
        }
        public class RecievableStatusCode
        {
            public const int FULLY_PAID = 2;
            public const int PARTIALLY_PAID = 1;
            public const int UNPAID = 0;
        }
        public class RecievableStatusDisplay
        {
            public const string FULLY_PAID = "Paid";
            public const string PARTIALLY_PAID = "Partially Paid";
            public const string UNPAID = "Unpaid";
        }

        public class PaymentTypeCode
        {
            public const int TAX_CERTIFICATE = 2;
            public const int CHECK = 1;
            public const int CASH = 0;
        }
        public class PaymentTypeDisplay
        {
            public const string TAX_CERTIFICATE = "Tax Certificate";
            public const string CHECK = "Check";
            public const string CASH = "Cash";
        }
        public class RowColumnCodeForAddInvoice
        {
            public const int REMOVE_ROW = 0;
            public const int QUANTITY = 1;
            public const int ITEM_CODE = 2;
            public const int BRAND = 3;
            public const int PRICE = 4;
            public const int DISCOUNT = 5;
            public const int AMOUNT = 6;
        }
        public class RowColumnCodeForSearchInvoice
        {
            public const int INVOICE_NUMBER = 0;
            public const int CUSTOMER_NAME = 1;
            public const int SALES_REPRESENTATIVE = 2;
            public const int ENTRY_DATE = 3;
            public const int DUE_DATE = 4;
            public const int EDIT = 5;
            public const int INVOICE_ID = 6;
        }
    }
}
