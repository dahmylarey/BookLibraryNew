using BookLibraryNew.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryNew.Controllers
{
    public class DeleteController : Controller
    {

        public readonly BookDbContext _dbContext;

        public DeleteController(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Book = await _dbContext.Books.FindAsync(id);
            if (Book == null)
            {
                return NotFound();
            }

            _dbContext.Books.Remove(Book);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        //public ActionResult Delete(int id)
        //{
       //     _dbContext.Books.Remove(_dbContext.Books.FirstOrDefault());
          //  return View();
       // }
    }
}
