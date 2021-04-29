using IFoundit.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
