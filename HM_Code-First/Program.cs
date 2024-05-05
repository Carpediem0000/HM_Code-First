using HM_Code_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace HM_Code_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher
            {
                Name = "Example Publisher"
            };

            BookService.AddPublisher(publisher);

            var author = new Author
            {
                FirstName = "John",
                LastName = "Doe"
            };

            BookService.AddAuthor(author);

            var genres = new List<Genre>
                {
                    new Genre { Name = "Fantasy" },
                    new Genre { Name = "Science Fiction" }
                };

            foreach (var genre in genres)
            {
                BookService.AddGenre(genre);
            }

            var book1 = new Book
            {
                Name = "Example Book 1",
                Year = 2022,
                AuthorId = BookService.GetAuthorById(1).AuthorId,
                PublisherId = BookService.GetPublisherById(1).PublisherId,
                Genre = new List<Genre> { genres[0], genres[1] }
            };

            var book2 = new Book
            {
                Name = "Example Book 2",
                Year = 2023,
                AuthorId = BookService.GetAuthorById(1).AuthorId,
                PublisherId = BookService.GetPublisherById(1).PublisherId,
                Genre = new List<Genre> { genres[0] }
            };

            BookService.AddBook(book1);
            BookService.AddBook(book2);
        }
    }
}
