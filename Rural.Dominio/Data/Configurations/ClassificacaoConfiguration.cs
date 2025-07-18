using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rural.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Data.Configurations
{
    public partial class ClassificacaoConfiguration : IEntityTypeConfiguration<Classificacao>
    {
        public void Configure(EntityTypeBuilder<Classificacao> entity)
        {
            entity.HasKey(e => e.IdClassificacao);

            entity.HasIndex(e => e.IdCampeonato);

            entity.HasIndex(e => e.IdClube);

            entity.Property(e => e.UltimaAtualizacao).HasColumnType("datetime");

            entity.Property(e => e.SaldoGols).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.GolsPro).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.GolsContra).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.CartaoAmarelo).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.CartaoVermelho).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.Vitoria).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.Empate).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.Derrota).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.IdClassificacao)
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

            entity.HasOne(d => d.IdCampeonatoNavigation)
                .WithMany(p => p.Classificacao)
                .HasForeignKey(d => d.IdCampeonato)
                .HasConstraintName("FK_Classificacao_Campeonato");

            entity.HasOne(d => d.IdClubeNavigation)
                .WithMany(p => p.Classificacao)
                .HasForeignKey(d => d.IdClube)
                .HasConstraintName("FK_Classificacao_Clube");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Classificacao> entity);
    }
}
