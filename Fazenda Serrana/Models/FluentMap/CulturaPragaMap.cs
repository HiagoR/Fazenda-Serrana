using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models.FluentMap
{
    public class CulturaPragaMap : IEntityTypeConfiguration<CulturaPraga>
    {
        public void Configure(EntityTypeBuilder<CulturaPraga> builder)
        {



            builder.HasKey(pragaCulturaKey => new
            {
                pragaCulturaKey.IdPraga,
                pragaCulturaKey.IdCultura
            }
            );







            builder.HasOne<Praga>(ef => ef.Praga)
             .WithMany(e => e.PragaCultura)
             .HasForeignKey(sc => sc.IdPraga);

            builder.HasOne<Cultura>(ef => ef.Cultura)
             .WithMany(e => e.CulturasPraga)
             .HasForeignKey(sc => sc.IdCultura);
        }  
    }
}
