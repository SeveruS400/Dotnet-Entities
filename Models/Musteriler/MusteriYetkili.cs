using Adetsis.IsTakip.Entities.Birimler;
using Adetsis.IsTakip.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adetsis.IsTakip.Entities.Musteriler
{
    public class MusteriYetkili : Base
    {
        public string AdSoyad { get; set; }
        public string Gsm { get; set; }
        public string Mail { get; set; }
        public string Görev { get; set; }
        public Musteri musteri { get; set; }
        public Departman departman { get; set; }

    }
}
