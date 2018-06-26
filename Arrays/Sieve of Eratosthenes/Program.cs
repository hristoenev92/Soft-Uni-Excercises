using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] array = new bool[n+1];
            for (int i = 2; i <= n; i++)
            {
                array[i] = true;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==true)
                {
                    for (int j = 2; j*i <= n; j++)
                    {
                        array[j*i] = false;
                    }
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if(array[i]==true)
                    Console.Write(i+" ");
            }
            
        }
    }
}
