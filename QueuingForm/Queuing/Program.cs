using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queuing
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QueuingForm());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show QueuingForm first
            QueuingForm queuingForm = new QueuingForm();
            queuingForm.Show();

            // Show CashierWindowQueueForm
            CashierWindowQueueForm cashierWindowQueueForm = new CashierWindowQueueForm();
            cashierWindowQueueForm.Show();

            // Start the message loop
            Application.Run();
        }
    }
}
