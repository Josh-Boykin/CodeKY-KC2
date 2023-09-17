using System;


namespace Grocery_Store
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + ", Price: " + Price.ToString("C");
        }
    }
}