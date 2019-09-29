using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models.FluentMap
{
    public class AreaCulturaMap : IEntityTypeConfiguration<AreaCultura>
    {
        public void Configure(EntityTypeBuilder<AreaCultura> builder)
        {



            builder.HasKey(areaCulturaKey => new
            {
                areaCulturaKey.IdCultura,
                areaCulturaKey.IdArea
            }
            );
            builder.Property(f => f.DataInicio)
             .IsRequired()
             .HasColumnType("date")
             .HasColumnName("DtInicio") ;







            builder.HasOne<Area>(ef => ef.Area)
             .WithOne(e => e.AreaCultura)
             .HasForeignKey<AreaCultura>(sc => sc.IdArea);

            builder.HasOne<Cultura>(ef => ef.Cultura)
             .WithOne(e => e.CulturaArea)
             .HasForeignKey<AreaCultura>(sc => sc.IdCultura);
        }
    }
}
