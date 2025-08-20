using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
    public partial class Form1 : Form
    {
        private double total_amount = 0;  private double payment_amount = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);

            DiscountedItem item = new DiscountedItem(itemName, price, quantity, discount);
            total_amount = item.getTotalPrice();
            lblTotalAmount.Text = total_amount.ToString("C");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            payment_amount = Convert.ToDouble(txtPayment.Text);
            DiscountedItem item = new DiscountedItem(txtItemName.Text, Convert.ToDouble(txtPrice.Text), Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtDiscount.Text));

            item.setPayment(payment_amount);
            double change = item.getChange();

            if (change >= 0)
            {
                lblChange.Text = change.ToString("C");
            }
            else
            {
                lblChange.Text = "Insufficient Payment!";
            } }
    }}
