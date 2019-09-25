using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models
{
    public class Funcionario
    {
        public int Matricula { get; set; }
        public int Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Cargo { get; set; }

        public virtual int IdArea { get; set; }
        public virtual IList<Area> AreasResponsaveis { get; set; }
    }
}
