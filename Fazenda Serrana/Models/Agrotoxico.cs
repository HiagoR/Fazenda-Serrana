using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models
{
    public class Agrotoxico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double QtdDisponivel { get; set; }
        public string UnidadeMedida { get; set; }

        //public int AplicacaoId { get; set; }
        public Aplicacao Aplicacao { get; set; }
        public virtual int IdPragaAgrotoxico { get; set; }
        public virtual IList<PragaAgrotoxico> PragasAgrotoxicos { get; set; }



    }
}
