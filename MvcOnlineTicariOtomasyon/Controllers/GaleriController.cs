using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Data.Contexts;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class GaleriController : Controller
    {
        private readonly OtomasyonContext c;

        public GaleriController(OtomasyonContext c)
        {
            this.c = c;
        }

        public IActionResult Index()
        {
            var degerler = c.Urun.ToList();

            return View(degerler);
        }
    }
}
