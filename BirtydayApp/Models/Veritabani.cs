using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirtydayApp.Models
{
    public static class Veritabani
    {
        //static yaptik


        private static Dictionary<string, DavetiyeModel> _liste; //her bir elemana bir tane key(Ad) vermek

        static Veritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();

            _liste.Add("Serdar", new DavetiyeModel
            {
                Ad = "Serdar",
                Eposta = "Serdar@gmail.com",
                KatilmaDurumu = true
            });

            _liste.Add("Ebubekir", new DavetiyeModel
            {
                Ad = "Ebubekir",
                Eposta = "Ebubekir@gmail.com",
                KatilmaDurumu = false
            });

            _liste.Add("Derin", new DavetiyeModel
            {
                Ad = "Derin",
                Eposta = "Derin@gmail.com",
                KatilmaDurumu = true
            });

        }

        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key)) //liste boyle bir kayit var mi
            {
                _liste[key] = model; //varsa eski kayitla yerdegistircek
            }
            else
            {
                _liste.Add(key, model); //yoksa yeni kayit eklenecek
            }
        }

        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _liste.Values; } //disardan istedigimiz elemani  get ile bize getirecek
        }
    }
}