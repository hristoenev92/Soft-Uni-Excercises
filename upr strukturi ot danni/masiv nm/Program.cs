using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masiv_nm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n<4||100<n)
            {
                n = int.Parse(Console.ReadLine());
            }
            int[] nm = new int[n];
            for (int i = 0; i < n; i++)
            {
                nm[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in nm)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            List<int> result = new List<int>();
            if (nm[0]<nm[1])
            {
                result.Add(nm[0]);
            }
            for (int i = 1; i < nm.Length-1; i++)
            {
                if (nm[i]>nm[i-1]&&nm[i]<nm[i+1])
                {
                    result.Add(nm[i]);
                }
            }
            if (nm[nm.Length-1]>nm[nm.Length-2])
            {
                result.Add(nm.Last());
            }
            foreach (var item in result)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            int m = 0;
            while (m < 3 || Math.Sqrt(n) < m)
            {
                m = int.Parse(Console.ReadLine());
            }
            int[,] matrix = new int[m, m];
            int br = 0;
            for (int row = 0; row < m; row++)
            {
                for (int column = 0; column < m; column++)
                {
                    matrix[column, row] = nm[br++];
                }
            }
            for (int row = 0; row < m; row++)
            {
                for (int column = 0; column < m; column++)
                {
                    Console.Write(matrix[row,column]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
