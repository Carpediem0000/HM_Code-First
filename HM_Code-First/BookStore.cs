using HM_Code_First.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HM_Code_First
{
    public partial class BookStore : DbContext
    {
        public BookStore()
            : base("name=BookStore")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasRequired(p => p.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(p => p.PublisherId);

            modelBuilder.Entity<Book>()
                .HasRequired(p => p.Author)
                .WithMany(p => p.Books)
                .HasForeignKey(p => p.AuthorId);

            modelBuilder.Entity<Book>()
                .HasMany(g => g.Genre)
                .WithMany(b => b.Books).Map(bg =>
                {
                    bg.MapLeftKey("BookId");
                    bg.MapRightKey("GenreId");
                    bg.ToTable("BookGenre");
                });
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}