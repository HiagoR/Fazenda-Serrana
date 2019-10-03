using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models.FluentMap
{
    public class AreaMap : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.ToTable("TB_AREA");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(a => a.Tamanho)
                .IsRequired();

            builder.HasOne(a => a.Funcionario)
                 .WithMany(f => f.AreasResponsaveis)
                 .HasForeignKey(k => k.IdFuncionario);

            //builder.HasOne(a => a.AreaCultura)
            //      .WithOne(f => f.Area)
            //      .HasForeignKey<AreaCultura>(k => k.IdArea);
            
            builder.HasOne(a => a.Aplicacao)
                  .WithOne(f => f.Area)
                  .HasForeignKey<Aplicacao>(k => k.AreaId);



        }
    }
}
