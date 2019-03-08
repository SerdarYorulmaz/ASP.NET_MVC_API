using BirtydayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirtydayApp.Controllers
{
    public class DavetiyeController : ApiController
    {

        [HttpGet] //Request bu methodu calistiracak burda belirtmeliyiz api mvc de direk anliyordu
        public IEnumerable<DavetiyeModel> Katilanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == true);

        }

        [HttpGet] //Request bu methodu calistiracak burda belirtmeliyiz api mvc de direk anliyordu
        public IEnumerable<DavetiyeModel> Katilmayanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == false);

        }


        [HttpPost]
        public void Ekle(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(model);
            }

            
        }
    }
}
