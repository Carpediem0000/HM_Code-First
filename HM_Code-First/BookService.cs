using HM_Code_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Publisher = HM_Code_First.Models.Publisher;

namespace HM_Code_First
{
    public static class BookService
    {
        //Book CRUD
        public static void AddBook(Book book)
        {
            using (var db = new BookStore())
            {
                var existingGenres = new List<Genre>();
                foreach (var genre in book.Genre)
                {
                    var existingGenre = db.Genres.FirstOrDefault(g => g.Name == genre.Name);
                    if (existingGenre == null)
                    {
                        existingGenre = new Genre { Name = genre.Name };
                        db.Genres.Add(existingGenre);
                    }
                    existingGenres.Add(existingGenre);
                }

                book.Genre = existingGenres;

                db.Books.Add(book);
                db.SaveChanges();
            }
        }
        public static void DeleteBook(Book book)
        {
            using (var db = new BookStore())
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }
        public static Book GetBookById(int id)
        {
            Book book = null;
            using (var db = new BookStore())
            {
                book = db.Books.FirstOrDefault(b => b.BookId == id);
            }
            return book;
        }
        public static List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            using (var db = new BookStore())
            {
                books = db.Books.ToList();
            }
            return books;
        }

        //Publisher CRUD
        public static void AddPublisher(Publisher publisher)
        {
            using (var db = new BookStore())
            {
                db.Publishers.Add(publisher);
                db.SaveChanges();
            }
        }
        public static void DeletePublisher(Publisher publisher)
        {
            using (var db = new BookStore())
            {
                db.Publishers.Remove(publisher);
                db.SaveChanges();
            }
        }
        public static Publisher GetPublisherById(int id)
        {
            Publisher publishers = null;
            using (var db = new BookStore())
            {
                publishers = db.Publishers.FirstOrDefault(b => b.PublisherId == id);
            }
            return publishers;
        }
        public static List<Publisher> GetAllPublisher()
        {
            List<Publisher> publishers = new List<Publisher>();
            using (var db = new BookStore())
            {
                publishers = db.Publishers.ToList();
            }
            return publishers;
        }

        //Author CRUD
        public static void AddAuthor(Author author)
        {
            using (var db = new BookStore())
            {
                db.Authors.Add(author);
                db.SaveChanges();
            }
        }
        public static void DeleteAuthor(Author author)
        {
            using (var db = new BookStore())
            {
                db.Authors.Remove(author);
                db.SaveChanges();
            }
        }
        public static Author GetAuthorById(int id)
        {
            Author author = null;
            using (var db = new BookStore())
            {
                author = db.Authors.FirstOrDefault(b => b.AuthorId == id);
            }
            return author;
        }
        public static List<Author> GetAllAuthor()
        {
            List<Author> author = new List<Author>();
            using (var db = new BookStore())
            {
                author = db.Authors.ToList();
            }
            return author;
        }

        //Genre CRUD
        public static void AddGenre(Genre genre)
        {
            using (var db = new BookStore())
            {
                db.Genres.Add(genre);
                db.SaveChanges();
            }
        }
        public static void DeleteGenre(Genre genre)
        {
            using (var db = new BookStore())
            {
                db.Genres.Remove(genre);
                db.SaveChanges();
            }
        }
        public static Genre GetGenreById(int id)
        {
            Genre genre = null;
            using (var db = new BookStore())
            {
                genre = db.Genres.FirstOrDefault(b => b.GenreId == id);
            }
            return genre;
        }
        public static List<Genre> GetAllGenre()
        {
            List<Genre> genres = new List<Genre>();
            using (var db = new BookStore())
            {
                genres = db.Genres.ToList();
            }
            return genres;
        }
    }
}
