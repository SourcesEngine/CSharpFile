using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;
        public frmLoginAccount()
        {
            InitializeComponent();
            cashier = new Cashier("admin", "1234", "Jerry Cajote", "Sales Department");
            txtPassword.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cashier.ValidateLogin(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show($"Welcome {cashier.GetFullName()} from {cashier.GetDepartment()}!");
                frmPurchaseDiscountedItem mainForm = new frmPurchaseDiscountedItem(cashier);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Login Failed");
            }

        }
    }
}
