using Microsoft.EntityFrameworkCore;
using Rural.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rural.Dominio.Data
{
    public partial class RuralContext : DbContext
    {
        public virtual DbSet<Campeonato> Campeonato { get; set; }
        public virtual DbSet<Clube> Clube { get; set; }
        public virtual DbSet<Estadio> Estadio { get; set; }
        public virtual DbSet<InfoCampeonato> InfoCampeonato { get; set; }
        public virtual DbSet<Jogador> Jogador { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }


        public string _stringConexao = "Data Source=.\\SQLEXPRESS;Initial Catalog=RURAL;Integrated Security=True;Trust Server Certificate=True;Command Timeout=300";

        public RuralContext(DbContextOptions<RuralContext> options) : base(options)
        {

        }

        public RuralContext()
        {

        }

        public RuralContext(string stringConexao)
        {
            if (!string.IsNullOrEmpty(stringConexao)) _stringConexao = stringConexao;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (string.IsNullOrEmpty(_stringConexao)) _stringConexao = "Data Source=.\\SQLEXPRESS;Initial Catalog=RURAL;Integrated Security=True;Trust Server Certificate=True;Command Timeout=300";
                optionsBuilder.UseSqlServer(_stringConexao);
                //optionsBuilder.UseMySql(_stringConexao);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.ApplyConfiguration(new Configurations.CampeonatoConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ClubeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.EstadioConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.InfoCampeonatoConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.JogadorConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UsuarioConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
