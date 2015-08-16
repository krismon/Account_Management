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
    public partial class UserManagement : Form
    {
        ComboBox UserNames;
        public UserManagement()
        {
            InitializeComponent();
        }
        public UserManagement(ComboBox UserNames)
        {
            InitializeComponent();
            this.UserNames = UserNames;
        }

        private void CancelNewUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AccountsRecievableDao DAO = new AccountsRecievableDao();
            if (txtFirstName.Text.Length <= 0 || txtLastName.Text.Length <= 0 || txtUserName.Text.Length <= 0)
            {
                MessageBox.Show(this, "Please fill out the fields.", "Warning");
            }
            
            else if (DAO.UserExist(txtUserName.Text))
            {
                MessageBox.Show(this, "This User Name already exists.", "Warning");
            }
            else
            {
                int UserId = DAO.InsertUser(txtFirstName.Text, txtLastName.Text, txtUserName.Text);
                if(UserId != null){
                    DialogResult Result =  MessageBox.Show(this, "User successfully added.","Success",MessageBoxButtons.OK);
                    if (Result == DialogResult.OK)
                    {
                        UserNames.Items.Add(txtUserName.Text);
                        this.Close();
                    }
                }
                
            }
        }
    }
}
