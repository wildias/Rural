using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rural.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Data.Configurations
{
    public partial class ClubeConfiguration : IEntityTypeConfiguration<Clube>
    {
        public void Configure(EntityTypeBuilder<Clube> entity)
        {
            entity.HasKey(e => e.IdClube);

            entity.HasIndex(e => e.Descricao);

            entity.Property(e => e.DataCadastro).HasColumnType("datetime");

            entity.HasIndex(e => e.Tecnico);

            entity.HasIndex(e => e.Auxiliar);

            entity.HasIndex(e => e.Massagista);

            entity.HasIndex(e => e.IdEstadio);

            entity.Property(e => e.IdClube)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Tecnico)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Auxiliar)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Imagem)
                .IsUnicode(false);

            entity.Property(e => e.Massagista)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IdEstadio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.HasOne(d => d.IdEstadioNavigation)
                .WithMany(p => p.Clube)
                .HasForeignKey(d => d.IdEstadio)
                .HasConstraintName("FK_Clube_Estadio");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Clube> entity);
    }
}
