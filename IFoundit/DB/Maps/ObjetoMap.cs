using IFoundit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFoundit.DB.Maps
{
    public class ObjetoMap : IEntityTypeConfiguration<Objeto>
    {
        public void Configure(EntityTypeBuilder<Objeto> builder)
        {
            builder.ToTable("Objeto");
            builder.HasKey(a => a.Id);
        }

        
    }
}
