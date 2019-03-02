using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioGrupoConfiguration : IEntityTypeConfiguration<UsuarioGrupo>
    {
        public UsuarioGrupoConfiguration()
        {

        }

        //public int Id { get; set; }
        //public DateTime DataCriacao { get; set; }
        //public bool EhAdministrador { get; set; }
        public void Configure(EntityTypeBuilder<UsuarioGrupo> builder)
        {
            builder.HasKey(p => new { p.UsuarioId, p.GrupoId });
            builder.Property(p => p.DataCriacao).IsRequired();
            builder.Property(p => p.EhAdministrador);

        }
    }
}
