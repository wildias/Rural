using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rural.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Data.Configurations
{
    public partial class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            entity.HasKey(e => e.IdUsuario);

            entity.Property(e => e.Login)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Senha)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Usuario> entity);
    }
}
