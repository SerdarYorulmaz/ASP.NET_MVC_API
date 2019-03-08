using BirtydayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirtydayApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DavetiyeFormu() //get
        {
            return View();
        }
        [HttpPost]
        public ActionResult DavetiyeFormu(DavetiyeModel model) //cektigimiz verileri buraya getirecez
        {
            if(ModelState.IsValid) // DavetiyeModeldeki validition controllerinin saglanip saglanmadigina bakar
            {
                Veritabani.Add(model);
                return View("Thanks",model);
            }


            return View(model); //validition uymuyorsa  form uzerinde olmaya devam etsin
        }

        [ChildActionOnly] //url uzerinden cagirilamaz 
        public ActionResult Katilanlar()
        {
            var katilan = Veritabani.Liste.Where(i => i.KatilmaDurumu == true);

            return PartialView(katilan);
        }

    }
}