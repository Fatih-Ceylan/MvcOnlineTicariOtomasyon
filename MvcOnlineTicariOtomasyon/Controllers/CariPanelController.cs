using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class CariPanelController(OtomasyonContext c) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
