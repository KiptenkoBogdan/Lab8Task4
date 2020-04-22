using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Task4
{
    class Function
    {
        public Function()
        {
        }

        public double Func1(double x)
        {
            return x + 2*Math.Pow(x,2) + 4;
        }

        public double Func2(double x)
        {
            return x + Math.Pow(x, 2) + Math.Pow(x, 3);
        }

        public double Func3(double x)
        {
            return x + 2*x + 3*x;
        }
    }
}
