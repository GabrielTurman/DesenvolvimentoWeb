using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        aFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluida")]
        Concluido = 3

    }
}
