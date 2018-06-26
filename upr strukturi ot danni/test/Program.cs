using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOP_18._11
{
    class Klienti
    {
        public string name;
        public string grad;
        public string adres;
        public string vip;

        public void addklient()
        {
            Console.Write("Въведете име: ");
            name = Console.ReadLine();
            Console.Write("Въведете град: ");
            grad = Console.ReadLine();
            Console.Write("Въведете адрес: ");
            adres = Console.ReadLine();
            Console.Write("Тип клиент (ВИП или не): ");
            vip = Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Klienti[] klient = new Klienti[10];
            for (int i = 0; i < 10; i++)
            {
                klient[i] = new Klienti();
            }
            Console.Write("Колко клиента ще добавите? - ");
            int m = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                klient[j].addklient();
            }
            Console.Write("Въведете град за търсене: ");
            string filtergrad = Console.ReadLine();

            void displayklient(Klienti[] k)
            {
                for (int i = 0; i < klient.Length; i++)
                {
                    if (klient[i].grad == filtergrad && klient[i].grad != null)
                    {
                        Console.WriteLine("Име: {0}, Град: {1}, Адрес: {2} ", klient[i].name, klient[i].grad, klient[i].adres);
                    }
                }
            }
            displayklient(klient);


            int br = 0;
            void displayallklient(Klienti[] k)
            {
                for (int i = 0; i < br; i++)
                {
                    if (klient[i].grad != null)
                    {
                        Console.WriteLine("Име: {0}, Град: {1}, Адрес: {2} ", klient[i].name, klient[i].grad, klient[i].adres);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("За добавяне на клиент - 1 ");
            Console.WriteLine("За редактиране на клиент - 2 ");
            Console.WriteLine("За показване на всички клиенти - 3 ");
            Console.WriteLine("За изход от програмата - 4 ");
            int a = int.Parse(Console.ReadLine());
            while (a != 4)
            {
                switch (a)
                {
                    case 1:
                        Console.Write("Колко клиента ще добавите: ");
                        br = int.Parse(Console.ReadLine());
                        br = br + m;
                        for (int i = m; i < br; i++)
                        {
                            klient[i].addklient();
                        }
                        break;
                    case 2:
                        Console.Write("Въведете име за редакция на профила: ");
                        string fil = Console.ReadLine();

                        for (int i = 0; i < br; i++)
                        {
                            if (klient[i].name == fil)
                            {
                                Console.Write("Въведете име: ");
                                klient[i].name = Console.ReadLine();
                                Console.Write("Въведете град: ");
                                klient[i].grad = Console.ReadLine();
                                Console.Write("Въведете адрес: ");
                                klient[i].adres = Console.ReadLine();
                                Console.Write("ВИП клиент (да или не) ");
                                klient[i].vip = Console.ReadLine();
                            }
                        }
                        break;
                    case 3:
                        displayallklient(klient);
                        break;
                    default:
                        Console.WriteLine(" ");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("За добавяне на клиент - 1 ");
                Console.WriteLine("За редактиране на клиент - 2 ");
                Console.WriteLine("За показване на всички клиенти - 3 ");
                Console.WriteLine("За изход от програмата - 4 ");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Успешен изход от програмата! ");
        }
    }
}

