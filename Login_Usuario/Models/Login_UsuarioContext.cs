using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Login_Usuario.Models
{
    public partial class Login_UsuarioContext : DbContext
    {
        public Login_UsuarioContext()
        {
        }

        public Login_UsuarioContext(DbContextOptions<Login_UsuarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contraseña> Contraseña { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-FM7HKCC1; Database=Login_Usuario;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contraseña>(entity =>
            {
                entity.HasKey(e => e.Idcontraseña)
                    .HasName("PK__contrase__CB8A1A59F41CC797");

                entity.ToTable("contraseña");

                entity.Property(e => e.Idcontraseña)
                    .HasColumnName("idcontraseña")
                    .ValueGeneratedNever();

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PK__usuario__080A97432DF5E4F4");

                entity.ToTable("usuario");

                entity.Property(e => e.Idusuario)
                    .HasColumnName("idusuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.Clave).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
