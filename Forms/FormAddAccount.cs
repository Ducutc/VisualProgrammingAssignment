using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHouseABC
{
    public partial class FormAddAccount : Form
    {
        public string Username => txtUserName.Text.Trim();
        public string Password => txtPassword.Text.Trim();
        public string ConfPassword => txtConfPassword.Text.Trim();
        public string Role => cbRole.Text.Trim();
        public FormAddAccount()
        {
            InitializeComponent();
        }

        public FormAddAccount(string username, string password, string role) : this()
        {
            txtUserName.Text = username;
            txtPassword.Text = password;
            cbRole.Text = role;
        }

        private void FormAddAccount_Load(object sender, EventArgs e)
        {

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) 
                || Password.CompareTo(ConfPassword) != 0 || String.IsNullOrEmpty(Role))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
