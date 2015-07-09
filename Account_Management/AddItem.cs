using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Management
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void CloseAddItemButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            int ProductId = DAO.InsertItem(txtProductCode.Text, txtBrand.Text, Convert.ToDecimal(txtUnitPrice.Text));
            //if(DAO.ItemExist())
            MessageBox.Show("Product inserted into DB: " + ProductId);
        }
    }
}
