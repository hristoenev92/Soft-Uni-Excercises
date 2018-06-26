using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNum = new List<int>();
            List<int> secondNum = new List<int>();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            while (x>0)
            {
                firstNum.Add(x % 10);
                x = x / 10;
            }
            while (y > 0)
            {
                secondNum.Add(y % 10);
                y = y / 10;
            }
            int br = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < firstNum.Count; i++)
            {
                if (secondNum.Contains(firstNum[i]))
                {
                    br++;
                    result.Add(firstNum[i]);
                }
            }
            foreach (var item in result.Distinct())
            {
                Console.Write(item+" ");
            }
        }
    }
}
