using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace; 

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string dept = txtDepartment.Text;
            string job = txtJobTitle.Text;

            int hoursWorked = int.Parse(txtHoursWorked.Text);

            double ratePerHour = double.Parse(txtRatePerHour.Text);

            PartTimeEmployee emp = new PartTimeEmployee(fname, lname, dept, job);
            emp.ComputeSalary(hoursWorked, ratePerHour);

            firstname.Text = txtFirstName.Text;
            lastname.Text = txtLastName.Text;

            txtSalary.Text = emp.GetSalary().ToString("F2");

        }














        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
