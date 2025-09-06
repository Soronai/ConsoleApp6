using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        int divide(int a, int b)
        {
            if (b == 0)
                return 0;
            else
            {
                return a / b;
            }
        }

        int multiply(int a, int b)
        {
            return a * b;
        }

        int plus(int a, int b)
        {
            return a + b;
        }

        int minus(int a, int b)
        {
            return a - b;
        }
    }
}
