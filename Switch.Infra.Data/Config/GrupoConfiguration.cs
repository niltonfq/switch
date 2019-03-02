using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public GrupoConfiguration()
        {

        }

        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Descricao).IsRequired().HasMaxLength(100);
            builder.Property(p => p.UrlFoto).IsRequired().HasMaxLength(1000);

            builder.HasMany(g => g.Postagems).WithOne(p => p.Grupo);
        }
    }
}
