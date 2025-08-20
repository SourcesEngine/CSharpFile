using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace 
{
    public class DiscountedItem : Item
    {
        private double item_discount;  private double discounted_price;
        private double payment_amount; private double change;
        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            this.item_discount = discount;
            this.discounted_price = price * (1 - (item_discount * 0.01));
        }
     
        public double getTotalPrice()
        {
            return discounted_price * item_quantity;
        }
        public void setPayment(double payment)
        {
            this.payment_amount = payment;
        }
        public double getChange()
        {
            change = payment_amount - getTotalPrice();
            return change;
        }
    }}

