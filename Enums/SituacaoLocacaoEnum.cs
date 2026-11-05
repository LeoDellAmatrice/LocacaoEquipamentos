using System.ComponentModel;

namespace LocacaoEquipamentos.Enums
{
    public enum SituacaoLocacaoEnum
    {
        [Description("Aberta")]
        Aberta,

        [Description("Finalizada")]
        Finalizada,

        [Description("Cancelada")]
        Cancelada
    }
}
