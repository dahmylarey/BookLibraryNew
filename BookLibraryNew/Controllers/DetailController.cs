using Microsoft.AspNetCore.Mvc;

namespace BookLibraryNew.Controllers
{
    public class DetailController : Controller
    {
        public readonly BookDbContext _dbContext;

        public DetailController(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public ActionResult Detail(int id)
        {
            var Book = _dbContext.Books.ToList();

            ViewBag.Title = "Eternal Secred King";
             ViewBag.Genre = "Action";
             ViewBag.PublishYear = DateTime.Now;

            return View();
           
        }
    }
}
