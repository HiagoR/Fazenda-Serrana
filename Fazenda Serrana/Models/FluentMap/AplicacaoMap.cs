using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models.FluentMap
{
    public class AplicacaoMap : IEntityTypeConfiguration<Aplicacao>
    {
        public void Configure(EntityTypeBuilder<Aplicacao> builder)
        {


        builder.ToTable("TB_APLICACAO");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id)
                .ValueGeneratedNever()
                .IsRequired();
            builder.Property(a => a.Tipo)
                .IsRequired()
                .HasColumnType("bit")
                .HasColumnName("Tipo");
            builder.Property(a => a.DataAplicacao)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnName("DtAplicacao");
            builder.Property(a => a.QtdAplicada)
                .IsRequired()
                .HasColumnType("number")
                .HasColumnName("QtdAplicada");


            builder.HasOne(a => a.Agrotoxico)
                .WithOne(f => f.Aplicacao)
                .HasForeignKey<Aplicacao>(k => k.IdAgrotoxico);


        }
    }
}
