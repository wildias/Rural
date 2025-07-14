using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rural.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Data.Configurations
{
    public partial class EstadioConfiguration : IEntityTypeConfiguration<Estadio>
    {
        public void Configure(EntityTypeBuilder<Estadio> entity)
        {
            entity.HasKey(e => e.IdEstadio);

            entity.HasIndex(e => e.Descricao);

            entity.Property(e => e.DataCadastro).HasColumnType("datetime");

            entity.HasIndex(e => e.Localidade);

            entity.Property(e => e.IdEstadio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Localidade)
                .HasMaxLength(200)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Estadio> entity);
    }
}
