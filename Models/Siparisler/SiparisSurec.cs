using Adetsis.IsTakip.Entities.Kullanicilar;
using Adetsis.IsTakip.Entities.Model;
using Adetsis.IsTakip.Entities.Tedarikciler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adetsis.IsTakip.Entities.Siparisler
{
    public class SiparisSurec : Base
    {
        public Personel personel { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int siparisSurec { get; set; }
        public string SurecDurumAciklama { get; set; }
        public string SurecAktarimAciklama { get; set; }
        public bool isClosed { get; set; }
        public bool isTedarik { get; set; }
        public Tedarikci tedarikci{ get; set; }
    }
}
