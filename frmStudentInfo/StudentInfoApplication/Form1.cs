using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace StudentInfoApplication
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
            int studentId = Convert.ToInt32(txtStudentId.Text); 
            string lastname = txtLastname.Text;
            string firstname = txtFirstname.Text;

            StudentInfo student = new StudentInfo(studentId, lastname, firstname);

            lstStudentIds.Items.Add(student.StudentId);
            lstLastnames.Items.Add(student.Lastname);
            lstFirstnames.Items.Add(student.Firstname);

            ClearFields();
        }
        private void ClearFields()
        {
            txtStudentId.Clear();
            txtLastname.Clear();
            txtFirstname.Clear();
        }
    }
    }

