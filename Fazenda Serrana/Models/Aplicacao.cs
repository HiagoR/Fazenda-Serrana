using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models
{
    public class Aplicacao
    {
        public int Id { get; set; }
        //o atributo tipo serve como FLAG indicando se aplicacao foi preventiva ou corretiva
        public char Tipo { get; set; }
        public DateTime DataAplicacao { get; set; }
        public double QtdAplicada { get; set; }

        public int AreaId { get; set; }
        public virtual Area Area { get; set; }
        public int AgrotoxicoId { get; set; }
        public virtual Agrotoxico Agrotoxico { get; set; }

    }
}
