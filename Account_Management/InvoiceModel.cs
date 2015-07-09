using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management
{
    public class InvoiceModel
    {
        public int InvoiceId { get; set; }
        public int InvoiceNo { get; set; }
        public int CustomerId { get; set; }
        public int ReceivableStatusCode { get; set; }
        public int PersonnelId { get; set; }
        public int UpdatedBy { get; set; }
        public int PaymentTerms { get; set; }
        public int AddedBy { get; set; }
        public string ReceivableStatusDisplay { get; set; }
        public string Remarks { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime InvoiceDate { get; set; }

        public List<InvoiceItem> InvoiceItems { get; set; }
    }
    public class InvoiceItem
    {
        public int TransactionId { get; set; }
        public int Quantity { get; set; }
        public string ItemCode { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }

    }
}
