using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class TarefasSistemaDBContext : DbContext
    {
        public TarefasSistemaDBContext(DbContextOptions<TarefasSistemaDBContext> options)
            :base(options)
        {
            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<TarefaModel> Tarefas { get; set; }

        public DbSet<CronogramaModel> Cronogramas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            modelBuilder.ApplyConfiguration(new CronogramaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
