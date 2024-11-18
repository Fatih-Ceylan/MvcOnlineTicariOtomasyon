using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class CariPanelController(OtomasyonContext c) : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
