using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OperationGene<T>
    {
        public bool IsEqual(T param1, T param2)
        {
            if (param1.Equals(param2))
            {
                return true;
            }
            else { return false; }
        }
    }
}
