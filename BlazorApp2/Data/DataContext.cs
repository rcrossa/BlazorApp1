using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=tareas.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
                .Property(p => p.clave);
            modelBuilder.Entity<Tarea>()
                .ToTable("Tarea");
            modelBuilder.Entity<TipoTarea>()
                .ToTable("TipoTarea");
            modelBuilder.Entity<Recurso>()
                .ToTable("Recurso");
            modelBuilder.Entity<Detalle>()
                .ToTable("Detalle");
        }
        //siguiente linea es para poder ingresar los usuarios declarados en el program.cs
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        
        public DbSet<TipoTarea>TipoTareas { get; set; }

        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
    }
}
