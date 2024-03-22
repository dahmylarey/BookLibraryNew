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

        public ActionResult Delete(int id)
        {
            _dbContext.Books.Remove(_dbContext.Books.FirstOrDefault());
            return View();
        }
    }
}
