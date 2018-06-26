using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 1000)
            {
                if (i % 10 == 7) Console.WriteLine(i);
                i++;
            }
        }
    }
}
