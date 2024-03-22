using BookLibraryNew.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryNew.Controllers
{
    public class EditController : Controller
    {
        public readonly BookDbContext _dbContext;

        public EditController(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _dbContext.Books.Where(x => x.Id == id);

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Book model)
        {
            var data = _dbContext.Books.Where(x => x.Id == model.Id).FirstOrDefault();
            if (data != null)
            {
                data.Title = model.Title;
                data.Author = model.Author;
                data.Genre = model.Genre;
                data.PublishYear = model.PublishYear;
            }

            return View();
        }
    }
}
