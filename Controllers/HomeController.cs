using BlogShare.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogShare.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var lastPost = await _context.Posts.OrderBy(x => x.Id).LastOrDefaultAsync();
            if (lastPost == null)
            {
                return NotFound();
            }
            var feeds=_context.Posts.OrderBy(x=>Guid.NewGuid()).Take(6).ToList();
            ViewBag.feeds = feeds;
            return View(lastPost);
        }
        public IActionResult About()=> View();
        public IActionResult Contact() => View();
    }
}
