using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
            int sum = 0;
            if (input[0].Length >= input[1].Length)
            {
                for (int i = 0; i < input[1].Length; i++)
                {
                    char first = input[0][i];
                    char second = input[1][i];
                    sum += first * second;
                }
                for (int i = input[1].Length; i < input[0].Length; i++)
                {
                    char leftover = input[0][i];
                    sum += leftover;
                }
            }
            else
            {
                for (int i = 0; i < input[0].Length; i++)
                {
                    char first = input[0][i];
                    char second = input[1][i];
                    sum += first * second;
                }
                for (int i = input[0].Length; i < input[1].Length; i++)
                {
                    char leftover = input[1][i];
                    sum += leftover;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
