using Adetsis.IsTakip.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adetsis.IsTakip.Entities.Kullanicilar
{
    public class PersonelYetki : Base
    {
        public Personel personel {  get; set; }
        public int  personelYetki {  get; set; }
        
    }
}
