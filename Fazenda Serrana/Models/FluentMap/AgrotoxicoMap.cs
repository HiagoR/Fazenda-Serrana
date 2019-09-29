using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models.FluentMap
{
    public class AgrotoxicoMap : IEntityTypeConfiguration<Agrotoxico>
    {
        public void Configure(EntityTypeBuilder<Agrotoxico> builder)
        {


        builder.ToTable("TB_AGROTOXICO");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id)
                .ValueGeneratedNever()
                .IsRequired();
            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)")
                .HasColumnName("Nome");
            builder.Property(a => a.QtdDisponivel)
                .IsRequired()
                .HasColumnType("number")
                .HasColumnName("QtdDisponivel");
            builder.Property(a => a.UnidadeMedida)
                .IsRequired()
                .HasColumnType("varchar(200)")
                .HasColumnName("UnidadeMedida");


        }
    }
}
