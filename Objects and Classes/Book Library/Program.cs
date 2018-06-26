using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static Book ReadBook()
        {
            string[] input = Console.ReadLine().Split().ToArray();
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
            int bookCount = int.Parse(Console.ReadLine());
            Library biblioteka = new Library() { Name="Biblioteka",Books=new List<Book>()};
            for (int i = 0; i < bookCount; i++)
            {
               biblioteka.Books.Add(ReadBook());
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
            foreach (var author in formated.OrderByDescending(x=>x.Value).ThenBy(y=>y.Key))
            {
                Console.WriteLine("{0} -> {1:f2}",author.Key,author.Value);
            }
        }
    }
}
