using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes.Context;
using MvcOnlineTicariOtomasyon.Services;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class CariPanelController(OtomasyonContext c, SessionService sessionService) : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            var mail = sessionService.GetSessionValue("cariMail");
            var degerler = c.Cari.FirstOrDefault(x => x.CariMail == mail);
            ViewBag.m = mail;

            return View(degerler);
        }

        [Authorize]
        public IActionResult Siparislerim()
        {
            var mail = sessionService.GetSessionValue("cariMail");
            var id = c.Cari.Where(x => x.CariMail == mail).Select(y => y.CariId).FirstOrDefault();
            var degerler = c.SatisHareketleri.Where(x => x.CariId == id).ToList();

            return View(degerler);
        }
    }
}
