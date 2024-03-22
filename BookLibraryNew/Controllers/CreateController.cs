using BookLibraryNew.Models;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult Create(Book model)
        {
            _dbContext.Books.Add(model);
            _dbContext.SaveChanges();
            ViewBag.Message = "Data Insert Successfully";

            return View();
        }
    }
}
