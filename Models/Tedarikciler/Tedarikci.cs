using Adetsis.IsTakip.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adetsis.IsTakip.Entities.Tedarikciler
{
    public class Tedarikci : Base
    {
        public string Unvan {  get; set; }
        public string Adres {  get; set; }
        public string Telefon {  get; set; }
        public string Yetkili {  get; set; }
        public string Mail {  get; set; }
        public string Aciklama {  get; set; }
    }
}
