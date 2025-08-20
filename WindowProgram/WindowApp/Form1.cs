using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string studentName = txtName.Text;
                double english = double.Parse(txtEnglish.Text);
                double math = double.Parse(txtMath.Text);
                double science = double.Parse(txtScience.Text);
                double filipino = double.Parse(txtFilipino.Text);
                double history = double.Parse(txtHistory.Text);

                double average = (english + math + science + filipino + history) / 5;
                string result = average >= 75 ? "The student passed." : "The student failed.";
                lblResult.Text = $"{result}\nThe general average of {studentName} is {average:F2}.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numeric values for grades.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
