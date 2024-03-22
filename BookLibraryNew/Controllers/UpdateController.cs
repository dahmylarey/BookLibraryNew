using Microsoft.AspNetCore.Mvc;

namespace BookLibraryNew.Controllers
{
    public class UpdateController : Controller
    {
        public readonly BookDbContext _dbContext;

        public UpdateController(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public ActionResult Update(int id)
        {
            var model = _dbContext.Books.Where(x => x.Id == id).FirstOrDefault();

            _dbContext.Books.Update(model);

            _dbContext.SaveChanges();


            return View();
        }
    }
}
