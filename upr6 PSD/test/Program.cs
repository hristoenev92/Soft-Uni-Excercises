using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            Random rand = new Random();
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    array[row, col] = rand.Next(-1,6);// ako e ot -5 do 5 shansyt da ima cql red samo s polojitelni ili otricatelni e mnogo malyk
                }
            }
            int broiPolojitelniRedove = 0;
            int broiOtricatelniRedove = 0;
            for (int row = 0; row < 10; row++)
            {
                bool flagPolojitelni = true;
                bool flagOtricatelni = true;
                for (int col = 0; col < 10; col++)
                {
                    if (array[row,col]<0)
                    {
                        flagPolojitelni = false;
                    }
                    if (array[row,col]>0)
                    {
                        flagOtricatelni = false;
                    }
                }
                if (flagOtricatelni == true)
                {
                    broiOtricatelniRedove++;
                }
                if (flagPolojitelni==true)
                {
                    broiPolojitelniRedove++;
                }
            }
            Console.WriteLine("Polojitelni redove: "+broiPolojitelniRedove);
            Console.WriteLine("Otricatelni redove: "+broiOtricatelniRedove);
        }
    }
}
