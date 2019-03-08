using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirtydayApp.Models
{
    public class DavetiyeModel
    {

        [Required] //validition controlu- bos gecilemez kontrolu
        public string Ad { get; set; }
        [Required]
        public string Eposta { get; set; }
        [Required]
        public bool? KatilmaDurumu { get; set; }

    }
}