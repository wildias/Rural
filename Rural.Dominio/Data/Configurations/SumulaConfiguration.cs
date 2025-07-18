using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rural.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Data.Configurations
{
    public partial class SumulaConfiguration : IEntityTypeConfiguration<Sumula>
    {
        public void Configure(EntityTypeBuilder<Sumula> entity)
        {
            entity.HasKey(e => e.IdSumula);

            entity.HasIndex(e => e.IdCampeonato);

            entity.HasIndex(e => e.IdJogos);

            entity.HasIndex(e => e.Observacao);

            entity.Property(e => e.Data).HasColumnType("datetime");

            entity.Property(e => e.IdSumula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.IdCampeonato)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.IdJogos)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Observacao)
                .HasColumnType("varchar(max)")
                .IsUnicode(false);

            entity.HasOne(d => d.IdCampeonatoNavigation)
                .WithMany(p => p.Sumula)
                .HasForeignKey(d => d.IdCampeonato)
                .HasConstraintName("FK_Sumula_Campeonato");

            entity.HasOne(d => d.IdJogosNavigation)
                .WithMany(p => p.Sumula)
                .HasForeignKey(d => d.IdJogos)
                .HasConstraintName("FK_Sumula_Jogos");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Sumula> entity);
    }
}
