using CrudExamenn.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudExamenn.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<EjercicioExamenSocio> Socio { get; set; }
        public virtual DbSet<ClaseCuenta> Cuenta { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<EjercicioExamenSocio>(ent => 
            {
                ent.HasKey(f => f.Cedula);

                ent.Property(f => f.Nombre)
               // .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

                ent.Property(f => f.Apellido)
                // .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false); 

                ent.Property(f => f.Direccion)
               // .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

                ent.Property(f => f.Estado);
               // .IsRequired()
                // .HasMaxLength(250)
                // .IsUnicode(false); 


            });
            builder.Entity<ClaseCuenta>(ent =>
            {
                ent.HasKey(f => f.numero);

                ent.Property(f => f.saldototal)
              //  .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

                ent.Property(f => f.CodigoSocio)
                // .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

                ent.Property(f => f.estado);
              //.IsRequired();

            });

        }

    }
}
