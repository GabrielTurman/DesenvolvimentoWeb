using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data.Map
{
    public class CronogramaMap : IEntityTypeConfiguration<CronogramaModel>
    {

        public void Configure(EntityTypeBuilder<CronogramaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataEntrega).IsRequired();
            builder.Property(x => x.DataRealizacao).IsRequired();
            builder.Property(x => x.Tarefa).IsRequired();
        }

    }
}
