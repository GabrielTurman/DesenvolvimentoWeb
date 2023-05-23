namespace SistemaDeTarefas.Models
{
    public class CronogramaModel
    {
        public int Id { get; set; }

        public DateTime? DataRealizacao { get; set; }

        public DateTime? DataEntrega { get; set; }

        public List<TarefaModel> Tarefa { get; set; }

        public CronogramaModel()
        {
            Tarefa = new List<TarefaModel>();
        }
    }
}
