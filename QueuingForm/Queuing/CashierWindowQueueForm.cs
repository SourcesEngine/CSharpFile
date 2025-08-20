using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {
        private Timer timer;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
        }
        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                string currentNumber = CashierClass.CashierQueue.Dequeue().ToString();
                DisplayCashierQueue(CashierClass.CashierQueue);

                CustomerView customerView = new CustomerView(currentNumber);
                customerView.Show();
            }
        }
    }
}
