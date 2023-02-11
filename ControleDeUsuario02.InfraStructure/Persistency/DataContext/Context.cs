using ControleDeUsuario02.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace ControleDeUsuario02.InfraStructure.Persistency.DataContext {
    public class Context : DbContext {

        public DbSet<User>? Users { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Project>? Projects { get; set; }
        public DbSet<ReembolsoDeslocamento>? ReembolsosDeslocamento { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }

        public Context() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=localhost;DataBase=ControleDeUsuario02;User=sa;password=527!m3uP@ssword;TrustServerCertificate=True;");
        }
    }
}
