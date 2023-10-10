using Adetsis.IsTakip.Entities.Birimler;
using Adetsis.IsTakip.Entities.Kullanicilar;
using Adetsis.IsTakip.Entities.Model;
using Adetsis.IsTakip.Entities.Urunler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adetsis.IsTakip.Entities.Siparisler
{
    public class Siparis : Base
    {
        public DateTime SiparisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public Urun urun { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public string Ozelllikler { get; set; }
        public Departman departman { get; set; }
        public Personel personel { get; set; }
    }
}
