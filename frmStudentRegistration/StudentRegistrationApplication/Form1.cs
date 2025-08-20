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
using System.Xml.Linq;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DYComboBoxes();
            PopulateMonthComboBox();
            PopulateProgramComboBox();
        }
        private void DYComboBoxes()
        {
            for (int d = 1; d <= 31; d++)
                cmbDay.Items.Add(d);
            for (int y = 1990; y <= DateTime.Now.Year; y++)
                cmbYear.Items.Add(y);
        }
        private void PopulateMonthComboBox()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July",
                "August", "September", "October", "November", "December" };
            foreach (string month in months)
            {
                cmbMonth.Items.Add(month);
            }
        }
        private void PopulateProgramComboBox()
        {
            ArrayList programs = new ArrayList()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach (string program in programs)
            {
                cmbProgram.Items.Add(program);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string lastname = txtName.Text;
            string firstname = textBox2.Text;
            string middlename = textBox3.Text;
            string gender = radioButton1.Checked ? "Male" : "Female";
            string birthDate = $"{cmbDay.SelectedItem}/{cmbMonth.SelectedItem}/{cmbYear.SelectedItem}";
            string program = $"{cmbProgram.SelectedItem}";

            string name = firstname +" "+ lastname;
            string name1 = firstname + " " + middlename;

            string message = $"Student Name: {firstname} {middlename} {lastname}\nGender: {gender}" +
                $"\nDate of Birth: {birthDate}\nProgram: {program}";
            
            DisplayStudentInfo(message);
            DisplayStudentInfo(name1,lastname,program);
            DisplayStudentInfo(name, program);
        }
        private void DisplayStudentInfo(string message)
        {
            MessageBox.Show($" {message}");
        }
        private void DisplayStudentInfo(string name1, string lastname, string program)
        {
            MessageBox.Show($"Student Name: {name1} {lastname} \nProgram: {program}");
        }
        private void DisplayStudentInfo(string name, string program)
        {
            MessageBox.Show($"Student Name: {name}\nprogram: {program}", " ");
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
