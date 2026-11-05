using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace DATA.Classes
{
    public class Product : IPurchasable
    {
        public int Id { get; set; }
        private string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name == null)
                    Console.WriteLine("your name do not declare");
                else
                    name = value;
            }
        }
        public string Category { get; set; }
        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                { Console.WriteLine(" price is not valid "); }
                else
                { price = value; }
            }
        }
        private decimal quantity;
        public decimal StockQuantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 0)
                { Console.WriteLine(" stock quantity is not valid "); }
                else
                { quantity = value; }
            }

        }
        public override string ToString()
        {
            return $"productID:{Id}," +
                $" productName:{Name}" +
                $",productCategory{Category}," +
                $" product price:{Price}, " +
                $"StockQuantity Product:{StockQuantity}";
        }
        public bool Buy (int quantity)

        { if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
                return true;
            }
            else { return false; }
        }
        public bool Restock (int quantity)
        { if (quantity>0)
            {
                StockQuantity += quantity;
                return true;
            }
          else { return false; }
        }
    }
}
