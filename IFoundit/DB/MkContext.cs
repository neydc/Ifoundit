using IFoundit.Models;
using Microsoft.EntityFrameworkCore;

namespace IFoundit.DB.Maps
{
    public class MkContext:DbContext
    {
        public MkContext(DbContextOptions<MkContext> options) : base(options)
        {

        }
        public MkContext()
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Objeto> Objetos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ObjetoMap());
        }
    }
}
