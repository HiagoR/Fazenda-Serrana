using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models
{
    public class CulturaPraga
    {
        public virtual int IdCultura { get; set; }
        public virtual Cultura Cultura { get; set; }
        public virtual int IdPraga { get; set; }
        public virtual Praga Praga { get; set; }
    }
}
