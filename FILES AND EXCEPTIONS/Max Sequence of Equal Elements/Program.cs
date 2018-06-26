using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("../../output.txt","");
            int[] array = File.ReadAllText("../../input.txt").Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int bestCounter = 0;
            int index = 0;


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    index = i - counter + 1;
                }
            }
            for (int i = index; i < bestCounter + index; i++)
            {
                File.AppendAllText("../../output.txt", array[i] + " ");
            }
            
        }
    }
}
