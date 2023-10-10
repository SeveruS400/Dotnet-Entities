using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adetsis.IsTakip.Entities.Model
{
    public class Base
    {
        public int Id { get; set; }  
        public DateTime Create {  get; set; } = DateTime.Now;   
        public bool isActive {  get; set; }
    }
}
