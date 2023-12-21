using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.servise
{
    public partial class Calculator<T> : ICalculator<T>
   where T : INumber<T>
    {
        public void divide(T a, T b)
        {
            Console.WriteLine(a / b);
        }

        public void minus(T a, T b)
        {
            Console.WriteLine(a - b);
        }

        public void multiply(T a, T b)
        {
            Console.WriteLine(a * b);
        }

        public void plus(T a, T b)
        {
            Console.WriteLine(a + b);
        }
    }
    public partial class Calculator<T>
    {
        public T a { get; set; }
        public T b { get; set; }
        public Calculator()
        {
            this.a = a;
            this.b = b;

            /* minus(a, b);
             plus(a, b);
             multiply(a, b);
             divide(a, b);*/
        }
    }
}
