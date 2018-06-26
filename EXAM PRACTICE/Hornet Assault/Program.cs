using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List <long> beehives= Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count==0)
                {
                    break;
                }
                long hornetPower = hornets.Sum();
                beehives[i] -= hornetPower;
                if (beehives[i]>=0)
                {  
                    hornets.RemoveAt(0);
                }
            }
            if (beehives.Any(x=>x>0))
            {
                Console.WriteLine(String.Join(" ",beehives.Where(x=>x>0)));
            }
            else
            {
                Console.WriteLine(String.Join(" ",hornets));
            }
        }
    }
}
