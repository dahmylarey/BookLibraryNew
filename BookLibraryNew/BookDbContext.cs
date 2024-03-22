using BookLibraryNew.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BookLibraryNew
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Book> Books { get; set; } = null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "server=DAMILARELAPPY;Database=BookLibraryNew_DB;Trusted_connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Title = "Eternal secred king",
                Author =  "Damilare oladele",
                Genre = "Asian",
                PublishYear = "2024"
            },


            new Book
            {
                Id = 2,
                Title = "Legend of swordsMan",
                Author = "James wood",
                Genre = "Cultivation",
                PublishYear = "2023"
            },

              new Book
              {
                  Id = 3,
                  Title = "Walker of Worlds",
                  Author = "muller james",
                  Genre = "Cultivation",
                  PublishYear = "2023"
              },

               new Book
              {
                  Id = 4,
                  Title = "Emperor Dominations",
                  Author = "Ibrahim Oloto",
                  Genre = "Cultivation",
                  PublishYear = "2023"
              },
                   new Book
                   {
                       Id = 5,
                       Title = "Loaded With Persive Skills",
                       Author = "chen Ming",
                       Genre = "Asian",
                       PublishYear = "2024"
           });
        }

    }
}
