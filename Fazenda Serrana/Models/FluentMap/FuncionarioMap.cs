using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fazenda_Serrana.Models.FluentMap
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("TB_FUNCIONARIO");

            builder.HasKey(f => f.Matricula);
            builder.Property(f => f.Matricula)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(f => f.Nome)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(f => f.DataAdmissao)
                .IsRequired();

            builder.Property(f => f.Cargo)
                .IsRequired();

            
        }

    }
}
