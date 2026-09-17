using LocacaoEquipamentos.Enums;

namespace LocacaoEquipamentos.Classes
{
    public static class TiposEquipamentos
    {
        public static decimal GetMultaDiaria(TipoEquipamentoEnum tipoEquipamento)
        {
            switch (tipoEquipamento)
            {
                case TipoEquipamentoEnum.Ferramenta:
                    return 0.20m;

                case TipoEquipamentoEnum.Informatica:
                    return 0.30m;

                case TipoEquipamentoEnum.MaquinaPesada:
                    return 0.40m;
                default:
                    return 0;
            }
        }
    }
}
