using BookLibraryNew.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryNew.Controllers
{
    public class CreateController : Controller
    {
        public readonly BookDbContext _dbContext;

        public CreateController(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult Create()
        {
           // _dbContext.Books.Add();

            return View();
        }

        [HttpPost]
        public async Task<ActionResult<Book>> Create(Book Book)
        {

            _dbContext.Books.Add(Book);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Create), new { id = Book.Id }, Book);
        }




        
    }
}


