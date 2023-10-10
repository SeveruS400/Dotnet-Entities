using Adetsis.IsTakip.Entities.Kullanicilar;
using Adetsis.IsTakip.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adetsis.IsTakip.Entities.Siparisler
{
    public class SiparisDosya : Base
    {
        public string DosyaAdi {  get; set; }
        public string DosyaTip {  get; set; }
        public string DosyaYol {  get; set; }
        public decimal DosyaBoyutMb {  get; set; }
        public Personel personel {  get; set; }
        SiparisSurec siparisSurec { get; set; }
    }
}
