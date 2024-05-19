using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOOP
{
    public delegate void Operation(string message);
    class Operations
    {
        Operation operation;
        public int X { get; set; }
        public int Y { get; set; }

        public Operations() : this(0,0) { } 
        public Operations(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void AddOperation(Operation op)
        {
            operation += op;
        }
        public void DeleteOperation(Operation op)
        {
            operation -= op;
        }

        public void Sum()
        {
            operation.Invoke($"{X}+{Y}={X + Y}");
        }
    }
}
