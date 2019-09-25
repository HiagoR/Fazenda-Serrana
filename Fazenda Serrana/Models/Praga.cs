using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models
{
    public class Praga
    {
        public int Id { get; set; }
        public string EstacaoMaisFrequente { get; set; }
        public DateTime DataUltimaReincidencia { get; set; }
        public string NomeCientifico { get; set; }
        public string NomePopular { get; set; }

        public virtual int IdPragaAgrotoxico { get; set; }
        public virtual IList<PragaAgrotoxico> AgrotoxicosPraga { get; set; }
        public virtual int IdCulturaPraga { get; set; }
        public virtual IList<CulturaPraga> CulturasPraga { get; set; }

    }
}
