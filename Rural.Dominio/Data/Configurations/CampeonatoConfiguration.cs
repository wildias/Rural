using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rural.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Data.Configurations
{
    public partial class CampeonatoConfiguration : IEntityTypeConfiguration<Campeonato>
    {
        public void Configure(EntityTypeBuilder<Campeonato> entity)
        {
            entity.HasKey(e => e.IdCampeonato);

            entity.HasIndex(e => e.Descricao);

            entity.Property(e => e.DataInicio).HasColumnType("datetime");

            entity.Property(e => e.DataFinal).HasColumnType("datetime");

            entity.Property(e => e.DataCadastro).HasColumnType("datetime");

            entity.Property(e => e.IdCampeonato)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Campeonato> entity);
    }
}
