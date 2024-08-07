using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class Stack : IStack
    {
        private int[] items;
        private int currentIndex;
        private const int DefaultSize = 10;

        public Stack(int size = DefaultSize)
        {
            items = new int[size];
            currentIndex = -1;
        }

        public void Push(int item)
        {
            if (currentIndex >= items.Length - 1)
            {
                throw new StackOverflowException("cannot push onto a full stack.");
            }
            items[++currentIndex] = item;
        }

        public int Pop()
        {
            if (currentIndex < 0)
            {
                throw new StackUnderflowException("cannot pop from an empty stack.");
            }
            return items[currentIndex--];
        }
    }
}
