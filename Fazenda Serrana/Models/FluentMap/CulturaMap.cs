using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models.FluentMap
{
    public class CulturaMap : IEntityTypeConfiguration<Cultura>
    {

 
        public void Configure(EntityTypeBuilder<Cultura> builder)
        {
            builder.ToTable("TB_CULTURA");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(a => a.NomeCultura)
                .IsRequired();
            builder.Property(a => a.MaximoMeses)
                .IsRequired()
                .HasColumnType("Integer")
                .HasColumnName("maxMeses");
        }
    }
}
