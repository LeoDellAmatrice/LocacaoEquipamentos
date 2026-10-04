using System.ComponentModel;

namespace LocacaoEquipamentos.Enums
{
    public enum SituacaoEquipamentoEnum
    {
        [Description("Disponivel")]
        Disponivel,

        [Description("Alugado")]
        Alugado,

        [Description("Em Manutenção")]
        EmManutencao,

        [Description("Inativo")]
        Inativo
    }
}
