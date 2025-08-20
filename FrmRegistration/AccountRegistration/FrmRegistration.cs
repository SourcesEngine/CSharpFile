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

    public partial class FrmRegistration : Form
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        public class StudentInfoClass
        {
           
            public static DelegateNumber DelegateNumber;
            public static DelegateText DelegateText;

            public static string FirstName = "";
            public static string LastName = "";
            public static string MiddleName = "";
            public static string Address = "";
            public static string Program = "";
            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;

            public static string GetFirstName(string FirstName) => FirstName;
            public static string GetLastName(string LastName) => LastName;
            public static string GetMiddleName(string MiddleName) => MiddleName;
            public static string GetAddress(string Address) => Address;
            public static string GetProgram(string Program) => Program;
            public static long GetAge(long Age) => Age;
            public static long GetContactNo(long ContactNo) => ContactNo;
            public static long GetStudentNo(long StudentNo) => StudentNo;
        }
        public FrmRegistration()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Address = txtAddress.Text;
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.Age = long.Parse(txtAge.Text);
            StudentInfoClass.ContactNo = long.Parse(txtContactNo.Text);
            StudentInfoClass.StudentNo = long.Parse(txtStudentNo.Text);

            FrmConfirm frmConfirm = new FrmConfirm();
            if (frmConfirm.ShowDialog() == DialogResult.OK)
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtMiddleName.Clear();
                txtAddress.Clear();
                cbProgram.SelectedIndex = -1;
                txtAge.Clear();
                txtContactNo.Clear();
                txtStudentNo.Clear();
            }
        }
    }
}

