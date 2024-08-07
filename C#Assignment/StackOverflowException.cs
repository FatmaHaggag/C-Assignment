using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class StackOverflowException : Exception
    {
        public StackOverflowException(string message) : base(message) { }

    }
}
