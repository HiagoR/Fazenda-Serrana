using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models.FluentMap
{
    public class PragaAgrotoxicoMap : IEntityTypeConfiguration<PragaAgrotoxico>
    {
        public void Configure(EntityTypeBuilder<PragaAgrotoxico> builder)
        {



            builder.HasKey(pragaAgrotoxicoKey => new
            {
                pragaAgrotoxicoKey.IdAgrotoxico,
                pragaAgrotoxicoKey.IdPraga
            }
            );







            builder.HasOne<Praga>(ef => ef.Praga)
             .WithMany(e => e.AgrotoxicosPraga)
             .HasForeignKey(sc => sc.IdPraga);

            builder.HasOne<Agrotoxico>(ef => ef.Agrotoxico)
             .WithMany(e => e.PragasAgrotoxicos)
             .HasForeignKey(sc => sc.IdAgrotoxico);



        }
    }
}
