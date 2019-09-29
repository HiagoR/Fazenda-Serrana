

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models.FluentMap
{
    public class PragasMap : IEntityTypeConfiguration<Praga>
    {
        public void Configure(EntityTypeBuilder<Praga> builder)
        {
        //        public int Id { get; set; }
        //public string EstacaoMaisFrequente { get; set; }
        //public DateTime DataUltimaReincidencia { get; set; }
        //public string NomeCientifico { get; set; }
        //public string NomePopular { get; set; }



        builder.ToTable("TB_PRAGA");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id)
                .ValueGeneratedNever()
                .IsRequired();
            builder.Property(a => a.EstacaoMaisFrequente)
               .IsRequired()
               .HasColumnType("varchar(200)")
               .HasColumnName("EstacaoFrequente");
             builder.Property(a => a.DataUltimaReincidencia)
               .IsRequired()
               .HasColumnType("date")
               .HasColumnName("DtUltimaReincidencia");
             builder.Property(a => a.NomeCientifico)
               .IsRequired()
               .HasColumnType("varchar(200)")
               .HasColumnName("NomeCientifico");
             builder.Property(a => a.NomePopular)
               .IsRequired()
               .HasColumnType("varchar(200)")
               .HasColumnName("NomePopular");

        }
    }
}
