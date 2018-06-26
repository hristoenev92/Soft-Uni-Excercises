using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moneti
{
    class Program
    {
        static void Main(string[] args)
        {
            int lev = int.Parse(Console.ReadLine());
            int dva = int.Parse(Console.ReadLine());
            int pet = int.Parse(Console.ReadLine());
            int suma = int.Parse(Console.ReadLine());

                for (int izpolzvanlev = 0; izpolzvanlev <= lev; izpolzvanlev++)
                {
                    for (int izpolzvandva = 0; izpolzvandva <= dva; izpolzvandva++)
                    {
                        for (int izpolzvanpet = 0; izpolzvanpet <= pet; izpolzvanpet++)
                        { 
                          
                            if (suma==izpolzvanpet*5+izpolzvandva*2+izpolzvanlev*1)
                            {
                                Console.WriteLine(
                                      $"{izpolzvanlev} * 1 lv. + " +
                                      $"{izpolzvandva} * 2 lv. + " +
                                      $"{izpolzvanpet} * 5 lv. = {suma} lv.");
                                

                            }
                           
                        }
                        
                    }
                    
                }

            
        }
    }
}
