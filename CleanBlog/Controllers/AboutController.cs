using CleanBlog.Data;
using CleanBlog.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanBlog.Controllers
{
    public class AboutController : Controller
    {
        private readonly DataSeeding _dataSeeding;
        private readonly BlogDbContext _context;

        public AboutController(BlogDbContext context, DataSeeding dataSeeding)
        {
            _context = context;
            _dataSeeding = dataSeeding;
        }

        public IActionResult About()
        {
            var abouts=_context.Abouts.FirstOrDefault();
            _dataSeeding.SeedData();
            AboutVM vm = new()
            {
                Abouts = abouts,
            };
            return View(vm);
        }

    }
}
