using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lica_na_figuri
{
    class Program
    {
        public decimal Square(decimal a)
        {
            decimal S = a * a;
            return S;
        }
        public decimal Circle(decimal r)
        {
            decimal S = (decimal)Math.PI * r * r;
            return S;
        }
        public decimal Trapezoid(decimal a, decimal b, decimal h)
        {
            decimal S = (decimal)(a + b) * h / 2;
            return S;
        }
        
        static void Main(string[] args)
        {
        }
    }
}
