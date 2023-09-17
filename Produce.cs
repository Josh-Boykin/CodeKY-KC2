using Grocery_Store;
using System;

namespace Grocery_Store
{
    public class Produce : Product
    {
        public string Description { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", Description: " + Description;
        }
    }
}