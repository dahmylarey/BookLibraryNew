using System.ComponentModel.DataAnnotations;

namespace BookLibraryNew.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string PublishYear { get; set; }

        IEnumerable<Book> Books { get; set; }
        
        //IQueryable<Book> Books { get; set; }

        public ICollection<Book> books { get; set; }
    }
}
