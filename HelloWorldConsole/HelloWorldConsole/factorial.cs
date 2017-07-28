using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    class factorial
    {
        public int CalculateFactorial(int num)
        {
            if (num <= 0)
                return 1;
            else
                return CalculateFactorial(num - 1) * num;
        }
    }
}
