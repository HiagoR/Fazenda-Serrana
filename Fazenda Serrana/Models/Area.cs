using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models
{
    public class Area
    {
        public int Id { get; set; }
        public double Tamanho { get; set; }

        public virtual AreaCultura AreaCultura { get; set; }
        public virtual int AreaCulturaId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual int IdFuncionario { get; set; }
        public virtual Aplicacao Aplicacao { get; set; }
        //public virtual int IdAplicacao { get; set; }
    }
}
