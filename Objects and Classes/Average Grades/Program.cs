using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int broiStudenti = int.Parse(Console.ReadLine());
            List<Student> listStudenti = new List<Student>();
            
            for (int i = 0; i < broiStudenti; i++)
            {
                listStudenti.Add(ReadStudent());
            }
            
            foreach (var student in listStudenti.OrderBy(x=>x.Name).ThenByDescending(x=>x.Avg))
            {
                if (student.Avg>=5)
                {
                    Console.WriteLine("{0} -> {1:f2}",student.Name,student.Avg);
                }
            }
        }

        static Student ReadStudent()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Student student = new Student();
            student.Name = input[0];
            student.Grades = input.Skip(1).Select(decimal.Parse).ToList();
            student.Avg = student.Grades.Average();
            return (student);
        }
    }
}
