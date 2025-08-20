using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queuing
{
    public partial class CustomerView : Form
    {
        public CustomerView(string queueNumber)
        {
            InitializeComponent();

            lblCustomerMessage.Text = queueNumber;
        }
        private void CustomerView_Load(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
