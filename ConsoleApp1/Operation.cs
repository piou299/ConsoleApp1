using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Operation
    {
        public bool IsEqual(int a, int b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else { return false; } 
        }

        public bool IsEqual2(double a, double b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else { return false; }
        }
    }
}
