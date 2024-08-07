using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class StackUnderflowException : Exception
    {
        public StackUnderflowException(string message) : base(message) { }
    }
}
