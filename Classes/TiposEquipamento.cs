using LocacaoEquipamentos.Enums;

namespace LocacaoEquipamentos.Classes
{
    public class TiposEquipamentos
    {
        public EnumTipoEquipamento TipoEquipamento { get; private set; }

        public decimal MultaDiaria { get; set; }

        public TiposEquipamentos(EnumTipoEquipamento tipoEquipamento)
        {
            TipoEquipamento = tipoEquipamento;

            SetMultaDiaria();
        }

        private void SetMultaDiaria()
        {
            switch (TipoEquipamento)
            {
                case EnumTipoEquipamento.Ferramenta:
                    MultaDiaria = 0.20m;
                    break;
                case EnumTipoEquipamento.Informatica:
                    MultaDiaria = 0.30m;
                    break;
                case EnumTipoEquipamento.MaquinaPesada:
                    MultaDiaria = 0.40m;
                    break;
            }
        }
    }
}
