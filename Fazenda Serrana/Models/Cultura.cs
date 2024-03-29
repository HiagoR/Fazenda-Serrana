﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models
{
    public class Cultura
    {
        public int Id { get; set; }
        public string NomeCultura { get; set; }
        public int MaximoMeses { get; set; }

        public virtual AreaCultura CulturaArea { get; set; }
        public virtual int CulturaAreaId { get; set; }
        public virtual int IdCulturaPraga { get; set; }
        public virtual IList<CulturaPraga> CulturasPraga { get; set; }

    }
}
