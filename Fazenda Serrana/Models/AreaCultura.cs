using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models
{
    public class AreaCultura
    {
        public virtual Area Area { get; set; }
        public virtual int IdArea { get; set; }
        public virtual Cultura Cultura { get; set; }
        public virtual int IdCultura { get; set; }

        public DateTime DataInicio { get; set; }
    }
}
