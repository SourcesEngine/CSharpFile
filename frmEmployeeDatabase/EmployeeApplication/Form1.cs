using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeApplication;

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
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(
                int.Parse(txtEmployeeId.Text),
                textFN.Text,
                textLN.Text,
                txtPosition.Text
            );

            dgvEmployeeData.Rows.Add(employee.EmployeeId, employee.FirstName, employee.LastName, employee.Position);
   
    }
    }
}
