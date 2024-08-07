using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private Dictionary<Product, int> productInventory = new Dictionary<Product, int>();

        public delegate void LowStockHandler(Product product, int quantity);
        public event LowStockHandler LowStock;

        public Company(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public void AddProduct(Product product, int quantity)
        {
            if (productInventory.ContainsKey(product))
            {
                productInventory[product] += quantity;
            }
            else
            {
                productInventory[product] = quantity;
            }
            Console.WriteLine($"Product {product.Name} added. Current quantity: {productInventory[product]}");
        }

        public void SellProduct(Product product, int quantity)
        {
            if (productInventory.ContainsKey(product))
            {
                if (productInventory[product] >= quantity)
                {
                    productInventory[product] -= quantity;
                    Console.WriteLine($"Product {product.Name} sold. Remaining quantity: {productInventory[product]}");

                    if (productInventory[product] < 5)
                    {
                        LowStock?.Invoke(product, productInventory[product]);
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough stock of {product.Name} to sell. Current quantity: {productInventory[product]}");
                }
            }
            else
            {
                Console.WriteLine($"Product {product.Name} does not exist in the inventory.");
            }
        }
    }
}
