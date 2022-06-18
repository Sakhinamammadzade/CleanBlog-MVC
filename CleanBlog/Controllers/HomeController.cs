using CleanBlog.Data;
using CleanBlog.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataSeeding _dataSeeding;
        private readonly BlogDbContext _context;

        public HomeController(BlogDbContext context,DataSeeding dataSeeding)
        {
            _context = context;
            _dataSeeding = dataSeeding;
        }

     
      

        public IActionResult Index()
        {
            var blogs=_context.Blogs.FirstOrDefault();
           

            _dataSeeding.SeedData();
            HomeVM vm = new()
            {
                Blog = blogs,
             

            };
            return View(vm);
        }
       
    }
}
