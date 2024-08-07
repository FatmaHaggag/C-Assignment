using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Supplier(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public void Notify(Product product, int quantity)
        {
            Console.WriteLine($"Supplier {Name} notified: Product {product.Name} is low on stock. Only {quantity} left.");
        }
    }
}
