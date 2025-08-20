using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {

        private CalculatorClass cal;
        public class CalculatorClass
        {
            public delegate T Formula<T>(T arg1, T arg2);
      
            public Formula<double> info;
            public event Formula<double> CalculateEvent
            {
                add
                {
                    Console.WriteLine("Added the Delegate");
                    info += value;
                }
                remove
                {
                    Console.WriteLine("Removed the Delegate");
                    info -= value;
                }
            }
            public double GetSum(double num1, double num2)
            {
                return num1 + num2;
            }
            public double GetDifference(double num1, double num2)
            {
                return num1 - num2;
            }
            public double GetProduct(double num1, double num2)
            {
                return num1 * num2;
            }
            public double GetQuotient(double num1, double num2)
            {
                return num1 / num2;
            }
        }
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);

            if (cbOperator.SelectedItem.ToString() == "+")
            {
                cal.CalculateEvent += new CalculatorClass.Formula<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new CalculatorClass.Formula<double>(cal.GetSum);
            }
            else if (cbOperator.SelectedItem.ToString() == "-")
            {
                cal.CalculateEvent += new CalculatorClass.Formula<double>(cal.GetDifference);
                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new CalculatorClass.Formula<double>(cal.GetDifference);
            }
            else if (cbOperator.SelectedItem.ToString() == "*")
            {
                cal.CalculateEvent += new CalculatorClass.Formula<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new CalculatorClass.Formula<double>(cal.GetProduct);
            }
            else if (cbOperator.SelectedItem.ToString() == "/")
            {
                cal.CalculateEvent += new CalculatorClass.Formula<double>(cal.GetQuotient);
                lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                cal.CalculateEvent -= new CalculatorClass.Formula<double>(cal.GetQuotient);
            }
        }
    }
}
