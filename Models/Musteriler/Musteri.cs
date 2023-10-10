using Adetsis.IsTakip.Entities.Model;
using Adetsis.IsTakip.Entities.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adetsis.IsTakip.Entities.Musteriler
{
    public class Musteri : Base
    {
        public string Unvan { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Vd { get; set; }
        public string VNo { get; set; }

        public List<MusteriYetkili> Yetkili { get; set; }
    }
}
