using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rural.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Data.Configurations
{
    public partial class JogosConfiguration : IEntityTypeConfiguration<Jogos>
    {
        public void Configure(EntityTypeBuilder<Jogos> entity)
        {
            entity.HasKey(e => e.IdJogos);

            entity.HasIndex(e => e.IdCampeonato);

            entity.Property(e => e.Data).HasColumnType("datetime");

            entity.Property(e => e.IdJogos)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.IdCampeonato)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.IdClubeCasa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.IdClubeVisitante)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.HasOne(d => d.IdCampeonatoNavigation)
                .WithMany(p => p.Jogos)
                .HasForeignKey(d => d.IdCampeonato)
                .HasConstraintName("FK_Jogos_Campeonato");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Jogos> entity);
    }
}
