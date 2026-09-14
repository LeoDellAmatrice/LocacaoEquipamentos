using LocacaoEquipamentos.Enums;

namespace LocacaoEquipamentos.Classes
{
    public class TiposEquipamentos
    {
        public TipoEquipamentoEnum TipoEquipamento { get; private set; }

        public decimal MultaDiaria { get; set; }

        public TiposEquipamentos(TipoEquipamentoEnum tipoEquipamento)
        {
            TipoEquipamento = tipoEquipamento;

            SetMultaDiaria();
        }

        private void SetMultaDiaria()
        {
            switch (TipoEquipamento)
            {
                case TipoEquipamentoEnum.Ferramenta:
                    MultaDiaria = 0.20m;
                    break;
                case TipoEquipamentoEnum.Informatica:
                    MultaDiaria = 0.30m;
                    break;
                case TipoEquipamentoEnum.MaquinaPesada:
                    MultaDiaria = 0.40m;
                    break;
            }
        }
    }
}
