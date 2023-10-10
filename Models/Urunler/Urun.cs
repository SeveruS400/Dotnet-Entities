
using Adetsis.IsTakip.Entities.Kategoriler;
using Adetsis.IsTakip.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adetsis.IsTakip.Entities.Urunler
{
    public class Urun: Base
    {
        public string UrunAdi {  get; set; }
        public string Aciklama {  get; set; }
        public string Ozellikler {  get; set; }
        public Kategori kategori { get; set; }
    }
}
