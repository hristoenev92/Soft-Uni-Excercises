using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Average_Grades
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<decimal> Grades { get; set; }
            public decimal Avg { get; set; }
        }
        static void Main(string[] args)
        {
            string[] inputf = File.ReadAllLines("../../input.txt");
            int index = 0;
            int broiStudenti = int.Parse(inputf[index++]);
            List<Student> listStudenti = new List<Student>();

            for (int i = 0; i < broiStudenti; i++)
            {
                string[] input = inputf[index++].Split().ToArray();
                Student student = new Student();
                student.Name = input[0];
                student.Grades = input.Skip(1).Select(decimal.Parse).ToList();
                student.Avg = student.Grades.Average();
                listStudenti.Add(student);
            }
            List<string> output = new List<string>();
            foreach (var student in listStudenti.OrderBy(x => x.Name).ThenByDescending(x => x.Avg))
            {
                if (student.Avg >= 5)
                {
                    output.Add($"{student.Name} -> {student.Avg:f2}");
                }
            }
            File.WriteAllLines("../../output.txt", output);
        }
    }
}
