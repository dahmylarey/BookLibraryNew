using BookLibraryNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookLibraryNew.Controllers
{
    public class HomeController : Controller
    {
     
        public readonly BookDbContext _dbContext;

         public HomeController(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

      

        public ActionResult Index()
        {
            //IEnumerable<Book> Books = _dbContext.Books.ToList();

            return View();

            var item = _dbContext.Books.ToList();
            // return View();

        }

     
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]


        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
