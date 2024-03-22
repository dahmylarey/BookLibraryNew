using BookLibraryNew.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
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


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> Index()
        {
            return await _dbContext.Books.ToListAsync();
        }


       

     
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]


        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}



