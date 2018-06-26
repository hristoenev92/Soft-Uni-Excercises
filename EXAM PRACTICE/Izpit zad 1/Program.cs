using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Izpit_zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger securityKey= BigInteger.Parse(Console.ReadLine());
            List<string> sitename = new List<string>();
            decimal totalLoss = 0;
            BigInteger securityToken = BigInteger.Pow(securityKey, n);
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                sitename.Add(input[0]);
                long siteVisits = long.Parse(input[1]);
                decimal pricePerVsit = decimal.Parse(input[2]);
                decimal loss= (decimal)siteVisits * pricePerVsit;
                totalLoss += loss;
            }
            foreach (var site in sitename.Distinct())
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
