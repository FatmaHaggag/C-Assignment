using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class GList<T>
    {
        private List<T> items;

        public GList()
        {
            items = new List<T>();
        }

        public void Add(T Item)
        {
            items.Add(Item);
            Console.WriteLine($"Added item: {Item} of type {Item.GetType()}");
        }
    }
}
