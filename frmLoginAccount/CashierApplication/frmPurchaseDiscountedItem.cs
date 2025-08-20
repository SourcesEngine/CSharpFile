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
    public partial class frmPurchaseDiscountedItem : Form
    {
        private Cashier cashier;
        public frmPurchaseDiscountedItem(Cashier user)
        {
            InitializeComponent();
            cashier = user;
        }
        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome {cashier.GetFullName()} - {cashier.GetDepartment()}";
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLoginAccount login = new frmLoginAccount();
            login.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
