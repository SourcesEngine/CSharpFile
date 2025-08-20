using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOfClass
{
    public class Circle
    {
        public double getCircleDiameter(double radius)
        {
            return radius * 2;
        }
    }
    public struct Product
    {
        public string code;
        public string description;
        public double price;

        public Product(string code, string description, double price)
        {
            this.code = code;
            this.description = description;
            this.price = price;
        }
    }
    public class Person
    {
        public string full_name;

        public Person()
        {
            full_name = "Jerry Cajote";
        }
    }

    public class Account
    {
        public string account_number;
        public Account(string accountNumber)
        {
            this.account_number = accountNumber;

        }
             
        internal class Program
        {
            static void Main(string[] args)
            {
                
                Circle circle = new Circle();
                double diameter = circle.getCircleDiameter(10.10);
                Console.WriteLine($"Diameter of the circle: {diameter}");
              
                Product product = new Product("17788", "Monitor", 250.00);
                Console.WriteLine($"Product Code: {product.code}, Description: {product.description}, Price: ${product.price}");

                Person person = new Person();
                Console.WriteLine($"Person's Full Name: {person.full_name}");

                Account account = new Account("84355754395");
                Console.WriteLine($"Account Number: {account.account_number}");
                
            }
        }
    }
}
