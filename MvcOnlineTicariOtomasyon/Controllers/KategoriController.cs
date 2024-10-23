using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class KategoriController : Controller
    {
        private readonly OtomasyonContext _context;

        public KategoriController(OtomasyonContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Kategori.ToList();
            return View(values);
        }
    }
}
