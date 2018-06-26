using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Book_Library
{
    class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }

        }
        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }
        static void Main(string[] args)
        {
            string[] inputf = File.ReadAllLines("../../input.txt");
            int indexer = 0;
            int bookCount = int.Parse(inputf[indexer++]);
            Library biblioteka = new Library() { Name = "Biblioteka", Books = new List<Book>() };
            for (int i = 0; i < bookCount; i++)
            {
                string[] input = inputf[indexer++].Split().ToArray();
                Book newBook = new Book();
                newBook.Title = input[0];
                newBook.Author = input[1];
                newBook.Publisher = input[2];
                newBook.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                newBook.ISBN = input[4];
                newBook.Price = decimal.Parse(input[5]);
                biblioteka.Books.Add(newBook);
            }
            Dictionary<string, decimal> formated = new Dictionary<string, decimal>();
            foreach (var book in biblioteka.Books)
            {
                if (formated.ContainsKey(book.Author))
                {
                    formated[book.Author] += book.Price;
                }
                else
                {
                    formated.Add(book.Author, book.Price);
                }
            }
            List<string> output = new List<string>();
            foreach (var author in formated.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                output.Add($"{author.Key} -> {author.Value:f2}");
            }
            File.WriteAllLines("../../output.txt", output);
        }
    }
}
