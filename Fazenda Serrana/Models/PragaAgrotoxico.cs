using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models
{
    public class PragaAgrotoxico
    {
        public virtual int IdPraga { get; set; }
        public virtual Praga Praga { get; set; }

        public virtual int IdAgrotoxico { get; set; }
        public virtual Agrotoxico Agrotoxico { get; set; }

    }
}
