using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Book_Library_Modification
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
        static Book ReadBook(string fileInput)
        {
            string[] input = fileInput.Split().ToArray();
            Book newBook = new Book();
            newBook.Title = input[0];
            newBook.Author = input[1];
            newBook.Publisher = input[2];
            newBook.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            newBook.ISBN = input[4];
            newBook.Price = decimal.Parse(input[5]);
            return (newBook);
        }
        static void Main(string[] args)
        {
            string[] inputf = File.ReadAllLines("../../input.txt");
            int indexer = 0;
            int bookCount = int.Parse(inputf[indexer++]);
            Library biblioteka = new Library() { Name = "Biblioteka", Books = new List<Book>() };
            for (int i = 0; i < bookCount; i++)
            {
                biblioteka.Books.Add(ReadBook(inputf[indexer++]));
            }
            DateTime date = DateTime.ParseExact(inputf[indexer++], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Dictionary<string, DateTime> formated = new Dictionary<string, DateTime>();
            foreach (var book in biblioteka.Books)
            {
                if (date < book.ReleaseDate)
                {
                    formated.Add(book.Title, book.ReleaseDate);
                }
            }
            List<string> output = new List<string>();
            foreach (var book in formated.OrderBy(x => x.Value).ThenBy(y => y.Key))
            {
                output.Add($"{book.Key} -> {book.Value:dd.MM.yyyy}");
            }
            File.WriteAllLines("../../output.txt", output);
        }
    }
}
