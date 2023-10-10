using Adetsis.IsTakip.Entities.Birimler;
using Adetsis.IsTakip.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adetsis.IsTakip.Entities.Kullanicilar
{
    public class Personel : Base
    {
        public string AdSoyad { get;set; }
        public string Email { get;set; }
        public string Telefon { get;set; }
        public string Password{ get;set; }
        public string GsmKod{ get;set; }
        public DateTime GmsKodTarih{ get;set; }
        public bool isAdmin { get;set; }
        public List<Departman> departman { get;set; }
    }
}
