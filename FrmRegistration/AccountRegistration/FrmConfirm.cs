using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AccountRegistration.FrmRegistration;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {

        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        private void lblFirstName_Click(object sender, EventArgs e)
        {
        }
        private void lblProgram_Click(object sender, EventArgs e)
        {
        }
        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblLastName.Text = DelLastName(StudentInfoClass.LastName);
            lblFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAddress.Text = DelAddress(StudentInfoClass.Address);
            lblAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lblStudentNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
