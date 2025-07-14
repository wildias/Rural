using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rural.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Data.Configurations
{
    public partial class JogadorConfiguration : IEntityTypeConfiguration<Jogador>
    {
        public void Configure(EntityTypeBuilder<Jogador> entity)
        {
            entity.HasKey(e => e.IdJogador);

            entity.HasIndex(e => e.Nome);

            entity.Property(e => e.DataCadastro).HasColumnType("datetime");

            entity.Property(e => e.DataNascimento).HasColumnType("datetime");

            entity.HasIndex(e => e.IdClube);

            entity.Property(e => e.IdJogador)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IdClube)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Imagem)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClubeNavigation)
                .WithMany(p => p.Jogador)
                .HasForeignKey(d => d.IdClube)
                .HasConstraintName("FK_Jogador_Clube");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Jogador> entity);
    }
}
