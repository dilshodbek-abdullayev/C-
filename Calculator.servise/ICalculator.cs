using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.servise
{
    public interface ICalculator<T>
    {
        public void plus(T a, T b);
        public void minus(T a, T b);
        public void multiply(T a, T b);
        public void divide(T a, T b);
    }
}
