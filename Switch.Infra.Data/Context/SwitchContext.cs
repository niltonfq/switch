using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;

// dotnet ef migrations add UsuarioConfiguration -v -p ../Switch.Infra.Data/
// dotnet ef migrations add InitialMigration -s ../Switch.API/
//dotnet ef database update
// dotnet ef database update 20190301172307_InitialMigration
// dotnet ef migrations remove -v -p ../Switch.Infra.Data/
// dotnet ef database update 0
namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        // por convenção
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagems { get; set; }
        public DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Identificacao> Identificacao { get; set; }
        public DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PostagemConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioGrupoConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        // fluente API
        // por configuração forma configuração explícita
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Usuario>(entity => {
        //        entity.HasKey(u => u.Id);

        //        entity.Property(u => u.Nome)
        //            .IsRequired()
        //            .HasMaxLength(400);
        //    });

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
