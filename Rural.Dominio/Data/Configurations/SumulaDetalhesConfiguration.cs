using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rural.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Data.Configurations
{
    public partial class SumulaDetalhesConfiguration : IEntityTypeConfiguration<SumulaDetalhes>
    {
        public void Configure(EntityTypeBuilder<SumulaDetalhes> entity)
        {
            entity.HasKey(e => e.IdSumulaDetalhes);

            entity.HasIndex(e => e.IdSumula);

            entity.HasIndex(e => e.IdClube);

            entity.HasIndex(e => e.IdJogador);

            entity.Property(e => e.Gols).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.CartaoAmarelo).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.CartaoVermelho).HasColumnType("decimal(18, 6)");

            entity.Property(e => e.IdSumulaDetalhes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.IdSumula)
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

            entity.HasOne(d => d.IdSumulaNavigation)
                .WithMany(p => p.SumulaDetalhes)
                .HasForeignKey(d => d.IdSumula)
                .HasConstraintName("FK_SumulaDetalhes_Sumula");

            entity.HasOne(d => d.IdClubeNavigation)
                .WithMany(p => p.SumulaDetalhes)
                .HasForeignKey(d => d.IdClube)
                .HasConstraintName("FK_SumulaDetalhes_Clube");

            entity.HasOne(d => d.IdJogadorNavigation)
                .WithMany(p => p.SumulaDetalhes)
                .HasForeignKey(d => d.IdJogador)
                .HasConstraintName("FK_SumulaDetalhes_Jogador");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SumulaDetalhes> entity);
    }
}
