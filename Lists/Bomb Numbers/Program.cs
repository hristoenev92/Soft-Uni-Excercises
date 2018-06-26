using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombPosition;
            int bombRadiusStartPosition;
            int bombRadiusEndPosition;
            int sum = 0;
            int removeCount = 0;

            for (int i = 0; i < list.Count; i++)
            {
                bombPosition = list.IndexOf(bomb[0]);
                if (bombPosition != -1)
                {
                    if (bombPosition - bomb[1] > 0)
                        bombRadiusStartPosition = bombPosition - bomb[1];
                    else bombRadiusStartPosition = 0;
                    if (list.Count - 1 > bombPosition + bomb[1])
                        bombRadiusEndPosition = bomb[1] + bombPosition;
                    else bombRadiusEndPosition = list.Count - 1;   
                }
                else break;
                removeCount = bombRadiusEndPosition - bombRadiusStartPosition + 1;
                list.RemoveRange(bombRadiusStartPosition, removeCount);
                sum = list.Sum();
            }
            Console.WriteLine(sum);
        }
    }
}
