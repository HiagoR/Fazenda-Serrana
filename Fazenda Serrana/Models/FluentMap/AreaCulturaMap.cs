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

            builder.ToTable("TB_AREA_CULTURA");
            builder.HasKey(areaCulturaKey => new
            {
                areaCulturaKey.CulturaId,
                areaCulturaKey.AreaId
            }
            );
            builder.Property(f => f.DataInicio)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnName("DtInicio");

            builder.HasOne(ef => ef.Area)
                .WithOne(e => e.AreaCultura)
                .HasForeignKey<Area>(sc => sc.AreaCulturaId);

            builder.HasOne(ef => ef.Cultura)
                .WithOne(e => e.CulturaArea)
                .HasForeignKey<Cultura>(sc => sc.CulturaAreaId);
        }
    }
}
