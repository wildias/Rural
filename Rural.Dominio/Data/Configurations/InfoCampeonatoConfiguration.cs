using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rural.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Data.Configurations
{
    public partial class InfoCampeonatoConfiguration : IEntityTypeConfiguration<InfoCampeonato>
    {
        public void Configure(EntityTypeBuilder<InfoCampeonato> entity)
        {
            entity.HasKey(e => e.IdInfoCampeonato);

            entity.HasIndex(e => e.IdCampeonato);

            entity.HasIndex(e => e.IdClube);

            entity.HasIndex(e => e.IdJogador);

            entity.Property(e => e.Gols).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.CartaoAmarelo).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.CartaoVermelho).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.IdInfoCampeonato)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.IdCampeonato)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.IdClube)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.IdJogador)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.HasOne(d => d.IdCampeonatoNavigation)
                .WithMany(p => p.InfoCampeonato)
                .HasForeignKey(d => d.IdCampeonato)
                .HasConstraintName("FK_InfoCampeonato_Campeonato");

            entity.HasOne(d => d.IdClubeNavigation)
                .WithMany(p => p.InfoCampeonato)
                .HasForeignKey(d => d.IdClube)
                .HasConstraintName("FK_InfoCampeonato_Clube");

            entity.HasOne(d => d.IdJogadorNavigation)
                .WithMany(p => p.InfoCampeonato)
                .HasForeignKey(d => d.IdJogador)
                .HasConstraintName("FK_InfoCampeonato_Jogador");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<InfoCampeonato> entity);
    }
}
